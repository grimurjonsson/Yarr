using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Yarr.Configuration;

public static class YarrConfiguration
{
    public static string ConfigurationPath { get; } = 
        Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".config", "Yarr", "Yarr.json");

    public static bool IsSonarrConfigured()
    {
        return string.IsNullOrWhiteSpace(GetSonarrUrl()) || string.IsNullOrWhiteSpace(GetSonarrApiKey());
    }

    public static bool IsRadarrConfigured()
    {
        return string.IsNullOrWhiteSpace(GetRadarrUrl()) || string.IsNullOrWhiteSpace(GetRadarrApiKey());
    }

    public static void UpdateApiConfiguration(string sonarrUrl, string sonarrKey, string sonarrDefaultQuality, bool sonarrSkipQualitySelection, string radarrUrl, string radarrKey)
    {
        // Use the ConfigurationClasses
        var sonarr = new JObject(
            new JProperty("BaseUrl", new JValue(sonarrUrl)),
            new JProperty("ApiKey", new JValue(sonarrKey)),
            new JProperty("DefaultQualityProfile", new JValue(sonarrDefaultQuality)),
            new JProperty("SkipQualitySelection", new JValue(sonarrSkipQualitySelection))
        );
        
        var radarr = new JObject(
            new JProperty("BaseUrl", new JValue(radarrUrl)),
            new JProperty("ApiKey", new JValue(radarrKey))
        );
        
        var root = new JObject(
          new JProperty("Sonarr", sonarr),
          new JProperty("Radarr", radarr)
        );
                
        var newJson = JsonConvert.SerializeObject(root, Formatting.Indented);
        File.WriteAllText(ConfigurationPath, newJson);
    }

    public static string GetSonarrUrl()
    {
        return GetConfiguration("Sonarr:BaseUrl");
    }
    public static string GetSonarrApiKey()
    {
        return GetConfiguration("Sonarr:ApiKey");
    }
    public static string GetRadarrUrl()
    {
        return GetConfiguration("Radarr:BaseUrl");
    }
    public static string GetRadarrApiKey()
    {
        return GetConfiguration("Radarr:ApiKey");
    }
    
    private static string GetConfiguration(string key)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile(ConfigurationPath, optional: false, reloadOnChange: true)
            .Build();

        return configuration[key] ?? string.Empty;
    }

    public static string GetSonarrDefaultQualityProfile()
    {
        return GetConfiguration("Sonarr:DefaultQualityProfile");
    }

    public static bool GetSonarrSkipQualitySelection()
    {
        var val = GetConfiguration("Sonarr:SkipQualitySelection");
        return bool.TryParse(val, out var result) && result;
    }
}