using System;
using System.Windows;

namespace CsTkinter.Utility.DataTypes;

public readonly struct Alignment
{
    public static readonly Alignment center = new(HorizontalAlignment.Center, VerticalAlignment.Center);
    public Alignment(HorizontalAlignment horizontal, VerticalAlignment vertical)
    {
        this.horizontal = horizontal;
        this.vertical = vertical;
    }
    public readonly HorizontalAlignment horizontal;
    public readonly VerticalAlignment vertical;
}
