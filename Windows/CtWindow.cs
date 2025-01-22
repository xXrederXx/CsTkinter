using System.Windows;

namespace CsTkinter.Windows
{
    public class CtWindow
    {
        private Window _window;

        public CtWindow()
        {
            // Initialize the custom WPF window
            _window = new Window
            {
                Title = "Custom WPF Window",
                Width = 400,
                Height = 300,
                Content = new System.Windows.Controls.TextBlock
                {
                    Text = "Welcome to your custom WPF window!",
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    FontSize = 16
                }
            };
        }

        public void Run()
        {
            // Start the WPF application and show the window
            var app = new Application();
            app.Run(_window);
        }
    }
}
