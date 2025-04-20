using CommunityToolkit.Mvvm.ComponentModel;
using ELM.WPF.Services;

namespace ELM.WPF.ViewModels;
public partial class MainViewModel : ViewModelBase
{
    private readonly NavigationService _navigationService;

    public MainViewModel(NavigationService navigationService)
    {
        _navigationService = navigationService;
        // Use the renamed method
        _navigationService.CurrentViewModelChanged += OnCurrentViewModelChangedHandler;
    }

    // Renamed method to avoid conflict
    private void OnCurrentViewModelChangedHandler(ViewModelBase viewModel)
    {
        CurrentViewModel = viewModel;
    }

    [ObservableProperty]
    private ViewModelBase _currentViewModel;
}