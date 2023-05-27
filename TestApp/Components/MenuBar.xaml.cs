using System;
using System.Collections.Generic;
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
using TestApp.Services;

namespace TestApp.Components
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
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
