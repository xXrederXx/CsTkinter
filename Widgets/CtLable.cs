using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CsTkinter.Utility;
using CsTkinter.Utility.DataTypes;
using CsTkinter.Windows;

namespace CsTkinter.Widgets;

public class CtLable : Widget
{
    private readonly Label self;
    private readonly Border border;
    
    public CtLable(IWindow master, double width = 100, double height = 24, string text = "CtLable") : base(master)
    {
        self = new Label()
        {
            Width = width, Height = height, Content = text
        };

        border = new Border();
        border.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        border.BorderThickness = new(1);
        border.CornerRadius = new(10);

        border.Child = self;
    }

    public double Width
    {
        get => self.Width;
        set => self.Width = value;
    }

    public double Height
    {
        get => self.Height;
        set => self.Height = value;
    }

    public string Text
    {
        get => (string)self.Content;
        set => self.Content = value;
    }

    public CornerRadius CornerRadius
    {
        get => border.CornerRadius;
        set => border.CornerRadius = value;
    }

    public Brush FgColor
    {
        get => self.Foreground;
        set => self.Foreground = value;
    }

    public Brush BgColor
    {
        get => self.Background;
        set => self.Background = value;
    }
    public FontType Font
    {
        get => new FontType(self.FontFamily, self.FontSize, self.FontStyle, self.FontWeight, self.FontStretch);
        set
        {
            self.FontFamily = value.fontFamily;
            self.FontSize = value.fontSize;
            self.FontStyle = value.fontStyle;
            self.FontWeight = value.fontWeight;
            self.FontStretch = value.fontStretch;
        }
    }
    public Brush BorderColor
    {
        get => border.BorderBrush;
        set => border.BorderBrush = value;
    }

    protected override UIElement GetUIElement()
    {
        return border;
    }
}
