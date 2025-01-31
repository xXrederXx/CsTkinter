using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CsTkinter.Utility.DataTypes;
using CsTkinter.Utility.StyleSheet;
using CsTkinter.Utility.Interfaces;

namespace CsTkinter.Widgets;

public class CtLabel : Widget
{
    private readonly Label self;
    private readonly Border border;
    
    public CtLabel(
        IPlacableInTo master,
        double? width = null,
        double? height = null,
        string? text = null,
        CornerRadius? cornerRadius = null,
        Brush? fgColor = null,
        Brush? bgColor = null,
        Brush? borderColor = null,
        Thickness? borderWidth = null,
        Alignment? justifyText = null,
        FontType? font = null
    ) : base(master)
    {
        self = new Label();
        border = new Border();
        border.Child = self;

        Width = width ?? StyleSheetManager.current.labelStyle.Width;
        Height = height ?? StyleSheetManager.current.labelStyle.Height;
        Text = text ?? StyleSheetManager.current.labelStyle.Text;
        CornerRadius = cornerRadius ?? StyleSheetManager.current.labelStyle.CornerRadius;
        FgColor = fgColor ?? StyleSheetManager.current.labelStyle.FgColor;
        BgColor = bgColor ?? StyleSheetManager.current.labelStyle.BgColor;
        BorderColor = borderColor ?? StyleSheetManager.current.labelStyle.BorderColor;
        BorderWidth = borderWidth ?? StyleSheetManager.current.labelStyle.BorderWidth;
        JustifyText = justifyText ?? StyleSheetManager.current.labelStyle.JustifyText;
        Font = font ?? StyleSheetManager.current.labelStyle.Font;
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
            self.HorizontalContentAlignment = value.horizontal;
            self.VerticalContentAlignment = value.vertical;
        }
    }

    protected override UIElement GetUIElement()
    {
        return border;
    }
}
