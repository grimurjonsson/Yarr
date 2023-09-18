using JetBrains.Annotations;
using Yarr.Configuration;
using Yarr.Settings;
using Spectre.Console;
using Spectre.Console.Cli;
using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace Yarr.Commands;

[UsedImplicitly]
public class ConfigureCommand : Command<ConfigureSettings>
{

    // ReSharper disable RedundantNullableFlowAttribute
    public override int Execute([NotNull] CommandContext context, [NotNull] ConfigureSettings settings)
    {
        var su = AnsiConsole.Prompt(new TextPrompt<string>("Sonarr base Url (http://example.com:1234):")
            .DefaultValue(YarrConfiguration.GetSonarrUrl())
            .ShowDefaultValue(true)
        );
        var sa = AnsiConsole.Prompt(new TextPrompt<string>("Sonarr ApiKey:")
            .DefaultValue(YarrConfiguration.GetSonarrApiKey())
            .ShowDefaultValue(true)
        );
        var sdq = AnsiConsole.Prompt(new TextPrompt<string>("Sonarr Default Quality Name (optional, add dropdown here pls):")
            .DefaultValue(YarrConfiguration.GetSonarrDefaultQualityProfile())
            .ShowDefaultValue(true)
        );

        var sds = false;
        if (!string.IsNullOrWhiteSpace(sdq))
        {
            var prompt = new ConfirmationPrompt("Sonarr - Disable quality selection:")
            {
                DefaultValue = YarrConfiguration.GetSonarrSkipQualitySelection(),
                ShowDefaultValue = true
            };
            sds = AnsiConsole.Prompt(prompt);
        }

        var ru = AnsiConsole.Prompt(new TextPrompt<string>("Radarr base Url (http://example.com:1234):")
            .DefaultValue(YarrConfiguration.GetRadarrUrl())
            .ShowDefaultValue(true)
        );
        var ra = AnsiConsole.Prompt(new TextPrompt<string>("Radarr ApiKey:")
            .DefaultValue(YarrConfiguration.GetRadarrApiKey())
            .ShowDefaultValue(true)
        );
        
        YarrConfiguration.UpdateApiConfiguration(su, sa, sdq, sds, ru, ra);
        AnsiConsole.MarkupLine("Configuration updated");
        return 0;
    }
}