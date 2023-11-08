using Genocs.BlazorWasm.Template.Client.Infrastructure.Auth;
using Genocs.BlazorWasm.Template.Client.Infrastructure.Common;
using Genocs.BlazorWasm.Template.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Genocs.BlazorWasm.Template.Client.Shared;

public partial class NavMenu
{
    [CascadingParameter]
    protected Task<AuthenticationState> AuthState { get; set; } = default!;
    [Inject]
    protected IAuthorizationService AuthService { get; set; } = default!;

    private string? _hangfireUrl;
    private bool _canViewHangfire;
    private bool _canViewDashboard;
    private bool _canViewRoles;
    private bool _canViewUsers;
    private bool _canViewProducts;
    private bool _canViewBrands;
    private bool _canViewTenants;
    private bool CanViewAdministrationGroup => _canViewUsers || _canViewRoles || _canViewTenants;

    protected override async Task OnParametersSetAsync()
    {
        _hangfireUrl = Config[ConfigNames.ApiBaseUrl] + "jobs";
        var user = (await AuthState).User;
        _canViewHangfire = await AuthService.HasPermissionAsync(user, GNXAction.View, GNXResource.Hangfire);
        _canViewDashboard = await AuthService.HasPermissionAsync(user, GNXAction.View, GNXResource.Dashboard);
        _canViewRoles = await AuthService.HasPermissionAsync(user, GNXAction.View, GNXResource.Roles);
        _canViewUsers = await AuthService.HasPermissionAsync(user, GNXAction.View, GNXResource.Users);
        _canViewProducts = await AuthService.HasPermissionAsync(user, GNXAction.View, GNXResource.Products);
        _canViewBrands = await AuthService.HasPermissionAsync(user, GNXAction.View, GNXResource.Brands);
        _canViewTenants = await AuthService.HasPermissionAsync(user, GNXAction.View, GNXResource.Tenants);
    }
}