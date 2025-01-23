using System.Windows;
using CsTkinter.Utility;
using CsTkinter.Widgets;

namespace CsTkinter.Tests.Widgets;

public sealed class LableTest : BaseTest
{
    public LableTest() : base("Label")
    {
    }

    public override void InitTest()
    {
        CtLable lable = new CtLable(app);
        lable.Width = 300;
        lable.Height = 100;
        lable.Text = "Test Label";
        lable.CornerRadius = new(12);
        lable.FgColor = BrushConverter.FromColor(255, 0, 0);
        lable.BgColor = BrushConverter.FromColor(0, 255, 0);
        lable.Font = new Utility.DataTypes.FontType(new System.Windows.Media.FontFamily("Comic sans"), 24, FontStyles.Italic, FontWeights.UltraBold, FontStretches.Medium);
        lable.BorderColor = BrushConverter.FromColor(0, 0, 255);
        lable.Place(100, 100);
    }
}
