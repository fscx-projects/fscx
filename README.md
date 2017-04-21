# Expandable F# compiler (fscx)

![fscx-projects](https://raw.githubusercontent.com/fscx-projects/fscx/master/docs/files/img/fscx_128.png)

Expandable F# compiler (fscx) is an alternative F# compiler which enables to replace F#'s AST at compile time.

* TODO: This project is still work in progress, and need more documents.

## Status

| NuGet (build) | [![NuGet fscx build](https://img.shields.io/nuget/v/FSharp.Expandable.Compiler.build.svg?style=flat)](https://www.nuget.org/packages/FSharp.Expandable.Compiler.Build) |
|:----|:----:|
| NuGet (core lib) | [![NuGet fscx core](https://img.shields.io/nuget/v/FSharp.Expandable.Compiler.Core.svg?style=flat)](https://www.nuget.org/packages/FSharp.Expandable.Compiler.Core) |
| NuGet (aspect lib) | [![NuGet aspect lib](https://img.shields.io/nuget/v/FSharp.Expandable.Compiler.Aspect.svg?style=flat)](https://www.nuget.org/packages/FSharp.Expandable.Compiler.Aspect) |
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

### Resources

* Blog post: [About Expandable F# Compiler project - F# Advent Calendar in English 2016](http://www.kekyo.net/2016/12/23/6305)
  * This post is 23th ["F# Advent Calendar in English 2016"](https://sergeytihon.wordpress.com/2016/10/23/f-advent-calendar-in-english-2016/)
  * [(In japanese)](http://www.kekyo.net/2016/12/23/6263)

## Sample filter projects (For filter developer)

See also [fscx-sample-filters](https://github.com/fscx-projects/fscx-sample-filters/).

## Maintainer(s)

- [Kouji Matsui](https://github.com/kekyo) [twitter](https://twitter.com/kekyo2)
- [bleis-tift](https://github.com/bleis-tift) [twitter](https://twitter.com/bleis)
