using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CsTkinter.Utility;
using CsTkinter.Utility.DataTypes;
using CsTkinter.Windows;

namespace CsTkinter.Widgets;

public class CtButton : Widget
{
    private readonly Button self;

    public CtButton(
        IWindow master,
        double width = 100,
        double height = 24,
        string text = "CtButton",
        Brush? fgColor = null,
        Brush? bgColor = null,
        Brush? borderColor = null,
        Brush? hoverFgColor = null,
        Brush? hoverBgColor = null,
        Brush? hoverBorderColor = null,
        Brush? clickFgColor = null,
        Brush? clickBgColor = null,
        Brush? clickBorderColor = null,
        FontType? font = null,
        Thickness? borderWidth = null,
        Alignment? justifyText = null

    )
        : base(master)
    {
        self = new Button();
        
        Width = width;
        Height = height;
        Text = text;
        if(fgColor is not null) FgColor = fgColor;
        if(bgColor is not null) BgColor = bgColor;
        if(borderColor is not null) BorderColor = borderColor;
        HoverFgColor = hoverFgColor;
        HoverBgColor = hoverBgColor;
        HoverBorderColor = hoverBorderColor;
        ClickFgColor = clickFgColor;
        ClickBgColor = clickBgColor;
        ClickBorderColor = clickBorderColor;
        if(font is not null) Font = (FontType)font;
        if(borderWidth is not null) BorderWidth = (Thickness)borderWidth;
        if(justifyText is not null) JustifyText = (Alignment)justifyText;

        SetUpButtonInternals();
        SetUpEvents();

        // Ensure a default visual style is applied
        ApplyOnMouseLeaveStyle();
    }

    private void SetUpButtonInternals()
    {
        // Ensure the button's visual appearance
        self.OverridesDefaultStyle = true;

        // Define a Style with a new ControlTemplate
        Style style = new Style(typeof(Button));

        // Define the ControlTemplate
        ControlTemplate controlTemplate = new ControlTemplate(typeof(Button));
        FrameworkElementFactory borderFactory = new FrameworkElementFactory(typeof(Border));
        borderFactory.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(Button.BackgroundProperty));
        borderFactory.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(Button.BorderBrushProperty));
        borderFactory.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(Button.BorderThicknessProperty));
        borderFactory.SetValue(Border.PaddingProperty, new TemplateBindingExtension(Button.PaddingProperty));

        // Add a ContentPresenter to the Border
        FrameworkElementFactory contentPresenterFactory = new FrameworkElementFactory(typeof(ContentPresenter));
        contentPresenterFactory.SetValue(ContentPresenter.ContentProperty, new TemplateBindingExtension(Button.ContentProperty));
        contentPresenterFactory.SetValue(ContentPresenter.HorizontalAlignmentProperty, HorizontalAlignment.Center);
        contentPresenterFactory.SetValue(ContentPresenter.VerticalAlignmentProperty, VerticalAlignment.Center);

        borderFactory.AppendChild(contentPresenterFactory);
        controlTemplate.VisualTree = borderFactory;

        // Assign the template to the style
        style.Setters.Add(new Setter(Button.TemplateProperty, controlTemplate));
        self.Style = style;
    }
    private void SetUpEvents()
    {
        // Set up event handlers
        self.Click += (s, e) => OnClick?.Invoke();
        self.MouseEnter += (s, e) => ApplyOnMouseEnterStyle();
        self.MouseLeave += (s, e) => ApplyOnMouseLeaveStyle();
        self.PreviewMouseDown += (s, e) => ApplyOnMouseDownStyle();
        self.PreviewMouseUp += (s, e) => ApplyOnMouseUpStyle();
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

    public Brush FgColor = Utility.BrushConverter.FromColor(0, 0, 0);
    public Brush BgColor = Utility.BrushConverter.FromColor(255, 255, 255);
    public Brush BorderColor = Utility.BrushConverter.FromColor(0, 0, 0, 0);
    public Brush? HoverFgColor = null;
    public Brush? HoverBgColor = null;
    public Brush? HoverBorderColor = null;
    public Brush? ClickFgColor = null;
    public Brush? ClickBgColor = null;
    public Brush? ClickBorderColor = null;
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

    private void ApplyOnMouseEnterStyle()
    {
        self.Foreground = HoverFgColor is null ? FgColor : HoverFgColor;
        self.Background = HoverBgColor is null ? BgColor : HoverBgColor;
        self.BorderBrush = HoverBorderColor is null ? BorderColor : HoverBorderColor;
    }

    private void ApplyOnMouseLeaveStyle()
    {
        self.Foreground = FgColor;
        self.Background = BgColor;
        self.BorderBrush = BorderColor;
    }

    private void ApplyOnMouseDownStyle()
    {
        System.Console.WriteLine("E");
        self.Foreground = ClickFgColor is null ? FgColor : ClickFgColor;
        self.Background = ClickBgColor is null ? BgColor : ClickBgColor;
        self.BorderBrush = ClickBorderColor is null ? BorderColor : ClickBorderColor;
    }

    private void ApplyOnMouseUpStyle()
    {
        self.Foreground = HoverFgColor is null ? FgColor : HoverFgColor;
        self.Background = HoverBgColor is null ? BgColor : HoverBgColor;
        self.BorderBrush = HoverBorderColor is null ? BorderColor : HoverBorderColor;
    }

    protected override UIElement GetUIElement()
    {
        return self;
    }
}
