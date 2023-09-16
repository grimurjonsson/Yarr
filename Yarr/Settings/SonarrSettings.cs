using System.ComponentModel;
using JetBrains.Annotations;
using Spectre.Console;
using Spectre.Console.Cli;

namespace Yarr.Settings;

[UsedImplicitly]
public class SonarrSettings : CommandSettings
{
    [CommandArgument(0, "<TITLE>")]
    public string Search { get; init; } = "";

    [CommandOption("-y|--year")]
    [UsedImplicitly]
    public int? Year { get; set; }

    [CommandOption("-r|--results")]
    [UsedImplicitly]
    [DefaultValue(5)]
    public int SearchResults { get; set; }
    
    public override ValidationResult Validate()
    {
        if (Year < 1900) return ValidationResult.Error("Year must be greater than 1900");
        if (Search.Length < 2) return ValidationResult.Error("Names must be at least two characters long");
            
        return ValidationResult.Success();
    }
}