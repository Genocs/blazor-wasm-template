using MediatR;
using Shared.Notifications;

namespace Genocs.Template.Client.Infrastructure.Notifications;

public class NotificationWrapper<TNotificationMessage> : INotification
    where TNotificationMessage : INotificationMessage
{
    public NotificationWrapper(TNotificationMessage notification) => Notification = notification;

    public TNotificationMessage Notification { get; }
}