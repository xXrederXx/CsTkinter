using System.Numerics;
using CsTkinter.Widgets;
using CsTkinter.Windows;
using CsTkinter.Tests.Widgets;

namespace WpfConsoleApp
{
    class Program
    {
        [STAThread] // Required for WPF
        static void Main(string[] args)
        {
            new LableTest();
            Console.WriteLine("Launching WPF Window...");

            // Start the WPF application
            CtWindow app = new CtWindow();
            app.Geometry = new Vector2(200, 200);

            CtLable lable = new CtLable(app, text: "Teeeeeeeeeeeext");
            lable.Place(100, 100);

            app.Run();

            Console.WriteLine("WPF Window closed.");
        }
    }
}
