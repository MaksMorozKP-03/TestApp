using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp
{
    internal class CurrenciesViewModel
    {
        public ObservableCollection<Currency> Currencies { get; set; }
        private Currency selectedCurrency;
        public Currency SelectedCurrency
        {
            get
            {
                return selectedCurrency;
            }
            set
            {
                selectedCurrency = value;
            }
        }
        public CurrenciesViewModel()
        {
            FetchData();
        }
        private void FetchData()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("User-Agent", "Agent");
            Currencies = client.GetFromJsonAsync<ObservableCollection<Currency>>
                ("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false&locale=en").Result ??
                new ObservableCollection<Currency>();
        }
    }
}
