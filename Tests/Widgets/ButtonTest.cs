using System.Windows;
using CsTkinter.Utility;
using CsTkinter.Widgets;

namespace CsTkinter.Tests.Widgets;

public sealed class ButtonTest : BaseTest
{
    public ButtonTest() : base("Button")
    {
    }

    public override void InitTest()
    {
        CtButton btn = new CtButton(app);
        btn.Width = 300;
        btn.Height = 100;
        btn.Text = "Test Button";

        btn.HoverFgColor = BrushConverter.FromColor(155, 0, 0);
        btn.HoverBgColor = BrushConverter.FromColor(0, 155, 0);
        btn.HoverBorderColor = BrushConverter.FromColor(0, 0, 155);

        btn.ClickFgColor = BrushConverter.FromColor(55, 0, 0);
        btn.ClickBgColor = BrushConverter.FromColor(0, 55, 0);
        btn.ClickBorderColor = BrushConverter.FromColor(0, 0, 255);

        btn.FgColor = BrushConverter.FromColor(255, 0, 0);
        btn.BgColor = BrushConverter.FromColor(0, 255, 0);
        btn.BorderColor = BrushConverter.FromColor(0, 0, 255);

        btn.Font = new Utility.DataTypes.FontType(new System.Windows.Media.FontFamily("Comic sans"), 24, FontStyles.Italic, FontWeights.UltraBold, FontStretches.Medium);
        btn.BorderWidth = new(1, 1, 3, 5);
        btn.OnClick = () => System.Console.WriteLine("Click");
        btn.PlaceRelativ(50, 50);
    }
}

