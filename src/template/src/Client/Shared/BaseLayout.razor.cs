using Genocs.BlazorWasm.Template.Infrastructure.Preferences;
using Genocs.BlazorWasm.Template.Infrastructure.Themes;
using MudBlazor;

namespace Genocs.BlazorWasm.Template.Client.Shared;

public partial class BaseLayout
{
    private ClientPreference? _themePreference;
    private MudTheme _currentTheme = new LightTheme();
    private bool _themeDrawerOpen;
    private bool _rightToLeft;

    protected override async Task OnInitializedAsync()
    {
        _themePreference = await ClientPreferences.GetPreference() as ClientPreference;
        if (_themePreference == null) _themePreference = new ClientPreference();
        SetCurrentTheme(_themePreference);

        Snackbar.Add("Like this template? ", Severity.Normal, config =>
        {
            config.BackgroundBlurred = true;
            config.Icon = Icons.Custom.Brands.GitHub;
            config.Action = "Star us on GitHub!";
            config.ActionColor = Color.Primary;
            config.Onclick = snackbar =>
            {
                Navigation.NavigateTo("https://github.com/Genocs/blazor-template");
                return Task.CompletedTask;
            };
        });
    }

    private async Task ThemePreferenceChanged(ClientPreference themePreference)
    {
        SetCurrentTheme(themePreference);
        await ClientPreferences.SetPreference(themePreference);
    }

    private void SetCurrentTheme(ClientPreference themePreference)
    {
        _currentTheme = themePreference.IsDarkMode ? new DarkTheme() : new LightTheme();
        //_currentTheme.PaletteLight.Primary = themePreference.PrimaryColor;
        //_currentTheme.PaletteLight.Secondary = themePreference.SecondaryColor;
        _currentTheme.LayoutProperties.DefaultBorderRadius = $"{themePreference.BorderRadius}px";
        _currentTheme.LayoutProperties.DefaultBorderRadius = $"{themePreference.BorderRadius}px";
        _rightToLeft = themePreference.IsRTL;
    }
}