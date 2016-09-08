# Expandable F# compiler (fscx)

![fscx-projects](https://raw.githubusercontent.com/fscx-projects/fscx/master/docs/files/img/fscx_128.png)

Easy infrastructure can replace F#'s AST at compile time.

* TODO: Still under construction...

## Status

| NuGet (fscx) | [![NuGet fscx](https://img.shields.io/nuget/v/fscx.svg?style=flat)](https://www.nuget.org/packages/fscx) |
|:------------:|:----:|
| NuGet (core lib) | [![NuGet fscx](https://img.shields.io/nuget/v/FSharp.Expandable.Compiler.Core.svg?style=flat)](https://www.nuget.org/packages/FSharp.Expandable.Compiler.Core) |
|:------------:|:----:|
| CI (AppVeyor) | [![AppVeyor fscx](https://img.shields.io/appveyor/ci/kekyo/fscx/master.svg)](https://ci.appveyor.com/project/kekyo/fscx) |
|:------------:|:----:|
| Issue status | [![Issue Stats](http://issuestats.com/github/fscx-projects/fscx/badge/issue)](http://issuestats.com/github/fscx-projects/fscx) |
|:------------:|:----:|
| Pull req | [![PR Stats](http://issuestats.com/github/fscx-projects/fscx/badge/pr)](http://issuestats.com/github/fscx-projects/fscx) |
|:------------:|:----:|
| Gitter chat | [![Gitter char](https://img.shields.io/gitter/room/fscx-projects/Lobby.js.svg)](https://gitter.im/fscx-projects/Lobby) |

## How applicable fscx?

![For filter users](https://github.com/fscx-projects/fscx/raw/master/docs/files/img/HowApplicableFscx/slide1.png)

![For filter developer](https://github.com/fscx-projects/fscx/raw/master/docs/files/img/HowApplicableFscx/slide2.png)

## Filter project sample nuspec

```xml
<?xml version="1.0"?>
<package xmlns="http://schemas.microsoft.com/packaging/2010/07/nuspec.xsd">
  <metadata>
    <id>fscx-sample-filter</id>
    <version>0.1.3-pre</version>
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
      <!-- More better auto-install fscx by dependency. -->
      <dependency id="fscx" version="0.1.25" />
    </dependencies>
  </metadata>
  <files>
    <!-- Place filter binary (and pdb) into "build" package folder (NOT into "lib"). -->
    <!-- Because prevent auto added assembly reference. -->
    <file src="bin/Debug/sample_filter.dll" target="build" />
    <file src="bin/Debug/sample_filter.pdb" target="build" />
  </files>
</package>
```

## Maintainer(s)

- [Kouji Matsui](https://github.com/kekyo) [twitter](https://twitter.com/kekyo2)
- [bleis-tift](https://github.com/bleis-tift) [twitter](https://twitter.com/bleis)
