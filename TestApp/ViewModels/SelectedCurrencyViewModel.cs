using System.Collections.ObjectModel;
using TestApp.Models;
using TestApp.Services;

namespace TestApp.ViewModels
{
    public class SelectedCurrencyViewModel : ViewModelBase
    {
        private Currency _currency;
        public SelectedCurrencyViewModel(Currency currency)
        {
            _currency = currency;
            CurrenciesService currenciesService = new CurrenciesService();
            MarketInfos = currenciesService.GetMarketsPrizes(currency.Id);
        }
        public Currency Currency => _currency;
        public ObservableCollection<MarketInfo> MarketInfos { get; set; }
    }
}
