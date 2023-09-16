# Yarr
> Like a pirate but also cause sonArr and radArr

The Yarr tool is a CLI tool that allows you to interact with Sonarr and Radarr.


## Installation

To install the program to the default location (`/usr/local/bin`) run the following command. This may require sudo depending on your system.
```bash
make install_mac_intel
or
make install_mac_silicon
```

#### Custom location
Alternatively you can install to a custom location.
Run one of the following commands to build the tool for your platform
- `make publish_mac_intel` - Build for Mac Intel
- `make publish_mac_silicon` - Build for Mac Silicon
- `make publish_win` - Build for Windows
- `make publish_linux` - Build for Linux

Then copy the binary to your desired location and add it to your $PATH variable if needed.

## Configuration
Run either of the following commands to input your Sonarr/Radarr configuration (the "configure configure" is not a typo)
```bash
Yarr configure configure
Yarr c c
```
You will be prompted for the required information.
The configuration will be stored in `~/.config/yarr/config.json` or `%APPDATA%\.config\yarr\config.json` on Windows.

## Usage

### Search for a series
```bash
Yarr sonarr search "The Simpsons"
Yarr s s "The Simpsons"
```

### Search for a movie
```bash
Yarr radarr search "Terminator"
Yarr r s "The Simpsons"
```

## Developer's corner

### Generate Sonarr API client
```bash
npx openapi-generator-cli \
    generate -g csharp-netcore \
    -i sonarr.json \ 
    -o sonarrgen \
     --additional-properties packageName=Sonarr.OpenAPI
```
copy the generated files to the project

#### Fixing the generated code for the Sonarr API
An issue with the sonarr api is that it requires a `languageProfileId` to be set when adding/updating series. This properties has been `deprecated`
- This requires the manual removal of the `ShouldSerializeLanguageProfileId()` from `SeriesResource.cs`
- Add `#pragma warning disable CS0612 // Type or member is obsolete` to the top of the file to get rid of the annoying compiler warnings

### Generate Radarr API client
```bash
npx openapi-generator-cli \
    generate -g csharp-netcore \
    -i radarr.json \ 
    -o radarrgen \
     --additional-properties packageName=Radarr.OpenAPI
```

