using Genocs.BlazorWasm.Template.Shared.Notifications;

namespace Genocs.BlazorWasm.Template.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}