using Genocs.BlazorWasm.Template.Shared.Notifications;

namespace Genocs.BlazorWasm.Template.Infrastructure.Preferences;

public class GnxTablePreference : INotificationMessage
{
    public bool IsDense { get; set; }
    public bool IsStriped { get; set; }
    public bool HasBorder { get; set; }
    public bool IsHoverable { get; set; }
}