using System;
using System.Windows;

namespace CsTkinter.Windows;

public interface IWindow
{
    public void Place(UIElement element, double x, double y);
}
