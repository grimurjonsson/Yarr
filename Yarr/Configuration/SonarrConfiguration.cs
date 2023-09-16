using JetBrains.Annotations;

namespace Yarr.Configuration;

public class SonarrConfiguration
{
    public string? BaseUrl { get; set; }
    public string? ApiKey { get; set; }
    public string? DefaultQualityProfile { get; set; }
    public bool? SkipQualitySelection { get; set; }
}