using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CsTkinter.Utility.Interfaces;
using CsTkinter.Utility.StyleSheet;

namespace CsTkinter.Widgets;

public class CtFrame : Widget, IPlacableInTo
{
    private readonly Canvas self;
    private readonly Border border;
    private readonly List<(UIElement element, double x, double y)> RelativElements = [];

    public CtFrame(
        IPlacableInTo master,
        double? width = null,
        double? height = null,
        CornerRadius? cornerRadius = null,
        Brush? bgColor = null,
        Brush? borderColor = null,
        Thickness? borderWidth = null
    )
        : base(master)
    {
        self = new Canvas();
        border = new Border();
        border.Child = self;
        self.SizeChanged += (s, e) => UpdatePositionOfRelativ();

        Width = width ?? StyleSheetManager.current.frameStyle.Width;
        Height = height ?? StyleSheetManager.current.frameStyle.Height;
        CornerRadius = cornerRadius ?? StyleSheetManager.current.frameStyle.CornerRadius;
        BgColor = bgColor ?? StyleSheetManager.current.frameStyle.BgColor;
        BorderColor = borderColor ?? StyleSheetManager.current.frameStyle.BorderColor;
        BorderWidth = borderWidth ?? StyleSheetManager.current.frameStyle.BorderWidth;
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
    public CornerRadius CornerRadius
    {
        get => border.CornerRadius;
        set => border.CornerRadius = value;
    }
    public Brush BgColor
    {
        get => self.Background;
        set => self.Background = value;
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

    public void Place(UIElement element, double x, double y)
    {
        // Ensure the element is added to the canvas
        if (!self.Children.Contains(element))
        {
            self.Children.Add(element);
        }

        // Set absolute position
        Canvas.SetLeft(element, x);
        Canvas.SetTop(element, y);
    }

    public void PlaceRelativ(UIElement element, double percentx, double percenty)
    {
        double x = self.ActualWidth / 100 * percentx;
        double y = self.ActualHeight / 100 * percenty;

        // Ensure the element is added to the canvas
        if (!self.Children.Contains(element))
        {
            self.Children.Add(element);
            RelativElements.Add((element, percentx, percenty));
        }

        // Set absolute position
        Canvas.SetLeft(element, x);
        Canvas.SetTop(element, y);
    }

    private void UpdatePositionOfRelativ()
    {
        foreach ((UIElement, double, double) relativElement in RelativElements)
        {
            PlaceRelativ(relativElement.Item1, relativElement.Item2, relativElement.Item3);
        }
    }

    protected override UIElement GetUIElement()
    {
        return border;
    }
}
