FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Host/Host.csproj", "Host/"]
COPY ["src/Shared/Shared.csproj", "Shared/"]
COPY ["src/Client/Client.csproj", "Client/"]
COPY ["src/Client.Infrastructure/Client.Infrastructure.csproj", "Client.Infrastructure/"]

RUN dotnet restore "Host/Host.csproj"
COPY . .
WORKDIR /src/Host

RUN dotnet build "Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Host.csproj" -c Release -o /app/publish /p:UseAppHost=false


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Host.dll"]