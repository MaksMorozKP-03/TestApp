using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.ViewModels
{
    internal class FindCurrencyViewModel
    {
        private ObservableCollection<Currency> _foundCurrencies;
        public ObservableCollection<Currency> FoundCurrencies
        {
            get
            {
                return _foundCurrencies;
            }
        }

        public FindCurrencyViewModel()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("User-Agent", "Agent");
        }
        //private ObservableCollection<Currency> FindCurrencies(string name)
        //{

        //}

    }
}
