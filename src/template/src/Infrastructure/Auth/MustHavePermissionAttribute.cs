using Genocs.BlazorWasm.Template.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace Genocs.BlazorWasm.Template.Infrastructure.Auth;

public class MustHavePermissionAttribute : AuthorizeAttribute
{
    public MustHavePermissionAttribute(string action, string resource)
        => Policy = GNXPermission.NameFor(action, resource);
}