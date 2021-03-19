using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Globalization;
using System.Threading;

namespace AvaloniaFinal
{
    public class MainWindow : Window
    {
        ViewModels.JobViewModel job = new ViewModels.JobViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = job;



#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
