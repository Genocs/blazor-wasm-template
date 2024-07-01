using Genocs.BlazorWasm.Template.Client.Infrastructure.Preferences;
using Genocs.BlazorWasm.Template.Client.Infrastructure.Themes;
using Microsoft.AspNetCore.Components;

namespace Genocs.BlazorWasm.Template.Client.Components.ThemeManager;

public partial class ThemeDrawer
{
    [Parameter]
    public bool ThemeDrawerOpen { get; set; }

    [Parameter]
    public EventCallback<bool> ThemeDrawerOpenChanged { get; set; }

    [EditorRequired]
    [Parameter]
    public ClientPreference ThemePreference { get; set; } = default!;

    [EditorRequired]
    [Parameter]
    public EventCallback<ClientPreference> ThemePreferenceChanged { get; set; }

    private readonly List<string> _colors = CustomColors.ThemeColors;

    private async Task UpdateThemePrimaryColorAsync(string color)
    {
        if (ThemePreference is not null)
        {
            ThemePreference.PrimaryColor = color;
            await ThemePreferenceChanged.InvokeAsync(ThemePreference);
        }
    }

    private async Task UpdateThemeSecondaryColorAsync(string color)
    {
        if (ThemePreference is not null)
        {
            ThemePreference.SecondaryColor = color;
            await ThemePreferenceChanged.InvokeAsync(ThemePreference);
        }
    }

    private async Task UpdateBorderRadiusAsync(double radius)
    {
        if (ThemePreference is not null)
        {
            ThemePreference.BorderRadius = radius;
            await ThemePreferenceChanged.InvokeAsync(ThemePreference);
        }
    }

    private async Task ToggleDarkLightModeAsync(bool isDarkMode)
    {
        if (ThemePreference is not null)
        {
            ThemePreference.IsDarkMode = isDarkMode;
            await ThemePreferenceChanged.InvokeAsync(ThemePreference);
        }
    }

    private async Task ToggleEntityTableDenseAsync(bool isDense)
    {
        if (ThemePreference is not null)
        {
            ThemePreference.TablePreference.IsDense = isDense;
            await ThemePreferenceChanged.InvokeAsync(ThemePreference);
        }
    }

    private async Task ToggleEntityTableStripedAsync(bool isStriped)
    {
        if (ThemePreference is not null)
        {
            ThemePreference.TablePreference.IsStriped = isStriped;
            await ThemePreferenceChanged.InvokeAsync(ThemePreference);
        }
    }

    private async Task ToggleEntityTableBorderAsync(bool hasBorder)
    {
        if (ThemePreference is not null)
        {
            ThemePreference.TablePreference.HasBorder = hasBorder;
            await ThemePreferenceChanged.InvokeAsync(ThemePreference);
        }
    }

    private async Task ToggleEntityTableHoverableAsync(bool isHoverable)
    {
        if (ThemePreference is not null)
        {
            ThemePreference.TablePreference.IsHoverable = isHoverable;
            await ThemePreferenceChanged.InvokeAsync(ThemePreference);
        }
    }
}