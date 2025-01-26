using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CsTkinter.Utility;
using CsTkinter.Utility.DataTypes;
using CsTkinter.Windows;

namespace CsTkinter.Widgets;

public class CtLabel : Widget
{
    private readonly Label self;
    private readonly Border border;
    
    public CtLabel(
        IWindow master,
        double width = 100,
        double height = 24,
        string text = "CtLabel",
        CornerRadius? cornerRadius = null,
        Brush? fgColor = null,
        Brush? bgColor = null,
        Brush? borderColor = null,
        Thickness? borderWidth = null,
        Alignment? justifyText = null
    ) : base(master)
    {
        self = new Label();
        border = new Border();
        border.Child = self;

        Width = width;
        Height = height;
        Text = text;
        if(cornerRadius is not null)
            CornerRadius = (CornerRadius)cornerRadius;
        FgColor = fgColor ?? Utility.BrushConverter.FromColor(0, 0, 0);
        BgColor = bgColor ?? Utility.BrushConverter.FromColor(255, 255, 255);
        BorderColor = borderColor ?? Utility.BrushConverter.FromColor(0, 0, 0, 0);
        if(borderWidth is not null)
            BorderWidth = (Thickness)borderWidth;
        if(justifyText is not null)
            JustifyText = (Alignment)justifyText;
    }

    public override double Width
    {
        get => self.Width;
        set => self.Width = value;
    }
    public override double Height
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
    public Thickness BorderWidth
    {
        get => border.BorderThickness;
        set => border.BorderThickness = value;
    }
    public Alignment JustifyText
    {
        get => new Alignment(self.HorizontalContentAlignment, self.VerticalContentAlignment);
        set
        {
            self.HorizontalAlignment = value.horizontal;
            self.VerticalAlignment = value.vertical;
        }
    }

    protected override UIElement GetUIElement()
    {
        return border;
    }
}
