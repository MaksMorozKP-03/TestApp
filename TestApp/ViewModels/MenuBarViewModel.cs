using System;
using System.Windows;
using System.Windows.Input;
using TestApp.Commands;
using TestApp.Services;
using TestApp.Stores;

namespace TestApp.ViewModels
{
    public class MenuBarViewModel : ViewModelBase
    {


        public void ThemeDarkChecked(object sender, RoutedEventArgs e)
        {
            AppearanceEditor.ChangeTheme(new Uri("Themes/Dark.xaml", UriKind.Relative));
        }

        public void ThemeLightChecked(object sender, RoutedEventArgs e)
        {
            AppearanceEditor.ChangeTheme(new Uri("Themes/Light.xaml", UriKind.Relative));
        }
        public ICommand LanguageChangeCommand { get; }
        public ICommand ThemeChangeCommand { get; }
        public ICommand CurrenciesNavigationCommand { get; }
        public ICommand FindCurrencyNavigationCommand { get; }

        public MenuBarViewModel(NavigationStore navigationStore)
        {
            LanguageChangeCommand = new ChangeLanguageCommand();
            ThemeChangeCommand = new ChangeThemeCommand();
            CurrenciesNavigationCommand = new CurrenciesNavigationCommand(navigationStore);
            FindCurrencyNavigationCommand = new FindCurrencyNavigationCommand(navigationStore);
        }
    }
}
