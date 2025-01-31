using System.Windows;

namespace CsTkinter.Utility.Interfaces;

public interface IPlacableInTo
{
    public void Place(UIElement element, double x, double y);
    void PlaceRelativ(UIElement element, double percentx, double percenty);
}
