using System.Collections.ObjectModel;
using TestApp.Commands;
using TestApp.Models;
using TestApp.Services;
using TestApp.Stores;

namespace TestApp.ViewModels
{
    public class CurrenciesViewModel : ViewModelBase
    {
        private readonly ObservableCollection<Currency> _currencies;

        public ObservableCollection<Currency> Currencies => _currencies;
        private Currency _selectedCurrency;

        public Currency SelectedCurrency
        {
            get
            {
                return _selectedCurrency;
            }
            set
            {
                _selectedCurrency = value;
                SelectCurrencyCommand.ChangeSelectedCurrency(_selectedCurrency);
            }
        }

        public SelectedCurrencyNavigationCommand SelectCurrencyCommand { get; }

        public CurrenciesViewModel(NavigationStore navigationStore)
        {
            CurrenciesService currenciesService = new CurrenciesService();           
            _currencies = currenciesService.GetTopCurrencies();
            SelectCurrencyCommand = new SelectedCurrencyNavigationCommand(_selectedCurrency, navigationStore);
        }

    }
}
