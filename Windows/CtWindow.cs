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

    public string Title() => window.Title;
    public void Title(string title)
    {
        window.Title = title;
    }

    public Vector2 Geometry() => new Vector2((float)window.Width, (float)window.Height);
    public void Geometry(Vector2 size)
    {
        window.Width = size.X;
        window.Height = size.Y;
    }

    public Vector2 MinSize() => new Vector2((float)window.MinWidth, (float)window.MinHeight);
    public void MinSize(Vector2 size)
    {
        window.MinWidth = size.X;
        window.MinHeight = size.Y;
    }

    public Vector2 MaxSize() => new Vector2((float)window.MaxWidth, (float)window.MaxHeight);
    public void MaxSize(Vector2 size)
    {
        window.MaxWidth = size.X;
        window.MaxHeight = size.Y;
    }

    public bool Resizable() => window.ResizeMode == ResizeMode.CanResize;
    public void Resizable(bool resizable)
    {
        window.ResizeMode = resizable ? ResizeMode.CanResize : ResizeMode.NoResize;
    }

    public WindowState State() => window.WindowState;
    public void State(WindowState state)
    {
        window.WindowState = state;
    }

    public void Run()
    {
        // Start the WPF application and show the window
        var app = new Application();
        app.Run(window);
    }
}
