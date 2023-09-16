using Yarr.Clients;
using Yarr.Commands;
using Yarr.Configuration;
using Yarr.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Spectre.Console;
using Spectre.Console.Cli;

var builder = Host.CreateApplicationBuilder(args);
builder.Configuration.AddJsonFile(YarrConfiguration.ConfigurationPath, optional: false, reloadOnChange: true);
builder.Services.AddOptions<SonarrConfiguration>().BindConfiguration("Sonarr");
builder.Services.AddTransient<SonarrClient>();
builder.Services.AddOptions<RadarrConfiguration>().BindConfiguration("Radarr");
builder.Services.AddTransient<RadarrClient>();

var typeRegistrar = new TypeRegistrar(builder.Services);
var app = new CommandApp(typeRegistrar);
    app.Configure(config =>
    {
        config.AddBranch("sonarr", a =>
                a.AddCommand<SonarrSearchCommand>("search").WithAlias("s")
            ).WithAlias("s");
        config.AddBranch("radarr", a =>
            a.AddCommand<RadarrSearchCommand>("search").WithAlias("s")
        ).WithAlias("r");
        config.AddBranch("configure", a =>
            a.AddCommand<ConfigureCommand>("configure").WithAlias("c")
        ).WithAlias("c");
    }
    );

try
{
    return app.Run(args);
}
catch (Exception e)
{
    AnsiConsole.MarkupLine($"[red]{e.Message}[/]");
    return 1;
}


