using TestApp.Models;
using TestApp.Stores;
using TestApp.ViewModels;

namespace TestApp.Commands
{
    public class SelectedCurrencyNavigationCommand : BaseCommand
    {
        private Currency _currency;
        private readonly NavigationStore _navigationStore;  

        public override bool CanExecute(object? parameter)
        {
            return _currency != null && base.CanExecute(parameter);
        }

        public SelectedCurrencyNavigationCommand(Currency currency, NavigationStore navigationStore)
        {
            _currency = currency;
            _navigationStore = navigationStore;
        }

        public void ChangeSelectedCurrency(Currency currency)
        {
            _currency = currency;
            OnCanExecuteChanged();
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new SelectedCurrencyViewModel(_currency);
        }
    }
}
