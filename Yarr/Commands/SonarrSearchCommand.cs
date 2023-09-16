using JetBrains.Annotations;
using Microsoft.Extensions.Options;
using Yarr.Clients;
using Yarr.Settings;
using Sonarr.OpenAPI.Model;
using Spectre.Console;
using Spectre.Console.Cli;
using Spectre.Console.Rendering;
using Yarr.Configuration;
using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace Yarr.Commands;

[UsedImplicitly]
public class SonarrSearchCommand : Command<SonarrSettings>
{
    private readonly SonarrClient _client;
    private readonly SonarrConfiguration _configuration;
    private const string Emphasis = "blue";
    private const string Emphasis1 = "aqua";
    private const string Emphasis2 = "orange1";
    private readonly bool _disableSeasonSelection = true;
    private const int CancelId = -9999;

    public SonarrSearchCommand(SonarrClient client, IOptions<SonarrConfiguration> configuration)
    {
        _client = client;
        _configuration = configuration.Value;
    }

    // ReSharper disable RedundantNullableFlowAttribute
    public override int Execute([NotNull] CommandContext context, [NotNull] SonarrSettings settings)
    {
        AnsiConsole.MarkupLine($"Sonarr search results for \"[{Emphasis}]{settings.Search}[/]\"");
        var series = _client.SearchSeries(settings.Search);
        if (settings.Year.HasValue)
        {
            series = series.Where(a => a.Year >= settings.Year - 1 && a.Year <= settings.Year + 1).ToList();
        }

        series = series.Take(settings.SearchResults).ToList();

        var grid = new Table();
        grid.AddColumns(
            new TableColumn("#"),
            new TableColumn("Title"),
            new TableColumn("Year"),
            new TableColumn("Seasons"),
            new TableColumn("Monitored"),
            new TableColumn("Network"),
            new TableColumn("Genres")
        );
        foreach (var (s, i) in series.Select((s, i) => (s, i + 1)))
        {
            var cols = GetColumns(s);
            cols = new IRenderable[] { new Text(i.ToString()) }.Union(cols).ToArray();
            grid.AddRow(cols);
            // Add index for visual selection
            s.Title = $"{i,2} {s.Title}";
        }

        AnsiConsole.Write(grid);


        AnsiConsole.MarkupLine($"Select a series:");
        series.Add(new SeriesResource(CancelId));
        var selected = AnsiConsole.Prompt(
            new SelectionPrompt<SeriesResource>
            {
                Converter = (s) => s.Title ?? "   Cancel",
                HighlightStyle = Emphasis,
                PageSize = 6
            }.AddChoices(series.ToArray())
        );

        if (selected.Id == CancelId)
        {
            AnsiConsole.MarkupLine("Cancelled");
            return 1;
        }
        // Remove index from title
        selected.Title = selected.Title[3..];

        AnsiConsole.MarkupLine($"* [{Emphasis}]{selected.Title}[/]");

        if (!_disableSeasonSelection)
        {
            var seasons = selected.Seasons!.ToList();
            seasons.Add(new SeasonResource(CancelId));
            SeasonResource selectedSeason = AnsiConsole.Prompt(
                new SelectionPrompt<SeasonResource>
                {
                    // Title = $"Select a season [{Emphasis}]{selected.title}[/]",
                    HighlightStyle = Emphasis1,
                    PageSize = 5
                }.AddChoices(seasons)
            );

            if (selectedSeason.SeasonNumber == CancelId)
            {
                AnsiConsole.MarkupLine("Cancelled");
                return 1;
            }

            AnsiConsole.MarkupLine($"* [{Emphasis1}]{selectedSeason.SeasonNumber:d2}[/]");
        }

        var monitorType = MonitorTypes.Future;

        var profiles = _client.GetProfiles();


        // Move default to the top
        var myDefault = 
            _configuration.DefaultQualityProfile != null 
                ? profiles.SingleOrDefault(a => a.Name == _configuration.DefaultQualityProfile) 
                : null;
        if (myDefault != null)
        {
            profiles.Remove(myDefault);
            profiles.Insert(0, myDefault);
        }

        var selectedQuality = myDefault;
        if (selectedQuality == null && _configuration.SkipQualitySelection != true)
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
        else
        {
            var monitorTypes = new []
            {
                MonitorTypes.FirstSeason,
                MonitorTypes.LatestSeason,
                MonitorTypes.Future,
                MonitorTypes.All,
                MonitorTypes.Unknown
            };
            monitorType = AnsiConsole.Prompt(
                new SelectionPrompt<MonitorTypes>
                {
                    Converter = o => Enum.GetName(o) ?? $"---",
                    HighlightStyle = Emphasis1,
                    PageSize = 6
                }.AddChoices(monitorTypes )
            );

            if (monitorType == MonitorTypes.Unknown)
            {
                AnsiConsole.MarkupLine("Cancelled");
                return 1;
            }
            AnsiConsole.MarkupLine($"* [{Emphasis1}]Season {monitorType}[/]");
        }        
        
        if (selectedQuality == null)
        {
            AnsiConsole.MarkupLine("Quality profile not found");
            return 1;
        }

        AnsiConsole.MarkupLine($"* [{Emphasis2}]Quality {selectedQuality.Name}[/]");

        var addSeries = AnsiConsole.Prompt(
            new ConfirmationPrompt($"Add [{Emphasis}]{selected.Title}[/] - [{Emphasis1}]{monitorType}[/] - [{Emphasis2}]{selectedQuality.Name}[/]?")
        );

        if (addSeries)
        {
            _client.AddSeries(selected, monitorType, selectedQuality);
            AnsiConsole.MarkupLine($"Successfully added [{Emphasis}]{selected.Title}[/] - [{Emphasis1}]{monitorType}[/] - [{Emphasis2}]{selectedQuality.Name}[/]");
        }

        return 0;
    }
    
    private IRenderable[] GetColumns(SeriesResource seriesResource)
    {
        return new IRenderable[] {
            new Text(seriesResource.Title ?? "Unknown"),
            new Text(seriesResource.Year.ToString()),
            new Text(seriesResource.Seasons?.Count.ToString() ?? ""),
            new Text(seriesResource.Id  >= 1 ? "Yes" : ""),
            new Text(seriesResource.Network ?? "-"),
            new Text(string.Join(", ", seriesResource.Genres?.ToArray() ?? new [] {""}))
        };
    }
}