# Expandable F# compiler (fscx)

![fscx-projects](https://raw.githubusercontent.com/fscx-projects/fscx/master/docs/files/img/fscx_128.png)

Expandable F# compiler (fscx) is an alternative F# compiler which enables to replace F#'s AST at compile time.

* TODO: This project is still work in progress, and need more documents.

## Status

| NuGet (build) | [![NuGet fscx build](https://img.shields.io/nuget/v/FSharp.Expandable.Compiler.build.svg?style=flat)](https://www.nuget.org/packages/FSharp.Expandable.Compiler.Build) |
|:----|:----:|
| NuGet (core lib) | [![NuGet fscx core](https://img.shields.io/nuget/v/FSharp.Expandable.Compiler.Core.svg?style=flat)](https://www.nuget.org/packages/FSharp.Expandable.Compiler.Core) |
| CI (AppVeyor) | [![AppVeyor fscx](https://img.shields.io/appveyor/ci/kekyo/fscx/master.svg)](https://ci.appveyor.com/project/kekyo/fscx) |
| Issue status | [![Issue Stats](http://issuestats.com/github/fscx-projects/fscx/badge/issue)](http://issuestats.com/github/fscx-projects/fscx) |
| Pull req | [![PR Stats](http://issuestats.com/github/fscx-projects/fscx/badge/pr)](http://issuestats.com/github/fscx-projects/fscx) |
| Gitter chat | [![Gitter char](https://img.shields.io/gitter/room/fscx-projects/Lobby.js.svg)](https://gitter.im/fscx-projects/Lobby) |

## How fscx works?

### For filter users

fscx can apply user defined filters at compile time.
To use fscx, you need to install fscx's filter packages via NuGet.

![For filter users](https://github.com/fscx-projects/fscx/raw/master/docs/files/img/HowApplicableFscx/slide1.png)

### For filter developers

For developers who want to create filters, you need to install `FSharp.Expandable.Compiler.Core` via NuGet to your project, build the project to create a nupkg, and then publish the nupkg file.

![For filter developers](https://github.com/fscx-projects/fscx/raw/master/docs/files/img/HowApplicableFscx/slide2.png)

### Overall

Building architechture overall illustrated:

![Overall](https://github.com/fscx-projects/fscx/raw/master/docs/files/img/HowApplicableFscx/slide3.png)

## Filter project sample nuspec (For filter developer)

Pack to the filter package, using NuGet with following sample nuspec definitions:

```xml
<?xml version="1.0"?>
<package xmlns="http://schemas.microsoft.com/packaging/2010/07/nuspec.xsd">
  <metadata>
    <id>fscx-sample-filter</id>
    <version>0.5.1-pre</version>
    <title>fscx-sample-filter</title>
    <authors>Kouji Matsui</authors>
    <owners>Kouji Matsui</owners>
    <summary>Expandable F# compiler's sample custom filter package.</summary>
    <description>Expandable F# compiler's sample custom filter package.</description>
    <copyright>Author: Kouji Matsui, bleis-tift</copyright>
    <projectUrl>http://github.com/fscx-projects/fscx</projectUrl>
    <iconUrl>https://raw.githubusercontent.com/fscx-projects/fscx/master/docs/files/img/fscx_128.png</iconUrl>
    <requireLicenseAcceptance>false</requireLicenseAcceptance>
    <releaseNotes>Expandable F# compiler's sample custom filter package.</releaseNotes>
    <tags>fscx</tags>
    <dependencies>
      <!-- Including fscx dependency is highly recommended. -->
      <dependency id="FSharp.Expandable.Compiler.Build" version="0.5.1" />
    </dependencies>
  </metadata>
  <files>
    <!-- Add filter binaries (and pdb files if needed) into "build" package folder. -->
    <!-- Note that it's not "lib" folder because we should avoid to get these assemblies referenced automatically. -->
    <file src="bin/Debug/sample_filter.dll" target="build" />
    <file src="bin/Debug/sample_filter.pdb" target="build" />
  </files>
</package>
```

## Maintainer(s)

- [Kouji Matsui](https://github.com/kekyo) [twitter](https://twitter.com/kekyo2)
- [bleis-tift](https://github.com/bleis-tift) [twitter](https://twitter.com/bleis)
