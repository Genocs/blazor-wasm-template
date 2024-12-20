<!-- PROJECT SHIELDS -->
[![License][license-shield]][license-url]
[![Build][build-shield]][build-url]
[![Packages][package-shield]][package-url]
[![Downloads][downloads-shield]][downloads-url]
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![Discord][discord-shield]][discord-url]
[![Gitter][gitter-shield]][gitter-url]
[![Twitter][twitter-shield]][twitter-url]
[![Twitterx][twitterx-shield]][twitterx-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

[license-shield]: https://img.shields.io/github/license/Genocs/blazor-wasm-template?color=2da44e&style=flat-square
[license-url]: https://github.com/Genocs/blazor-wasm-template/blob/main/LICENSE
[build-shield]: https://github.com/Genocs/blazor-wasm-template/actions/workflows/build_and_test.yml/badge.svg?branch=main
[build-url]: https://github.com/Genocs/blazor-wasm-template/actions/workflows/build_and_test.yml
[package-shield]: https://img.shields.io/badge/nuget-v.2.3.0-blue?&label=latests&logo=nuget
[package-url]: https://github.com/Genocs/blazor-wasm-template/actions/workflows/build_and_test.yml
[downloads-shield]: https://img.shields.io/nuget/dt/Genocs.Microservice.Template.svg?color=2da44e&label=downloads&logo=nuget
[downloads-url]: https://www.nuget.org/packages/Genocs.Microservice.Template
[contributors-shield]: https://img.shields.io/github/contributors/Genocs/blazor-wasm-template.svg?style=flat-square
[contributors-url]: https://github.com/Genocs/blazor-wasm-template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Genocs/blazor-wasm-template?style=flat-square
[forks-url]: https://github.com/Genocs/blazor-wasm-template/network/members
[stars-shield]: https://img.shields.io/github/stars/Genocs/blazor-wasm-template.svg?style=flat-square
[stars-url]: https://img.shields.io/github/stars/Genocs/blazor-wasm-template?style=flat-square
[issues-shield]: https://img.shields.io/github/issues/Genocs/blazor-wasm-template?style=flat-square
[issues-url]: https://github.com/Genocs/blazor-wasm-template/issues
[discord-shield]: https://img.shields.io/discord/1106846706512953385?color=%237289da&label=Discord&logo=discord&logoColor=%237289da&style=flat-square
[discord-url]: https://discord.com/invite/fWwArnkV
[gitter-shield]: https://img.shields.io/badge/chat-on%20gitter-blue.svg
[gitter-url]: https://gitter.im/genocs/
[twitter-shield]: https://img.shields.io/twitter/follow/genocs?color=1DA1F2&label=Twitter&logo=Twitter&style=flat-square
[twitter-url]: https://twitter.com/genocs
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/giovanni-emanuele-nocco-b31a5169/
[twitterx-shield]: https://img.shields.io/twitter/url/https/twitter.com/genocs.svg?style=social
[twitterx-url]: https://twitter.com/genocs


<!-- PROJECT LOGO -->
<p align="center">
  <a href="https://github.com/Genocs/blazor-wasm-template">
    <img src="https://raw.githubusercontent.com/Genocs/blazor-wasm-template/main/assets/genocs-library-logo.png" alt="Blazor Wasm Portal">
  </a>
  <h3 align="center">Blazor WebAssembly Template</h3>
  <p align="center">
    Open Source Solution Template for <a href="https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor">Blazor</a> <a href="https://webassembly.org/">WebAssembly</a> 6.0 built with <a href="https://mudblazor.com/">MudBlazor</a> Components
    <br />
    <a href="https://genocs-blog.netlify.app/blazor-wasm-template/general/getting-started/"><strong>Read the Documentation »</strong></a>
    <br />
    <br />
    <a href="https://github.com/Genocs/blazor-wasm-template/issues">Report Bug</a>
    ·
    <a href="https://github.com/Genocs/blazor-wasm-template/issues">Request Feature</a>
    .
    <a href="https://github.com/Genocs/blazor-wasm-template/issues">Request Documentation</a>
  </p>
</p>

## Blazor WebAssembly Template

The template can be used with the `genocs cli`, `dotnet new` command or with the `Visual Studio 2022`, `Visual Studio Code` IDEs.
Built with .NET9 and MudBlazor Component Library. Incorporates the most essential packages your projects will ever need. Follows Clean Architecture Principles.

## Goals

The goal of this repository is to help developers/companies kickstart their Web Application Development with a pre-built Blazor WebAssembly Template that includes several much needed components and features.

> Note that this is a frontend/client application only! The backend for this application is available in a seperate repository. 
> - Find Genocs's .NET Web API template here - [microservice-template](https://github.com/Genocs/microservice-template)

## Prerequisites

- Make sure you have the [Genocs Backend](https://github.com/Genocs/microservice-template) API Running.
- Once Genocs's .NET Web API is up and running, run the Blazor WebAssembly Project to consume it's services.

## Getting Started

Open up your Command Prompt / Powershell and run the following command to install the solution template.

```bash
dotnet new --install Genocs.BlazorWasm.Template
```

or, if you want to use a specific version of the template, use

```bash
dotnet new --install Genocs.BlazorWasm.Template::2.3.0
```

This would install the `Genocs Blazor WebAssembly Template` globally on your machine. Do note that, at the time of writing this documentation, the latest available version is **1.2.0** which is also one of the first stable release version of the package. It is highly likely that there is already a newer version available when you are reading this.

> *To get the latest version of the package, visit [nuget.org](https://www.nuget.org/packages/Genocs.BlazorWasm.Template/)*
>

**Genocs.BlazorWasm.Template::2.3.0 is compatible only with Genocs.Microservice.Template::2.3.0 and above.**

Get the .NET WebApi Microservice Template by running the following command

```
dotnet new --install Genocs.Microservice.Template::2.3.0
```

For more details on getting started, [read the documentation](https://genocs-blog.netlify.app/blazor-wasm-template/general/overview/)


## Links & Documentations

[Overview](https://https://genocs-blog.netlify.app/blazor-wasm-template/general/overview/)

[Getting Started](https://https://genocs-blog.netlify.app/blazor-wasm-template/general/getting-started/)

[Development Environment](https://https://genocs-blog.netlify.app/blazor-wasm-template/general/development-environment/)

[Participate in QNA & General Discussions](https://github.com/Genocs/blazor-wasm-template/discussions)

## Changelogs

View Complete [Changelogs](https://github.com/Genocs/blazor-wasm-template/blob/main/CHANGELOG.md).

## License

This project is licensed with the [MIT license](LICENSE).


## Community

- Discord [@genocs](https://discord.com/invite/fWwArnkV)
- Facebook Page [@genocs](https://facebook.com/Genocs)
- Youtube Channel [@genocs](https://youtube.com/c/genocs)

## Support

Has this Project helped you learn something New? or Helped you at work?
Here are a few ways by which you can support.

- ⭐ Leave a star!
- 🥇 Recommend this project to your colleagues.
- 🦸 Do consider endorsing me on LinkedIn for ASP.NET Core - [Connect via LinkedIn](https://www.linkedin.com/in/giovanni-emanuele-nocco-b31a5169/)
- ☕ If you want to support this project in the long run, [consider buying me a coffee](https://www.buymeacoffee.com/genocs)!


[![buy-me-a-coffee](https://raw.githubusercontent.com/Genocs/blazor-wasm-template/main/assets/buy-me-a-coffee.png "buy me a coffee")](https://www.buymeacoffee.com/genocs)

## Code Contributors

This project exists thanks to all the people who contribute. [Submit your PR and join the team!](CONTRIBUTING.md)

[![genocs contributors](https://contrib.rocks/image?repo=Genocs/blazor-wasm-template "genocs contributors")](https://github.com/genocs/blazor-wasm-template/graphs/contributors)

## Financial Contributors

Become a financial contributor and help me sustain the project.

**Support the Project** on [Opencollective](https://opencollective.com/genocs)

## Acknowledgements

- [Mukesh Murugan](https://github.com/iammukeshm)
- [FullStackHero](https://fullstackhero.net)
