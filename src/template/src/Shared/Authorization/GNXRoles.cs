using System.Collections.ObjectModel;

namespace Genocs.BlazorWasm.Template.Shared.Authorization;

public static class GNXRoles
{
    public static string Admin = nameof(Admin);
    public static string Basic = nameof(Basic);

    public static IReadOnlyList<string> DefaultRoles { get; } = new ReadOnlyCollection<string>(new[]
    {
        Admin,
        Basic
    });

    public static bool IsDefault(string roleName)
        => DefaultRoles.Any(r => r == roleName);
}