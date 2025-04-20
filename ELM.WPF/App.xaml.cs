using ELM.WPF.Services;
using ELM.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ELM.WPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static IServiceProvider ServiceProvider { get; private set; }

    protected override void OnStartup(StartupEventArgs e)
    {
        var services = new ServiceCollection();
        ConfigureServices(services);
        ServiceProvider = services.BuildServiceProvider();

        // Get MainViewModel FIRST to ensure event subscription
        var mainViewModel = ServiceProvider.GetRequiredService<MainViewModel>();

        // THEN perform initial navigation
        var navigationService = ServiceProvider.GetRequiredService<NavigationService>();
        navigationService.NavigateTo<LoginViewModel>();

        var mainWindow = new MainWindow { DataContext = mainViewModel };
        mainWindow.Show();
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddHttpClient("LicenseService", client =>
        {
            client.BaseAddress = new Uri("https://localhost:5001");
        });

        // Register services
        services.AddSingleton<NavigationService>();

        // Register ViewModels
        services.AddTransient<LoginViewModel>();
        services.AddTransient<MainViewModel>();
        services.AddTransient<HomeViewModel>();
    }
}
