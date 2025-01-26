using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CsTkinter.Utility;
using CsTkinter.Utility.DataTypes;
using CsTkinter.Windows;

namespace CsTkinter.Widgets;

public class CtInputField : Widget
{
    private readonly TextBox self;

    public CtInputField(IWindow master,
        double width = 100,
        double height = 24,
        string text = "",
        Brush? fgColor = null,
        Brush? bgColor = null,
        Brush? borderColor = null,
        Thickness? borderWidth = null,
        Alignment? justifyText = null,
        bool multibleLineText = false,
        bool wrapText = false
    )
        : base(master)
    {
        self = new TextBox();
        Width = width;
        Height = height;
        Text = text;
        FgColor = fgColor ?? Utility.BrushConverter.FromColor(0, 0, 0);
        BgColor = bgColor ?? Utility.BrushConverter.FromColor(255, 255, 255);
        BorderColor = borderColor ?? Utility.BrushConverter.FromColor(0, 0, 0, 0);
        if(borderWidth is not null) BorderWidth = (Thickness)borderWidth;
        if(justifyText is not null) JustifyText = (Alignment)justifyText;
        MultibleLineText = multibleLineText;
        WrapText = wrapText;

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
            self.HorizontalAlignment = value.horizontal;
            self.VerticalAlignment = value.vertical;
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

        var borderFactory = new FrameworkElementFactory(typeof(Border));
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
