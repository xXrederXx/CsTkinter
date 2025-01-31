using System.Numerics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CsTkinter.Utility.Interfaces;
using CsTkinter.Utility.StyleSheet;

namespace CsTkinter.Utility;

public class CtWindow : IPlacableInTo
{
    private readonly Window self;
    private readonly Canvas canvas;
    private readonly List<(UIElement element, double x, double y)> RelativElements = [];

    public CtWindow(
        string? title = null,
        Vector2? geometry = null,
        Vector2? minSize = null,
        Vector2? maxSize = null,
        bool? resizable = null,
        WindowState? state = null,
        Brush? bgColor = null
    )
    {
        // Initialize the custom WPF window
        self = new Window();
        canvas = new();

        self.Content = canvas;
        canvas.SizeChanged += (s, e) => UpdatePositionOfRelativ();

        Title = title ?? StyleSheetManager.current.windowStyle.Title;
        Geometry = geometry ?? StyleSheetManager.current.windowStyle.Geometry;
        MinSize = minSize ?? StyleSheetManager.current.windowStyle.MinSize;
        MaxSize = maxSize ?? StyleSheetManager.current.windowStyle.MaxSize;
        Resizable = resizable ?? StyleSheetManager.current.windowStyle.Resizable;
        State = state ?? StyleSheetManager.current.windowStyle.State;
        BgColor = bgColor ?? StyleSheetManager.current.windowStyle.BgColor;
    }

    public string Title
    {
        get => self.Title;
        set => self.Title = value;
    }

    public Vector2 Geometry
    {
        get => new Vector2((float)self.Width, (float)self.Height);
        set
        {
            self.Width = value.X;
            self.Height = value.Y;
        }
    }

    public Vector2 MinSize
    {
        get => new Vector2((float)self.MinWidth, (float)self.MinHeight);
        set
        {
            self.MinWidth = value.X;
            self.MinHeight = value.Y;
        }
    }

    public Vector2 MaxSize
    {
        get => new Vector2((float)self.MaxWidth, (float)self.MaxHeight);
        set
        {
            self.MaxWidth = value.X;
            self.MaxHeight = value.Y;
        }
    }

    public bool Resizable
    {
        get => self.ResizeMode == ResizeMode.CanResize;
        set => self.ResizeMode = value ? ResizeMode.CanResize : ResizeMode.NoResize;
    }

    public WindowState State
    {
        get => self.WindowState;
        set => self.WindowState = value;
    }
    public Brush BgColor
    {
        get => canvas.Background;
        set => canvas.Background = value;
    }
    public void Place(UIElement element, double x, double y)
    {
        // Ensure the element is added to the canvas
        if (!canvas.Children.Contains(element))
        {
            canvas.Children.Add(element);
        }

        // Set absolute position
        Canvas.SetLeft(element, x);
        Canvas.SetTop(element, y);
    }

    public void PlaceRelativ(UIElement element, double percentx, double percenty)
    {
        double x = canvas.ActualWidth / 100 * percentx;
        double y = canvas.ActualHeight / 100 * percenty;

        // Ensure the element is added to the canvas
        if (!canvas.Children.Contains(element))
        {
            canvas.Children.Add(element);
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

    public void Run()
    {
        // Start the WPF application and show the window
        Application app = new Application();
        app.Run(self);
    }
}
