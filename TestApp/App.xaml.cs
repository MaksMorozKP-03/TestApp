using System.Windows;
using TestApp.Stores;
using TestApp.ViewModels;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new CurrenciesViewModel(_navigationStore);
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            

            base.OnStartup(e);
        }
        public App()
        {
            _navigationStore = new NavigationStore();
        }
    }
}
