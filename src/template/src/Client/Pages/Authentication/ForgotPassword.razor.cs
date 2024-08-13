using Genocs.BlazorWasm.Template.Client.Components.Common;
using Genocs.BlazorWasm.Template.Infrastructure.ApiClient;
using Genocs.BlazorWasm.Template.Client.Shared;
using Genocs.BlazorWasm.Template.Shared.MultiTenancy;
using Microsoft.AspNetCore.Components;

namespace Genocs.BlazorWasm.Template.Client.Pages.Authentication;

public partial class ForgotPassword
{
    private readonly ForgotPasswordRequest _forgotPasswordRequest = new();
    private CustomValidation? _customValidation;
    private bool BusySubmitting { get; set; }

    [Inject]
    private IUsersClient UsersClient { get; set; } = default!;

    private string Tenant { get; set; } = MultitenancyConstants.Root.Id;

    private async Task SubmitAsync()
    {
        BusySubmitting = true;

        await ApiHelper.ExecuteCallGuardedAsync(
            () => UsersClient.ForgotPasswordAsync(Tenant, _forgotPasswordRequest),
            Snackbar,
            _customValidation);

        BusySubmitting = false;
    }
}