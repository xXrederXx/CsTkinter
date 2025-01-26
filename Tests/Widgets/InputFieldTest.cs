using System.Windows;
using CsTkinter.Utility;
using CsTkinter.Widgets;

namespace CsTkinter.Tests.Widgets;

public sealed class InputFieldTest : BaseTest
{
    public InputFieldTest() : base("Input")
    {
    }

    public override void InitTest()
    {
        CtInputField inp = new CtInputField(app);
        inp.Width = 300;
        inp.Height = 100;
        inp.Text = "Test Button";
        inp.FgColor = BrushConverter.FromColor(255, 0, 0);
        inp.BgColor = BrushConverter.FromColor(0, 255, 0);
        inp.BorderColor = BrushConverter.FromColor(0, 0, 255);
        inp.BorderWidth = new(1, 1, 3, 5);
        inp.Font = new Utility.DataTypes.FontType(new System.Windows.Media.FontFamily("Comic sans"), 24, FontStyles.Italic, FontWeights.UltraBold, FontStretches.Medium);
        inp.JustifyText = new(HorizontalAlignment.Left, VerticalAlignment.Center);
        inp.MultibleLineText = true;
        inp.WrapText = true;
        
        inp.PlaceRelativ(10, 50);
    }
}

