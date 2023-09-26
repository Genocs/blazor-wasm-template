using Genocs.WebApi.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace Genocs.Template.Client.Infrastructure.Auth;

public static class AuthorizationServiceExtensions
{
    public static async Task<bool> HasPermissionAsync(this IAuthorizationService service, ClaimsPrincipal user, string action, string resource)
        => (await service.AuthorizeAsync(user, null, GNXPermission.NameFor(action, resource))).Succeeded;
}