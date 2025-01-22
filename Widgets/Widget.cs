using System;
using CsTkinter.Windows;
using System.Windows;

namespace CsTkinter.Widgets;

public abstract class Widget
{
    protected IWindow master { get; }
    protected Widget(IWindow master){
        this.master = master;
    }

    public void Place(double x, double y)
    {
        master.Place(GetUIElement(), x, y);
    }
    protected abstract UIElement GetUIElement();
}
