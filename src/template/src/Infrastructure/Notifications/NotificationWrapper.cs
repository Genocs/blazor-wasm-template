using Genocs.BlazorWasm.Template.Shared.Notifications;
using MediatR;

namespace Genocs.BlazorWasm.Template.Infrastructure.Notifications;

public class NotificationWrapper<TNotificationMessage> : INotification
    where TNotificationMessage : INotificationMessage
{
    public NotificationWrapper(TNotificationMessage notification) => Notification = notification;

    public TNotificationMessage Notification { get; }
}