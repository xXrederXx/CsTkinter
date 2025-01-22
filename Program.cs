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
            var app = new CtWindow();

            app.Run();

            Console.WriteLine("WPF Window closed.");
        }
    }
}
