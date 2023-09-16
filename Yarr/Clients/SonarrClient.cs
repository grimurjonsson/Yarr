using JetBrains.Annotations;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Sonarr.OpenAPI.Api;
using Sonarr.OpenAPI.Model;
using Spectre.Console;
using Yarr.Configuration;
using SonarrApiConfiguration = Sonarr.OpenAPI.Client.Configuration;
namespace Yarr.Clients;

[UsedImplicitly]
public class SonarrClient
{
    private readonly SonarrApiConfiguration _configuration;
    
    public SonarrClient(IOptionsSnapshot<SonarrConfiguration> options)
    {
        _configuration = new SonarrApiConfiguration
        {
            BasePath = options.Value.BaseUrl
        };
        _configuration.DefaultHeaders.Add("X-Api-Key", options.Value.ApiKey);
    }

    public void AddSeries(SeriesResource series, MonitorTypes monitorTypes, QualityProfileResource qualityProfile)
    {
        var api = new SeriesApi(_configuration);
        series.Monitored = true;
        series.AddOptions = new AddSeriesOptions
        {
            Monitor = monitorTypes
        };
        series.SeriesType = SeriesTypes.Standard;
        series.QualityProfileId = qualityProfile.Id;
        series.RootFolderPath = GetRootFolder().Path;
        // series.OriginalLanguage = new Language(1);

        // Reflections, cause deprecated, but still required.
        series.GetType().GetProperty("LanguageProfileId")?.SetValue(series, 1);

        var updating =  series.Id >= 1;
        var response = updating 
            ? api.ApiV3SeriesIdPutWithHttpInfo(series.Id.ToString(), seriesResource: series) 
            : api.ApiV3SeriesPostWithHttpInfo(series);
        
        if (response.ErrorText != null)
        {
            AnsiConsole.MarkupLine($"[red]Error {(updating ? "updating" : "adding")} series. StatusCode: {response.StatusCode}[/]");
            throw new Exception(response.RawContent);
        }
    }
    
    public List<SeriesResource> SearchSeries(string term)
    {
        var api = new SeriesLookupApi(_configuration);
        var response = api.ApiV3SeriesLookupGetWithHttpInfo(term);
        if (response.ErrorText != null)
        {
            AnsiConsole.MarkupLine($"[red]Error searching. StatusCode: {response.StatusCode}[/]");
            throw new Exception(response.RawContent);
        }
        return JsonConvert.DeserializeObject<List<SeriesResource>>(response.Content.ToString() ?? string.Empty) ?? new List<SeriesResource>();
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
}