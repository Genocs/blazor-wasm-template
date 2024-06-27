using Genocs.BlazorWasm.Template.Client.Infrastructure.ApiClient;
using Genocs.BlazorWasm.Template.Client.Infrastructure.Auth;
using Genocs.BlazorWasm.Template.Client.Infrastructure.Notifications;
using Genocs.BlazorWasm.Template.Client.Infrastructure.Preferences;
using Genocs.BlazorWasm.Template.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;
using MudBlazor.Services;
using System.Globalization;

namespace Genocs.BlazorWasm.Template.Client.Infrastructure;

public static class Startup
{
    private const string ClientName = "Microservice.API";

    public static IServiceCollection AddClientServices(this IServiceCollection services, IConfiguration config) =>
        services
            .AddLocalization(options => options.ResourcesPath = "Resources")
            .AddBlazoredLocalStorage()
            .AddMudServices(configuration =>
                {
                    configuration.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
                    configuration.SnackbarConfiguration.HideTransitionDuration = 500;
                    configuration.SnackbarConfiguration.ShowTransitionDuration = 250;
                    configuration.SnackbarConfiguration.VisibleStateDuration = 3000;
                    configuration.SnackbarConfiguration.ShowCloseIcon = true;
                })
            .AddScoped<IClientPreferenceManager, ClientPreferenceManager>()
            .AutoRegisterInterfaces<IAppService>()
            .AutoRegisterInterfaces<IApiService>()
            .AddNotifications()
            .AddAuthentication(config)
            .AddAuthorizationCore(RegisterPermissionClaims)

            // Add Api Http Client.
            .AddHttpClient(ClientName, client =>
                {
                    client.DefaultRequestHeaders.AcceptLanguage.Clear();
                    client.DefaultRequestHeaders.AcceptLanguage.ParseAdd(CultureInfo.DefaultThreadCurrentCulture?.TwoLetterISOLanguageName);
                    client.BaseAddress = new Uri(config[ConfigNames.ApiBaseUrl]);
                })
                .AddAuthenticationHandler(config)
                .Services
            .AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient(ClientName));

    public static IServiceCollection AutoRegisterInterfaces<T>(this IServiceCollection services)
    {
        var @interface = typeof(T);

        var types = @interface
            .Assembly
            .GetExportedTypes()
            .Where(t => t.IsClass && !t.IsAbstract)
            .Select(t => new
            {
                Service = t.GetInterface($"I{t.Name}"),
                Implementation = t
            })
            .Where(t => t.Service != null);

        foreach (var type in types)
        {
            if (@interface.IsAssignableFrom(type.Service))
            {
                services.AddTransient(type.Service, type.Implementation);
            }
        }

        return services;
    }

    private static void RegisterPermissionClaims(AuthorizationOptions options)
    {
        foreach (var permission in GNXPermissions.All)
        {
            options.AddPolicy(permission.Name, policy => policy.RequireClaim(GNXClaims.Permission, permission.Name));
        }
    }
}