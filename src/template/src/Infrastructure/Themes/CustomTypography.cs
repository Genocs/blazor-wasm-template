using MudBlazor;

namespace Genocs.BlazorWasm.Template.Infrastructure.Themes;

public static class CustomTypography
{

    private static readonly string[] NunitoFontFamily = ["Nunito", "Helvetica", "Arial", "sans-serif"];
    public static Typography GNXTypography => new()
    {
        Default = new DefaultTypography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = ".875rem",
            FontWeight = "400",
            LineHeight = "1.43",
            LetterSpacing = ".01071em"
        },
        H1 = new H1Typography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = "6rem",
            FontWeight = "800",
            LineHeight = "1.167",
            LetterSpacing = "-.01562em"
        },
        H2 = new H2Typography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = "3.75rem",
            FontWeight = "800",
            LineHeight = "1.2",
            LetterSpacing = "-.00833em"
        },
        H3 = new H3Typography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = "3rem",
            FontWeight = "800",
            LineHeight = "1.167",
            LetterSpacing = "0"
        },
        H4 = new H4Typography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = "2.125rem",
            FontWeight = "800",
            LineHeight = "1.235",
            LetterSpacing = ".00735em"
        },
        H5 = new H5Typography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = "1.5rem",
            FontWeight = "800",
            LineHeight = "1.334",
            LetterSpacing = "0"
        },
        H6 = new H6Typography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = "1.25rem",
            FontWeight = "800",
            LineHeight = "1.6",
            LetterSpacing = ".0075em"
        },
        Button = new ButtonTypography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = ".875rem",
            FontWeight = "500",
            LineHeight = "1.75",
            LetterSpacing = ".02857em"
        },
        Body1 = new Body1Typography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = "1rem",
            FontWeight = "600",
            LineHeight = "1.5",
            LetterSpacing = ".00938em"
        },
        Body2 = new Body2Typography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = ".875rem",
            FontWeight = "600",
            LineHeight = "1.43",
            LetterSpacing = ".01071em"
        },
        Caption = new CaptionTypography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = ".75rem",
            FontWeight = "600",
            LineHeight = "1.66",
            LetterSpacing = ".03333em"
        },
        Subtitle1 = new Subtitle1Typography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = "1rem",
            FontWeight = "400",
            LineHeight = "1.57",
            LetterSpacing = ".00714em"
        },
        Subtitle2 = new Subtitle2Typography()
        {
            FontFamily = NunitoFontFamily,
            FontSize = ".875rem",
            FontWeight = "500",
            LineHeight = "1.57",
            LetterSpacing = ".00714em"
        }
    };
}