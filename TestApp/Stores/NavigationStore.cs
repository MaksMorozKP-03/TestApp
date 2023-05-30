using System;
using TestApp.ViewModels;

namespace TestApp.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _viewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _viewModel;
            set 
            {
                _viewModel = value;
                OnCurrentViewModelChanged();
            } 
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        public event Action CurrentViewModelChanged; 

    }
}
