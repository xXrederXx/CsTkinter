
namespace CsTkinter.Utility.StyleSheet;

public static class StyleSheetManager
{
    public static IStyleSheet current;

    static StyleSheetManager()
    {
        current = new StyleSheetDark();
    }
}
