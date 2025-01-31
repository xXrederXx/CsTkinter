using CsTkinter.Utility.Interfaces;
using System.Windows;

namespace CsTkinter.Widgets;

public abstract class Widget
{
    protected IPlacableInTo master { get; }
    protected Widget(IPlacableInTo master){
        this.master = master;
    }

    public abstract double Width { get; set; }
    public abstract double Height { get; set; }

    public void Place(double x, double y)
    {
        master.Place(GetUIElement(), x, y);
    }
    public void PlaceRelativ(double x, double y)
    {
        master.PlaceRelativ(GetUIElement(), x, y);
    }
    protected abstract UIElement GetUIElement();
}
