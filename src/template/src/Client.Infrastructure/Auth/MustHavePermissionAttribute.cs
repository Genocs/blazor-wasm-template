using Genocs.WebApi.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace Genocs.Template.Client.Infrastructure.Auth;

public class MustHavePermissionAttribute : AuthorizeAttribute
{
    public MustHavePermissionAttribute(string action, string resource)
        => Policy = GNXPermission.NameFor(action, resource);
}