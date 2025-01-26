using System.Windows.Media;
using CsTkinter.Utility.DataTypes;
using CsTkinter.Widgets;
using CsTkinter.Windows;

namespace CsTkinter.Utility.StyleSheet;

public sealed class StyleSheetDark : IStyleSheet
{
    public string Name { get; }
    

    public Brush PrimaryColor { get; }
    public Brush MainTextColor { get; }
    public FontType MainFontType { get; }

    public CtWindow windowStyle { get; }
    public CtLabel labelStyle { get; }
    public CtButton buttonStyle { get; }
    public CtInputField inputFieldStyle { get; }

    public StyleSheetDark()
    {
        CtWindow placeholder = new();

        Name = "Dark";
        PrimaryColor = BrushConverter.FromColor(10, 10, 15);
        MainTextColor = BrushConverter.FromColor(230, 230, 255);
        MainFontType = new (new("Arial"), 11);

        windowStyle = new CtWindow(
            "CsTkinter App",
            new(600, 500),
            new(10, 10),
            new(2147483640, 2147483640),
            true,
            System.Windows.WindowState.Normal,
            BrushConverter.Colors.Black
        );

        labelStyle = new CtLabel(
            placeholder,
            120,
            24,
            "CtLabel",
            new(4),
            MainTextColor,
            PrimaryColor,
            BrushConverter.Colors.Transparent,
            new(0),
            Alignment.center
        );

        buttonStyle = new CtButton(
            placeholder,
            120,
            24,
            "CtButton",
            MainTextColor,
            PrimaryColor,
            BrushConverter.Colors.Transparent,
            MainTextColor,
            BrushConverter.FromColor(20, 20, 24),
            BrushConverter.Colors.Transparent,
            MainTextColor,
            BrushConverter.FromColor(30, 30, 34),
            BrushConverter.Colors.Transparent,
            MainFontType,
            new(0),
            Alignment.center
        );
        
        inputFieldStyle = new CtInputField(
            placeholder,
            120,
            24,
            "CtInput",
            MainTextColor,
            PrimaryColor,
            BrushConverter.Colors.Black,
            new(1),
            Alignment.center,
            MainFontType,
            false,
            false
        );
    }
}
