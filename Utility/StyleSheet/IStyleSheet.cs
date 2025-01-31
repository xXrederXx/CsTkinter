using System.Windows.Media;
using CsTkinter.Utility.DataTypes;
using CsTkinter.Widgets;

namespace CsTkinter.Utility.StyleSheet;

public interface IStyleSheet
{
    string Name { get; }

    protected Brush PrimaryColor { get; }
    protected Brush MainTextColor { get; }
    protected FontType MainFontType { get; }

    CtWindow windowStyle { get; }
    CtLabel labelStyle { get; }
    CtButton buttonStyle { get; }
    CtInputField inputFieldStyle { get; }
    CtFrame frameStyle { get; }
}
