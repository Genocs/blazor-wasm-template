using Genocs.BlazorWasm.Template.Shared.Notifications;

namespace Genocs.BlazorWasm.Template.Client.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;