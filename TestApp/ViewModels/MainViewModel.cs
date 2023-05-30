using TestApp.Stores;

namespace TestApp.ViewModels
{
    public class MainViewModel :ViewModelBase
    {
        private readonly NavigationStore _navigationStore;

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        public MenuBarViewModel MenuViewModel { get; }

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
            MenuViewModel = new MenuBarViewModel(navigationStore);
        }

        private void OnCurrentViewModelChanged()
        {
           OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
