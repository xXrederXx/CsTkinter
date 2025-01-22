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

            app.Run();

            Console.WriteLine("WPF Window closed.");
        }
    }
}
