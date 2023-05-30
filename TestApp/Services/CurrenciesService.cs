using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Json;
using TestApp.Models;

namespace TestApp.Services
{
    public class CurrenciesService :IDisposable
    {
        private HttpClient _httpClient;
        public CurrenciesService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Agent");
        }
      
        public ObservableCollection<MarketInfo> GetMarketsPrizes(string currencyId)
        {
            try
            {
                var request = _httpClient.GetFromJsonAsync<MarketResponse>
                ($"https://api.coincap.io/v2/assets/{currencyId}/markets?limit=5").Result;
                return request.Data;

            }
            catch (AggregateException) { return new ObservableCollection<MarketInfo>(); }
        }

        public ObservableCollection<Currency> GetCurrenciesByQuery(string query)
        {
            if (query.Contains(',')) query = MakeQuery(query);

            var result = _httpClient.GetFromJsonAsync<ObservableCollection<Currency>>
                ($"https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&ids={query}&order=market_cap_desc&per_page=100&page=1&sparkline=false&locale=en").Result ??
                new ObservableCollection<Currency>();
            return result;
        }

        private string MakeQuery(string input)
        {
            var ids = input.Split(',');
            string result = "";
            foreach (string id in ids)
            {
                result += "%2C"+id;
            }
            return result.Substring(3);
        }

        public ObservableCollection<Currency> GetTopCurrencies()
        {
           var result = _httpClient.GetFromJsonAsync<ObservableCollection<Currency>>
                ("https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false&locale=en").Result ??
                new ObservableCollection<Currency>();
            return result;
        }

        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}
