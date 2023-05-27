using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using TestApp.Models;
using TestApp.ViewModels;

namespace TestApp
{
    public class CurrenciesViewModel : ViewModelBase
    {
        private readonly ObservableCollection<Currency> _currencies;

        public IEnumerable<Currency> Currencies => _currencies;
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
            }
        }

        public CurrenciesViewModel()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("User-Agent", "Agent");
            _currencies = client.GetFromJsonAsync<ObservableCollection<Currency>>
                ("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false&locale=en").Result ??
                new ObservableCollection<Currency>();
            client.Dispose();
        }

    }
}
