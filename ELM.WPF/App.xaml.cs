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
        var mainWindow = new MainWindow();
        mainWindow.Show();
    }

    private void ConfigureServices(IServiceCollection services)
    {
        // Add HttpClient with base address
        services.AddHttpClient("LicenseService", client =>
        {
            client.BaseAddress = new Uri("https://localhost:5001");
        });

        services.AddSingleton<NavigationService>(); // Single instance for the app.
        services.AddTransient<LoginViewModel>();    // New instance each time.
        services.AddTransient<MainViewModel>();
        services.AddTransient<MainWindow>();
    }
}
