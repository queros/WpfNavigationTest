using System.Windows;
using WpfNavigationTest.ViewModels;

namespace WpfNavigationTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var app = new MainWindow();
            var context = new MainWindowViewModel();
            app.DataContext = context;
            app.Show();
        }
    }
}
