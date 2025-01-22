using System;
using CsTkinter.Windows;

namespace CsTkinter.Widgets;

public abstract class Widget
{
    protected IWindow master { get; }
    protected Widget(IWindow master){
        this.master = master;
    }
}
