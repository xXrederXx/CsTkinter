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

        this.fgColor = fgColor ?? Utility.BrushConverter.FromColor(0, 0, 0);
        this.bgColor = bgColor ?? Utility.BrushConverter.FromColor(255, 255, 255);
        this.borderColor = borderColor ?? Utility.BrushConverter.FromColor(0, 0, 0, 0);
        HoverFgColor = hoverFgColor;
        HoverBgColor = hoverBgColor;
        HoverBorderColor = hoverBorderColor;
        ClickFgColor = clickFgColor;
        ClickBgColor = clickBgColor;
        ClickBorderColor = clickBorderColor;

        if (font is not null)
            Font = (FontType)font;

        if (borderWidth is not null)
            BorderWidth = (Thickness)borderWidth;
            
        if (justifyText is not null)
            JustifyText = (Alignment)justifyText;

        SetUpButtonInternals();
        SetUpEvents();

        // Ensure a default visual style is applied
        ApplyOnMouseLeaveStyle();
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

    public Brush FgColor
    {
        get => fgColor;
        set
        {
            fgColor = value;
            ReApplyCurrentStyle();
        }
    }
    public Brush BgColor
    {
        get => bgColor;
        set
        {
            bgColor = value;
            ReApplyCurrentStyle();
        }
    }
    public Brush BorderColor
    {
        get => borderColor;
        set
        {
            borderColor = value;
            ReApplyCurrentStyle();
        }
    }
    public Brush? HoverFgColor
    {
        get => hoverFgColor;
        set
        {
            hoverFgColor = value;
            ReApplyCurrentStyle();
        }
    }
    public Brush? HoverBgColor
    {
        get => hoverBgColor;
        set
        {
            hoverBgColor = value;
            ReApplyCurrentStyle();
        }
    }
    public Brush? HoverBorderColor
    {
        get => hoverBorderColor;
        set
        {
            hoverBorderColor = value;
            ReApplyCurrentStyle();
        }
    }
    public Brush? ClickFgColor
    {
        get => clickFgColor;
        set
        {
            clickFgColor = value;
            ReApplyCurrentStyle();
        }
    }
    public Brush? ClickBgColor
    {
        get => clickBgColor;
        set
        {
            clickBgColor = value;
            ReApplyCurrentStyle();
        }
    }
    public Brush? ClickBorderColor
    {
        get => clickBorderColor;
        set
        {
            clickBorderColor = value;
            ReApplyCurrentStyle();
        }
    }

    private Brush fgColor;
    private Brush bgColor;
    private Brush borderColor;
    private Brush? hoverFgColor = null;
    private Brush? hoverBgColor = null;
    private Brush? hoverBorderColor = null;
    private Brush? clickFgColor = null;
    private Brush? clickBgColor = null;
    private Brush? clickBorderColor = null;

    public Action? OnClick;

    private enum LastStyleCall
    {
        Enter,
        Leave,
        Up,
        Down,
    }

    private LastStyleCall lastStyleCall;

    private void SetUpButtonInternals()
    {
        // Ensure the button's visual appearance
        self.OverridesDefaultStyle = true;

        // Define a Style with a new ControlTemplate
        Style style = new Style(typeof(Button));

        // Define the ControlTemplate
        ControlTemplate controlTemplate = new ControlTemplate(typeof(Button));
        FrameworkElementFactory borderFactory = new FrameworkElementFactory(typeof(Border));
        borderFactory.SetValue(
            Border.BackgroundProperty,
            new TemplateBindingExtension(Button.BackgroundProperty)
        );
        borderFactory.SetValue(
            Border.BorderBrushProperty,
            new TemplateBindingExtension(Button.BorderBrushProperty)
        );
        borderFactory.SetValue(
            Border.BorderThicknessProperty,
            new TemplateBindingExtension(Button.BorderThicknessProperty)
        );
        borderFactory.SetValue(
            Border.PaddingProperty,
            new TemplateBindingExtension(Button.PaddingProperty)
        );

        // Add a ContentPresenter to the Border
        FrameworkElementFactory contentPresenterFactory = new FrameworkElementFactory(
            typeof(ContentPresenter)
        );
        contentPresenterFactory.SetValue(
            ContentPresenter.ContentProperty,
            new TemplateBindingExtension(Button.ContentProperty)
        );
        contentPresenterFactory.SetValue(
            ContentPresenter.HorizontalAlignmentProperty,
            HorizontalAlignment.Center
        );
        contentPresenterFactory.SetValue(
            ContentPresenter.VerticalAlignmentProperty,
            VerticalAlignment.Center
        );

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

    private void ReApplyCurrentStyle()
    {
        switch (lastStyleCall)
        {
            case LastStyleCall.Enter:
                ApplyOnMouseEnterStyle();
                break;
            case LastStyleCall.Leave:
                ApplyOnMouseLeaveStyle();
                break;
            case LastStyleCall.Down:
                ApplyOnMouseDownStyle();
                break;
            case LastStyleCall.Up:
                ApplyOnMouseUpStyle();
                break;
            default:
                System.Console.WriteLine("This should not happen");
                break;
        }
    }

    private void ApplyOnMouseEnterStyle()
    {
        lastStyleCall = LastStyleCall.Enter;
        self.Foreground = HoverFgColor is null ? FgColor : HoverFgColor;
        self.Background = HoverBgColor is null ? BgColor : HoverBgColor;
        self.BorderBrush = HoverBorderColor is null ? BorderColor : HoverBorderColor;
    }

    private void ApplyOnMouseLeaveStyle()
    {
        lastStyleCall = LastStyleCall.Leave;
        self.Foreground = FgColor;
        self.Background = BgColor;
        self.BorderBrush = BorderColor;
    }

    private void ApplyOnMouseDownStyle()
    {
        lastStyleCall = LastStyleCall.Down;
        self.Foreground = ClickFgColor is null ? FgColor : ClickFgColor;
        self.Background = ClickBgColor is null ? BgColor : ClickBgColor;
        self.BorderBrush = ClickBorderColor is null ? BorderColor : ClickBorderColor;
    }

    private void ApplyOnMouseUpStyle()
    {
        lastStyleCall = LastStyleCall.Up;
        self.Foreground = HoverFgColor is null ? FgColor : HoverFgColor;
        self.Background = HoverBgColor is null ? BgColor : HoverBgColor;
        self.BorderBrush = HoverBorderColor is null ? BorderColor : HoverBorderColor;
    }

    protected override UIElement GetUIElement()
    {
        return self;
    }
}
