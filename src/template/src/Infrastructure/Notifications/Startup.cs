using Genocs.BlazorWasm.Template.Shared.Notifications;
using MediatR;
using MediatR.Courier;
using Microsoft.Extensions.DependencyInjection;

namespace Genocs.BlazorWasm.Template.Infrastructure.Notifications;

internal static class Startup
{
    public static IServiceCollection AddNotifications(this IServiceCollection services)
    {
        // Add mediator processing of notifications
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();

        services
            .AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()))
            .AddCourier(assemblies)
            .AddTransient<INotificationPublisher, NotificationPublisher>();

        // Register handlers for all INotificationMessages
        foreach (var eventType in assemblies
            .SelectMany(a => a.GetTypes())
            .Where(t => t.GetInterfaces().Any(i => i == typeof(INotificationMessage))))
        {
            services.AddSingleton(
                typeof(INotificationHandler<>).MakeGenericType(
                    typeof(NotificationWrapper<>).MakeGenericType(eventType)),
                serviceProvider => serviceProvider.GetRequiredService(typeof(MediatRCourier)));
        }

        return services;
    }
}