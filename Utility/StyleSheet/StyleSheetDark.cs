using System.Windows.Media;
using CsTkinter.Utility.DataTypes;
using CsTkinter.Widgets;

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
    public CtFrame frameStyle { get; }

    public StyleSheetDark()
    {
        this.windowStyle = new CtWindow(
            "CsTkinter App",
            new(600, 500),
            new(10, 10),
            new(214748360, 214748360),
            true,
            System.Windows.WindowState.Normal,
            BrushConverter.Colors.Black
        );

        Name = "Dark";
        PrimaryColor = BrushConverter.FromColor(33, 112, 174);
        MainTextColor = BrushConverter.FromColor(240, 240, 255);
        MainFontType = new(new("Arial"), 11);

        labelStyle = new CtLabel(
            windowStyle,
            120,
            24,
            "CtLabel",
            new(0),
            MainTextColor,
            BrushConverter.Colors.Transparent,
            BrushConverter.Colors.Transparent,
            new(0),
            Alignment.center,
            MainFontType
        );

        buttonStyle = new CtButton(
            windowStyle,
            120,
            24,
            "CtButton",
            MainTextColor,
            PrimaryColor,
            PrimaryColor,
            MainTextColor,
            BrushConverter.FromColor(20, 20, 24),
            PrimaryColor,
            MainTextColor,
            BrushConverter.FromColor(30, 30, 34),
            PrimaryColor,
            MainFontType,
            new(2),
            Alignment.center,
            new(2)
        );

        inputFieldStyle = new CtInputField(
            windowStyle,
            120,
            24,
            "CtInput",
            MainTextColor,
            BrushConverter.FromColor(57, 58, 60),
            BrushConverter.FromColor(89, 93, 94),
            new(2),
            new(2),
            new(System.Windows.HorizontalAlignment.Left, System.Windows.VerticalAlignment.Center),
            MainFontType,
            false,
            false
        );

        frameStyle = new CtFrame(
            windowStyle,
            100,
            100,
            new(2),
            PrimaryColor,
            PrimaryColor,
            new(2)
        );
    }
}
