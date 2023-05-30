using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using TestApp.Commands;
using TestApp.Models;
using TestApp.Stores;

namespace TestApp.ViewModels
{
    public class FindCurrencyViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;
        private ObservableCollection<Currency> _foundCurrencies;
        public ObservableCollection<Currency> FoundCurrencies
        {
            get
            {
                return _foundCurrencies;
            }
            set
            {
                _foundCurrencies = value;
                OnPropertyChanged(nameof(FoundCurrencies));
                if (_foundCurrencies is not null && _foundCurrencies.Any())
                    _isTableVisible = true;
                else _isTableVisible = false;

                OnPropertyChanged(nameof(IsTableVisible));
            }
        }
        private string _queryString;
        public string QueryString
        {
            get { return _queryString; }
            set
            {
                _queryString = value;
                OnPropertyChanged(nameof(QueryString));               
            }
        }
        private bool _isTableVisible;
        public Visibility IsTableVisible
        {
            get
            {
                return _isTableVisible
                    ? Visibility.Visible : Visibility.Hidden;
            }
        }

        public ICommand FindCurrencyCommand { get; }

        public FindCurrencyViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            FindCurrencyCommand = new FindCurrencyCommand(this);
        }
    }
}
