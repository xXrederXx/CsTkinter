using System;
using System.Windows;

namespace CsTkinter.Utility.DataTypes;

public struct Alignment
{
    public Alignment(HorizontalAlignment horizontal, VerticalAlignment vertical)
    {
        this.horizontal = horizontal;
        this.vertical = vertical;
    }
    public readonly HorizontalAlignment horizontal;
    public readonly VerticalAlignment vertical;
}
