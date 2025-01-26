using System;
using System.Windows;
using System.Windows.Media;

namespace CsTkinter.Utility.DataTypes;

public readonly struct FontType
{
    public readonly FontFamily fontFamily;
    public readonly double fontSize;
    public readonly FontStyle fontStyle;
    public readonly FontWeight fontWeight;
    public readonly FontStretch fontStretch;

    public FontType(FontFamily fontFamily)
    {
        this.fontFamily = fontFamily;
        fontSize = 11;
        fontStyle = FontStyles.Normal;
        fontWeight = FontWeights.Normal;
        fontStretch = FontStretches.Normal;
    }
    public FontType(FontFamily fontFamily, double fontSize)
    {
        this.fontFamily = fontFamily;
        this.fontSize = fontSize;
        fontStyle = FontStyles.Normal;
        fontWeight = FontWeights.Normal;
        fontStretch = FontStretches.Normal;
    }
    public FontType(FontFamily fontFamily, double fontSize, FontStyle fontStyle)
    {
        this.fontFamily = fontFamily;
        this.fontSize = fontSize;
        this.fontStyle = fontStyle;
        fontWeight = FontWeights.Normal;
        fontStretch = FontStretches.Normal;
    }
    public FontType(FontFamily fontFamily, double fontSize, FontStyle fontStyle, FontWeight fontWeight)
    {
        this.fontFamily = fontFamily;
        this.fontSize = fontSize;
        this.fontStyle = fontStyle;
        this.fontWeight = fontWeight;
        fontStretch = FontStretches.Normal;
    }
    public FontType(FontFamily fontFamily, double fontSize, FontStyle fontStyle, FontWeight fontWeight, FontStretch fontStretch)
    {
        this.fontFamily = fontFamily;
        this.fontSize = fontSize;
        this.fontStyle = fontStyle;
        this.fontWeight = fontWeight;
        this.fontStretch = fontStretch;
    }
}
