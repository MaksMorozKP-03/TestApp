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
using TestApp.Models;

namespace TestApp.Pages
{
    /// <summary>
    /// Interaction logic for CurrenciesPage.xaml
    /// </summary>
    public partial class CurrenciesPage : Page
    {
        public CurrenciesPage()
        {
            InitializeComponent();
            DataContext = new CurrenciesViewModel();
        }     

        private void WatchSelectedCurrency(object sender, MouseButtonEventArgs e)
        {
            SelectedCurrencyPage cp = new SelectedCurrencyPage(DataContext);
            NavigationService.Navigate(cp);
        }
    }
}
