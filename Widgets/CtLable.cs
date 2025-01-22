using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using CsTkinter.Windows;

namespace CsTkinter.Widgets;

public class CtLable : Widget
{
    private readonly Label self;
    private readonly Border border;
    

    public CtLable(IWindow master) : base(master)
    {
        self = new Label();
        
        border = new Border();
        border.BorderBrush = new SolidColorBrush(Color.FromRgb(255, 0, 0));
        border.BorderThickness = new(1);
        border.CornerRadius = new(10);
    }

    public double Width
    {
        get => self.Width;
        set => self.Width = value;
    }

    public double Height
    {
        get => self.Height;
        set => self.Height = value;
    }

    protected override UIElement GetUIElement()
    {
        return self;
    }
}
