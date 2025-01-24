using System.Numerics;
using CsTkinter.Widgets;
using CsTkinter.Windows;

namespace WpfConsoleApp
{
    class Program
    {
        [STAThread] // Required for WPF
        static void Main(string[] args)
        {
            Console.WriteLine("Launching WPF Window...");

            // Start the WPF application
            CtWindow app = new CtWindow();
            app.Geometry = new Vector2(200, 200);

            CtButton lable = new CtButton(app);
            lable.PlaceRelativ(50, 50);
            lable.OnClick += () => System.Console.WriteLine("Click!");
            app.Run();

            Console.WriteLine("WPF Window closed.");
        }
    }
}
