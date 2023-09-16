using JetBrains.Annotations;
using Yarr.Clients;
using Yarr.Settings;
using Radarr.OpenAPI.Model;
using Spectre.Console;
using Spectre.Console.Cli;
using Spectre.Console.Rendering;
using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace Yarr.Commands;

[UsedImplicitly]
public class RadarrSearchCommand : Command<RadarrSettings>
{
    private readonly RadarrClient _radarrClient;
    private const string Emphasis = "blue";
    private const string Emphasis2 = "orange1";
    private const bool DisableQualitySelection = false;
    private const int CancelId = -9999;

    public RadarrSearchCommand(RadarrClient radarrClient)
    {
        _radarrClient = radarrClient;
    }

    // ReSharper disable RedundantNullableFlowAttribute
    public override int Execute([NotNull] CommandContext context, [NotNull] RadarrSettings settings)
    {
        var profiles = _radarrClient.GetProfiles();

        AnsiConsole.MarkupLine($"Radarr search results for \"[{Emphasis}]{settings.Search}[/]\"");
        var movies = _radarrClient.SearchMovies(settings.Search);
        if (settings.Year.HasValue)
        {
            movies = movies.Where(a => a.Year >= settings.Year - 1 && a.Year <= settings.Year + 1).ToList();
        }

        movies = movies.Take(settings.SearchResults).ToList();

        var grid = new Table();
        grid.AddColumns(
            new TableColumn("#"),
            new TableColumn("Title"),
            new TableColumn("Year"),
            new TableColumn("Monitored"),
            new TableColumn("Studio"),
            new TableColumn("Genres")
        );
        foreach (var (s, i) in movies.Select((s, i) => (s, i + 1)))
        {
            var cols = GetColumns(s);
            cols = new IRenderable[] { new Text(i.ToString()) }.Union(cols).ToArray();
            grid.AddRow(cols);
            // Add index for visual selection
            s.Title = $"{i,2} {s.Title}";
        }

        AnsiConsole.Write(grid);


        AnsiConsole.MarkupLine($"Select a movie:");
        movies.Add(new MovieResource(CancelId));
        var selected = AnsiConsole.Prompt(
            new SelectionPrompt<MovieResource>
            {
                Converter = (s) => s.Title ?? "   Cancel",
                HighlightStyle = Emphasis,
                PageSize = 6
            }.AddChoices(movies.ToArray())
        );
        // Remove index from title
        selected.Title = selected.Title[3..];

        if (selected.Id == CancelId)
        {
            AnsiConsole.MarkupLine("Cancelled");
            return 1;
        }

        AnsiConsole.MarkupLine($"* [{Emphasis}]{selected.Title}[/]");

        // Hardcode my default to the top
        var myDefault = profiles.SingleOrDefault(a => a.Name?.Contains("720p/1080p") == true);
        if (myDefault != null)
        {
            profiles.Remove(myDefault);
            profiles.Insert(0, myDefault);
        }

        QualityProfileResource selectedQuality;
        if (!DisableQualitySelection)
        {
            profiles.Add(new QualityProfileResource(CancelId));
            selectedQuality = AnsiConsole.Prompt(
                new SelectionPrompt<QualityProfileResource>
                {
                    // Title = $"Select a quality profile for [{Emphasis}]{selected.title}[/]",
                    Converter = (s) => s.Name ?? "Cancel",
                    HighlightStyle = Emphasis2
                }.AddChoices(profiles)
            );

            if (selectedQuality.Id == CancelId)
            {
                AnsiConsole.MarkupLine("Cancelled");
                return 1;
            }
        }
        
        AnsiConsole.MarkupLine($"* [{Emphasis2}]Quality {selectedQuality.Name}[/]");

        var addMovie = AnsiConsole.Prompt(
            new ConfirmationPrompt($"Add [{Emphasis}]{selected.Title}[/] - [{Emphasis2}]{selectedQuality.Name}[/]?")
        );

        if (addMovie)
        {
            _radarrClient.AddMovie(selected, selectedQuality);
            AnsiConsole.MarkupLine($"Successfully added [{Emphasis}]{selected.Title}[/] - [{Emphasis2}]{selectedQuality.Name}[/]");
        }
        else
        {
            AnsiConsole.MarkupLine($"Cancelled");
            
        }

        return 0;
    }
    
    private IRenderable[] GetColumns(MovieResource resource)
    {
        return new IRenderable[] {
            new Text(resource.Title ?? "Unknown"),
            new Text(resource.Year.ToString()),
            new Text(resource.Id  >= 1 ? "Yes" : ""),
            new Text(resource.Studio ?? "-"),
            new Text(string.Join(", ", resource.Genres?.ToArray() ?? new [] {""}))
        };
    }
}