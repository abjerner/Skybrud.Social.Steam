Skybrud.Social.Steam
========================

As an add-on for [Skybrud.Social](https://github.com/abjerner/Skybrud.Social), **Skybrud.Social.Steam** helps you with both authentication as well as raw and object-oriented communication with the Steam API.

### Beta

This package is currently in beta, which primarily means that it is still under development. This may lead to breaking changes between each beta release.

If you're looking for a stable release, you can use the older [SteamOAuth](https://github.com/XeroMS/SteamOAuth/) instead, which adds support for the Steam API to Skybrud.Social.

### Installation

You can download this package from either NuGet (recommended) or download a ZIP file with the neccessary files from here on GitHub:

1. [**NuGet Package**][NuGetPackage]  
Install this NuGet package in your Visual Studio project. Makes updating easy.

2. [**ZIP file**][Releases]  
Grab a ZIP file of the latest release; unzip and move the files to the bin directory of your project.

### Dependencies

- [**Skybrud.Social.Core**](https://github.com/abjerner/Skybrud.Social)<br />A package with common logic used throughout the Skybrud.Social packages.

  - [**Json.NET**](https://github.com/jamesnk/newtonsoft.json)<br />Used for searializing/deserializing JSON.

  - [**Skybrud.Essentials**](https://github.com/skybrud/Skybrud.Essentials)<br />A package with logic for handling various common tasks in .NET.

### Found a bug? Have a question?

* Please feel free to [**create an issue**][Issues], and I will get back to you ;)

### Changelog

The [**releases page**][Releases] lists all releases, and each there will be some information for each release on the most significant changes.

### Documentation

You can find documentation and examples on how to use this package at the [**Skybrud.Social.Steam Wiki**][Documentation]. The package isn't yet fully documented, so feel free to [**create an issue**][Issues] if I've missed something.

[Website]: http://zdindustries.com/projects/skybrud.social.steam/
[Documentation]: https://gitlab.com/zdindustries/shared/Skybrud.Social.Steam/wikis/home
[NuGetPackage]: https://www.nuget.org/packages/Skybrud.Social.Steam
[Releases]: https://gitlab.com/zdindustries/shared/Skybrud.Social.Steam/tags
[Issues]: https://gitlab.com/zdindustries/shared/Skybrud.Social.Steam/issues
