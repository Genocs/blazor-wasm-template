using Genocs.BlazorWasm.Template.Shared.Notifications;

namespace Genocs.BlazorWasm.Template.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;