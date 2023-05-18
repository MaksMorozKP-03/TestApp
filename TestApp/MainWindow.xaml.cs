using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestApp.Models;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var rep = new CurrencyRepository();
            Debug.WriteLine("Where is it");
            rep.FetchData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Just message");
        }

        private void LanguageUkrainianChecked(object sender, RoutedEventArgs e)
        {
            AppearanceEditor.ChangeLanguage(new Uri("Languages/Ukrainian.xaml", UriKind.Relative));
        }

        private void LanguageEnglishChecked(object sender, RoutedEventArgs e)
        {
            AppearanceEditor.ChangeLanguage(new Uri("Languages/English.xaml", UriKind.Relative));
        }

        private void ThemeDarkChecked(object sender, RoutedEventArgs e)
        {
            AppearanceEditor.ChangeTheme(new Uri("Themes/Dark.xaml", UriKind.Relative));
        }

        private void ThemeLightChecked(object sender, RoutedEventArgs e)
        {
            AppearanceEditor.ChangeTheme(new Uri("Themes/Light.xaml", UriKind.Relative));
        }
    }
}
