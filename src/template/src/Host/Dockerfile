#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /src
COPY ["src/Host", "Host/"]
COPY ["src/Shared", "Shared/"]
COPY ["src/Client", "Client/"]
COPY ["src/Infrastructure", "Infrastructure/"]

COPY ["Directory.Build.props", "Directory.Build.props"]
COPY ["Directory.Build.targets", "Directory.Build.targets"]
COPY ["dotnet.ruleset", "dotnet.ruleset"]
COPY ["global.json", "global.json"]
COPY ["stylecop.json", "stylecop.json"]

WORKDIR "/src/Host"

RUN dotnet restore "Host.csproj"

RUN dotnet build "Host.csproj" -c Debug -o /app/build

FROM build-env AS publish
RUN dotnet publish "Host.csproj" -c Debug -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Explicitly expose the default HTTP port for .NET 9 containers
EXPOSE 8080
ENV ASPNETCORE_HTTP_PORTS=8080

ENTRYPOINT ["dotnet", "Genocs.BlazorWasm.Template.Host.dll"]