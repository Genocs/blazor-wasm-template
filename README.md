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
[package-shield]: https://img.shields.io/badge/nuget-v.3.0.0-blue?&label=latests&logo=nuget
[package-url]: https://github.com/Genocs/blazor-wasm-template/actions/workflows/build_and_test.yml
[downloads-shield]: https://img.shields.io/nuget/dt/Genocs.BlazorWasm.Template.svg?color=2da44e&label=downloads&logo=nuget
[downloads-url]: https://www.nuget.org/packages/Genocs.BlazorWasm.Template
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
    <img src="https://raw.githubusercontent.com/Genocs/blazor-wasm-template/main/assets/genocs-library-logo.png" alt="Blazor Wasm Template">
  </a>
  <h3 align="center">Blazor WebAssembly Template</h3>
  <p align="center">
    Open Source Solution Template for <a href="https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor">Blazor</a> <a href="https://webassembly.org/">WebAssembly</a> 3.0 built with <a href="https://mudblazor.com/">MudBlazor v8.0.0</a> Components
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

# Genocs .NET Blazor WebAssembly Template
The template can be used with the `genocs cli`, `dotnet new` command or with the `Visual Studio 2022`, `Visual Studio Code` IDEs.
Built with .NET9 and MudBlazor Component Library. Incorporates the most essential packages your projects will ever need. Follows Clean Architecture Principles.
## ✨ Features

## 📋 Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Quick Start](#quick-start)
- [Template Options](#template-options)
- [Architecture Overview](#architecture-overview)
- [Development Workflow](#development-workflow)
- [Examples](#examples)
- [Troubleshooting](#troubleshooting)
- [Community & Support](#community--support)
- [Contributing](#contributing)
- [License](#license)

## 📋 Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) (latest version)
- **IDE** (choose one):
  - [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (recommended)
  - [Visual Studio Code](https://code.visualstudio.com/) with C# extension
  - [JetBrains Rider](https://www.jetbrains.com/rider/)
- **Optional for development**:
  - [Docker Desktop](https://www.docker.com/products/docker-desktop) for containerization
  - MongoDB, SQL Server

## 🚀 Quick Start

### Install the Template

```bash
# Install the latest version
dotnet new install Genocs.BlazorWasm.Template

# Or install a specific version
dotnet new install Genocs.BlazorWasm.Template::3.0.0

# View all available options
dotnet new gnx-blazorwasm --help

# Example with custom options
dotnet new gnx-blazorwasm \
  --name "CompanyName.ServiceName" \
```

## 🏗️ Architecture Overview

The template generates a solution with the following structure:

```pl
src/
├── Client/ # Acceptance Tests
├── Host/ # Use cases and application services
├── Infrastructure/ # Data access and external services
└── Shared/ # API contracts and events
```


> Note that this is a frontend/client application only! 
>
> The backend for this application is available in a seperate repository. 
> - Find Genocs's .NET Web API template here - [microservice-template](https://github.com/Genocs/microservice-template)

## Getting Started

Open up your Command Prompt / Powershell and run the following command to install the solution template.

```bash
dotnet new --install Genocs.BlazorWasm.Template
```

or, if you want to use a specific version of the template, use

```bash
dotnet new --install Genocs.BlazorWasm.Template::3.0.0
```

This would install the `Genocs Blazor WebAssembly Template` globally on your machine.

Do note that, at the time of writing this documentation, the latest available version is **3.0.0** which is also one of the first stable release version of the package. It is highly likely that there is already a newer version available when you are reading this.

> *To get the latest version of the package, visit [nuget.org](https://www.nuget.org/packages/Genocs.BlazorWasm.Template/)*
>

**Genocs.BlazorWasm.Template::3.0.0 is compatible only with Genocs.Microservice.Template::3.0.0 and above.**

Get the .NET WebApi Microservice Template by running the following command

```
dotnet new --install Genocs.Microservice.Template::3.0.0
```

For more details on getting started, [read the documentation](https://genocs-blog.netlify.app/blazor-wasm-template/general/overview/)


## Links & Documentations

[Overview](https://https://genocs-blog.netlify.app/blazor-wasm-template/general/overview/)

[Getting Started](https://https://genocs-blog.netlify.app/blazor-wasm-template/general/getting-started/)

[Development Environment](https://https://genocs-blog.netlify.app/blazor-wasm-template/general/development-environment/)

[Participate in QNA & General Discussions](https://github.com/Genocs/blazor-wasm-template/discussions)

## How to build and install the template locally

To build the package run the following commands:

[custom-templates](https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates)

[dotnet-templating](https://github.com/dotnet/templating)

```bash
# To clone the repository
git clone https://github.com/Genocs/blazor-wasm-template
cd blazor-wasm-template

# To pack and install the template
dotnet pack ./src/Package.Template.csproj -p:PackageVersion=3.0.0 --configuration Release --output ./out

dotnet new install ./out/Genocs.BlazorWasm.Template.3.0.0.nupkg
dotnet new gnx-blazorwasm --help

# To uninstall the template
dotnet new uninstall Genocs.BlazorWasm.Template

# Example of creating a new project with full functionality
dotnet new gnx-blazorwasm --name {CompanyName.ServiceName}
```

### Miscellaneous

Useful commands:

```bash
# How to get the list of installed templates
dotnet new -u

# How to get the list of templates
dotnet new list
```

## 💬 Community & Support

### Get Help

- 💬 [Discord Community](https://discord.com/invite/fWwArnkV)
- 📖 [Documentation](https://genocs-blog.netlify.app/library/)
- 🐛 [Report Issues](https://github.com/Genocs/clean-architecture-template/issues)

### Stay Connected

- 🐦 [Twitter @genocs](https://twitter.com/genocs)
- 📺 [YouTube Channel](https://youtube.com/c/genocs)
- 💼 [LinkedIn](https://www.linkedin.com/in/giovanni-emanuele-nocco-b31a5169/)

### Show Your Support

- ⭐ Star this repository
- 🔄 Share with your team
- ☕ [Buy me a coffee](https://www.buymeacoffee.com/genocs)

## 🔧 Troubleshooting

### Common Issues

For more details on getting started, [read the documentation](https://genocs-blog.netlify.app/library/)

Please check the [documentation](https://learn.microsoft.com/en-us/visualstudio/ide/how-to-locate-and-organize-project-and-item-templates?view=vs-2022) for more details.

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
- ☕ If you want to support this project in the long run, consider [buying me a coffee](https://www.buymeacoffee.com/genocs)!


[![buy-me-a-coffee](https://raw.githubusercontent.com/Genocs/microservice-template/main/assets/buy-me-a-coffee.png "buy me a coffee")](https://www.buymeacoffee.com/genocs)

## Code Contributors

This project exists thanks to all the people who contribute. [Submit your PR and join the team!](CONTRIBUTING.md)

[![genocs contributors](https://contrib.rocks/image?repo=Genocs/microservice-template "genocs contributors")](https://github.com/Genocs/microservice-template/graphs/contributors)

## Financial Contributors

Become a financial contributor and help me sustain the project.

**Support the Project** on [Opencollective](https://opencollective.com/genocs)

## Acknowledgements

- [Mukesh Murugan](https://github.com/iammukeshm)
- [FullStackHero](https://fullstackhero.net)
