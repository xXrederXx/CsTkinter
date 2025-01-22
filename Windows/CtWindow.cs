using System.Numerics;
using System.Windows;

namespace CsTkinter.Windows;

public class CtWindow : IWindow
{
    private readonly Window window;

    public CtWindow()
    {
        // Initialize the custom WPF window
        window = new Window();
    }

    public string Title
    {
        get => window.Title;
        set => window.Title = value;
    }

    public Vector2 Geometry
    {
        get => new Vector2((float)window.Width, (float)window.Height);
        set
        {
            window.Width = value.X;
            window.Height = value.Y;
        }
    }

    public Vector2 MinSize
    {
        get => new Vector2((float)window.MinWidth, (float)window.MinHeight);
        set
        {
            window.MinWidth = value.X;
            window.MinHeight = value.Y;
        }
    }

    public Vector2 MaxSize
    {
        get => new Vector2((float)window.MaxWidth, (float)window.MaxHeight);
        set
        {
            window.MaxWidth = value.X;
            window.MaxHeight = value.Y;
        }
    }

    public bool Resizable
    {
        get => window.ResizeMode == ResizeMode.CanResize;
        set => window.ResizeMode = value ? ResizeMode.CanResize : ResizeMode.NoResize;
    }

    public WindowState State
    {
        get => window.WindowState;
        set => window.WindowState = value;
    }

    public void Run()
    {
        // Start the WPF application and show the window
        var app = new Application();
        app.Run(window);
    }
}
