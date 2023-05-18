using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp
{
    class CurrencyRepository
    {
        private ObservableCollection<Currency> _currencies;
        public void FetchData()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("User-Agent", "Agent");
            var response = client.GetFromJsonAsync<ObservableCollection<Currency>>("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=100&page=1&sparkline=false&locale=en");

            Debug.WriteLine(_currencies);

            _currencies = response.Result;
        }
        public ObservableCollection<Currency> GetCurrencies()
        {
            return _currencies;
        }
    }
}
