// NavigationService.cs
using ELM.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;

public class NavigationService
{
    private readonly IServiceProvider _serviceProvider;
    private ViewModelBase _currentViewModel;

    public event Action<ViewModelBase>? CurrentViewModelChanged;

    public NavigationService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void NavigateTo<T>() where T : ViewModelBase
    {
        // Get ViewModel from DI container
        CurrentViewModel = _serviceProvider.GetRequiredService<T>();
    }

    public ViewModelBase CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            _currentViewModel = value;
            CurrentViewModelChanged?.Invoke(value);
        }
    }
}