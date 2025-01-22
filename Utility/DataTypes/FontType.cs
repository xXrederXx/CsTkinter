using System;
using System.Windows;
using System.Windows.Media;

namespace CsTkinter.Utility.DataTypes;

public struct FontType
{
    public readonly FontFamily fontFamily;
    public readonly double fontSize;
    public readonly FontStyle fontStyle;
    public readonly FontWeight fontWeight;
    public readonly FontStretch fontStretch;

    public FontType(FontFamily fontFamily)
    {
        this.fontFamily = fontFamily;
        this.fontSize = 11;
        this.fontStyle = FontStyles.Normal;
        this.fontWeight = FontWeights.Normal;
        this.fontStretch = FontStretches.Normal;
    }
    public FontType(FontFamily fontFamily, double fontSize)
    {
        this.fontFamily = fontFamily;
        this.fontSize = fontSize;
        this.fontStyle = FontStyles.Normal;
        this.fontWeight = FontWeights.Normal;
        this.fontStretch = FontStretches.Normal;
    }
    public FontType(FontFamily fontFamily, double fontSize, FontStyle fontStyle)
    {
        this.fontFamily = fontFamily;
        this.fontSize = fontSize;
        this.fontStyle = fontStyle;
        this.fontWeight = FontWeights.Normal;
        this.fontStretch = FontStretches.Normal;
    }
    public FontType(FontFamily fontFamily, double fontSize, FontStyle fontStyle, FontWeight fontWeight)
    {
        this.fontFamily = fontFamily;
        this.fontSize = fontSize;
        this.fontStyle = fontStyle;
        this.fontWeight = fontWeight;
        this.fontStretch = FontStretches.Normal;
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
