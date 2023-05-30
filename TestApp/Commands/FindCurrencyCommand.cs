using System;
using TestApp.Services;
using TestApp.ViewModels;

namespace TestApp.Commands
{
    public class FindCurrencyCommand : BaseCommand
    {
        private readonly FindCurrencyViewModel _viewModel;

        public FindCurrencyCommand(FindCurrencyViewModel viewModel)
        {
            _viewModel = viewModel;
            _viewModel.PropertyChanged += ViewModelPropertyChanged;
        }

        private void ViewModelPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_viewModel.QueryString))
                OnCanExecuteChanged();
        }

        public override bool CanExecute(object? parameter)
        {
            return !String.IsNullOrEmpty(_viewModel.QueryString) && base.CanExecute(parameter);
        }
        public override void Execute(object? parameter)
        {
            CurrenciesService currenciesService = new CurrenciesService();
            _viewModel.FoundCurrencies = currenciesService.GetCurrenciesByQuery(_viewModel.QueryString);
        }


    }
}
