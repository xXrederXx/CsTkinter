using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CsTkinter.Utility.DataTypes;
using CsTkinter.Utility.Interfaces;
using CsTkinter.Utility.StyleSheet;

namespace CsTkinter.Widgets;

public class CtInputField : Widget
{
    private readonly TextBox self;

    public CtInputField(
        IPlacableInTo master,
        double? width = null,
        double? height = null,
        string? text = null,
        Brush? fgColor = null,
        Brush? bgColor = null,
        Brush? borderColor = null,
        Thickness? borderWidth = null,
        CornerRadius? cornerRadius = null,
        Alignment? justifyText = null,
        FontType? font = null,
        bool? multibleLineText = null,
        bool? wrapText = null
    )
        : base(master)
    {
        self = new TextBox();
        Width = width ?? StyleSheetManager.current.inputFieldStyle.Width;
        Height = height ?? StyleSheetManager.current.inputFieldStyle.Height;
        Text = text ?? StyleSheetManager.current.inputFieldStyle.Text;
        FgColor = fgColor ?? StyleSheetManager.current.inputFieldStyle.FgColor;
        BgColor = bgColor ?? StyleSheetManager.current.inputFieldStyle.BgColor;
        BorderColor = borderColor ?? StyleSheetManager.current.inputFieldStyle.BorderColor;
        BorderWidth = borderWidth ?? StyleSheetManager.current.inputFieldStyle.BorderWidth;
        JustifyText = justifyText ?? StyleSheetManager.current.inputFieldStyle.JustifyText;
        MultibleLineText =
            multibleLineText ?? StyleSheetManager.current.inputFieldStyle.MultibleLineText;
        WrapText = wrapText ?? StyleSheetManager.current.inputFieldStyle.WrapText;
        Font = font ?? StyleSheetManager.current.buttonStyle.Font;
        CornerRadius = cornerRadius ?? StyleSheetManager.current.buttonStyle.CornerRadius;

        self.TextChanged += (sender, args) => OnTextChaged?.Invoke();
        self.SelectionChanged += (sender, args) => OnSelectionChanged?.Invoke();

        SetUpInputInternals();
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
        get => self.Text;
        set => self.Text = value;
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
            self.HorizontalContentAlignment = value.horizontal;
            self.VerticalContentAlignment = value.vertical;
            if (value.vertical == VerticalAlignment.Center)
            {
                self.Padding = new Thickness(
                    self.Padding.Left,
                    self.Height * 0.2453703704 - 3.8888888896, // This is the best approximation i found
                    self.Padding.Right, // I used some sample points and solved for y = ax + b
                    self.Padding.Bottom // With points (24, 2) and (55, 240)
                );
            }
            else
            {
                self.Padding = new Thickness(0);
            }
        }
    }
    public FontType Font
    {
        get =>
            new FontType(
                self.FontFamily,
                self.FontSize,
                self.FontStyle,
                self.FontWeight,
                self.FontStretch
            );
        set
        {
            self.FontFamily = value.fontFamily;
            self.FontSize = value.fontSize;
            self.FontStyle = value.fontStyle;
            self.FontWeight = value.fontWeight;
            self.FontStretch = value.fontStretch;
        }
    }
    public CornerRadius CornerRadius
    {
        get => (CornerRadius)self.GetValue(Border.CornerRadiusProperty);
        set => self.SetValue(Border.CornerRadiusProperty, value);
    }
    public bool MultibleLineText
    {
        get => self.AcceptsReturn;
        set => self.AcceptsReturn = value;
    }
    public bool WrapText
    {
        get => self.TextWrapping != TextWrapping.NoWrap;
        set => self.TextWrapping = value ? TextWrapping.Wrap : TextWrapping.NoWrap;
    }

    public Action? OnTextChaged;
    public Action? OnSelectionChanged;

    [Obsolete("The Spell check is not really good, it is very old")]
    public bool SpellCheck
    {
        get => self.SpellCheck.IsEnabled;
        set => self.SpellCheck.IsEnabled = value;
    }
    public string SelectedText
    {
        get => self.SelectedText;
    }

    private void SetUpInputInternals()
    {
        ControlTemplate controlTemplate = new ControlTemplate(typeof(TextBox));

        FrameworkElementFactory borderFactory = new FrameworkElementFactory(typeof(Border));
        borderFactory.SetValue(
            Border.BackgroundProperty,
            new TemplateBindingExtension(TextBox.BackgroundProperty)
        );
        borderFactory.SetValue(
            Border.BorderBrushProperty,
            new TemplateBindingExtension(TextBox.BorderBrushProperty)
        );
        borderFactory.SetValue(
            Border.BorderThicknessProperty,
            new TemplateBindingExtension(TextBox.BorderThicknessProperty)
        );
        borderFactory.SetValue(
            Border.PaddingProperty,
            new TemplateBindingExtension(TextBox.PaddingProperty)
        );
        borderFactory.SetValue(
            Border.CornerRadiusProperty,
            new TemplateBindingExtension(Border.CornerRadiusProperty)
        );

        FrameworkElementFactory scrollViewerFactory = new FrameworkElementFactory(
            typeof(ScrollViewer)
        );
        scrollViewerFactory.SetValue(
            ScrollViewer.HorizontalScrollBarVisibilityProperty,
            ScrollBarVisibility.Disabled
        );
        scrollViewerFactory.SetValue(
            ScrollViewer.VerticalScrollBarVisibilityProperty,
            ScrollBarVisibility.Hidden
        );

        // Add the required PART_ContentHost inside the ScrollViewer
        FrameworkElementFactory contentHostFactory = new FrameworkElementFactory(typeof(Decorator));
        contentHostFactory.Name = "PART_ContentHost";

        scrollViewerFactory.AppendChild(contentHostFactory);
        borderFactory.AppendChild(scrollViewerFactory);

        controlTemplate.VisualTree = borderFactory;
        self.Template = controlTemplate;
    }

    protected override UIElement GetUIElement()
    {
        return self;
    }
}
