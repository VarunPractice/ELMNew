// MainViewModel.cs
using CommunityToolkit.Mvvm.ComponentModel;
using ELM.WPF.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly NavigationService _navigationService;

    [ObservableProperty]
    private ViewModelBase _currentViewModel;

    public MainViewModel(NavigationService navigationService)
    {
        _navigationService = navigationService;

        // Initialize with current view model
        _currentViewModel = _navigationService.CurrentViewModel;

        // Subscribe to future changes
        _navigationService.CurrentViewModelChanged += vm => CurrentViewModel = vm;
    }
}