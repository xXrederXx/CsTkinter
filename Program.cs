using System.Numerics;
using CsTkinter.Tests.Widgets;
using CsTkinter.Widgets;
using CsTkinter.Windows;

namespace WpfConsoleApp
{
    class Program
    {
        [STAThread] // Required for WPF
        static void Main(string[] args)
        {
            new ButtonTest();
            return;
        }
    }
}
