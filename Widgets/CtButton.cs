using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CsTkinter.Utility.DataTypes;
using CsTkinter.Windows;

namespace CsTkinter.Widgets;

public class CtButton : Widget
{
    private readonly Button self;

    public CtButton(IWindow master, double width = 100, double height = 24, string text = "CtButton")
        : base(master)
    {
        self = new Button()
        {
            Width = width, Height = height, Content = text
        };
        self.Click += (s, e) => OnClick?.Invoke();
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
        get => self.BorderBrush;
        set => self.BorderBrush = value;
    }
    public Thickness BorderWidth
    {
        get => self.BorderThickness;
        set => self.BorderThickness = value;
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

    public Action? OnClick;
    protected override UIElement GetUIElement()
    {
        return self;
    }
}
