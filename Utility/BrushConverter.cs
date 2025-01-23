using System;
using System.Windows.Media;

namespace CsTkinter.Utility;

public static class BrushConverter
{
    public static Brush FromColor(Color color)
    {
        return new SolidColorBrush(color);
    }
    public static Brush FromColor(byte r, byte g, byte b, byte a = 255)
    {
        return FromColor(Color.FromArgb(a, r, b, g));
    }
}
