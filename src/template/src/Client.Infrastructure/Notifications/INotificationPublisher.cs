using Genocs.BlazorWasm.Template.Shared.Notifications;

namespace Genocs.BlazorWasm.Template.Client.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}