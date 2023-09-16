using JetBrains.Annotations;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Radarr.OpenAPI.Api;
using Radarr.OpenAPI.Client;
using Radarr.OpenAPI.Model;
using Spectre.Console;
using Yarr.Configuration;
using RadarrApiConfiguration = Radarr.OpenAPI.Client.Configuration;

namespace Yarr.Clients;

[UsedImplicitly]
public class RadarrClient
{
    private readonly RadarrApiConfiguration _configuration;
    
    public RadarrClient(IOptionsSnapshot<RadarrConfiguration> options)
    {
        _configuration = new RadarrApiConfiguration
        {
            BasePath = options.Value.BaseUrl
        };
        _configuration.DefaultHeaders.Add("X-Api-Key", options.Value.ApiKey);
    }

    public List<MovieResource> SearchMovies(string term)
    {
        var api = new MovieLookupApi(_configuration);
        var response = api.ApiV3MovieLookupGetWithHttpInfo(term);
        if (response.ErrorText != null)
        {
            AnsiConsole.MarkupLine($"[red]Error searching. StatusCode: {response.StatusCode}[/]");
            throw new Exception(response.RawContent);
        }
        return JsonConvert.DeserializeObject<List<MovieResource>>(response.Content.ToString() ?? string.Empty) ?? new List<MovieResource>();
    }

    public List<QualityProfileResource> GetProfiles()
    {
        var api = new QualityProfileApi(_configuration);
        var response = api.ApiV3QualityprofileGetWithHttpInfo();
        if (response.ErrorText != null)
        {
            AnsiConsole.MarkupLine($"[red]Error searching. StatusCode: {response.StatusCode}[/]");
            throw new Exception(response.RawContent);
        }

        return response.Data;
    }
    
    private RootFolderResource GetRootFolder()
    {
        var api = new RootFolderApi(_configuration);
        var response = api.ApiV3RootfolderGetWithHttpInfo();
        if (response.ErrorText != null)
        {
            AnsiConsole.MarkupLine($"[red]Error searching. StatusCode: {response.StatusCode}[/]");
            throw new Exception(response.RawContent);
        }

        return response.Data.First();
    }

    public void AddMovie(MovieResource movie, QualityProfileResource qualityProfile)
    {
        var api = new MovieApi(_configuration);
        movie.Monitored = true;
        movie.AddOptions = new AddMovieOptions
        {
            Monitor = MonitorTypes.MovieOnly,
            SearchForMovie = true
        };
        movie.QualityProfileId = qualityProfile.Id;
        movie.RootFolderPath = GetRootFolder().Path;

        var updating = movie.Id >= 1;
        ApiResponse<MovieResource> response;
        if (updating)
        {
            response = api.ApiV3MovieIdPutWithHttpInfo(movie.Id.ToString(), movieResource: movie);
        }
        else
        {
            response = api.ApiV3MoviePostWithHttpInfo(movie);
        }
        
        if (response.ErrorText != null)
        {
            AnsiConsole.MarkupLine($"[red]Error {(updating ? "updating" : "adding")} movie. StatusCode: {response.StatusCode}[/]");
            throw new Exception(response.RawContent);
        }
    }

}