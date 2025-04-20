using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ELM.WPF.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Windows;

namespace ELM.WPF.ViewModels;

public partial class LoginViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _username = string.Empty;

    [ObservableProperty]
    private string _password = "admin";

    partial void OnPasswordChanged(string value)
    {
        Debug.WriteLine($"Password updated: {value}");
    }

    [RelayCommand]
    private void Login()
    {
        System.Diagnostics.Debug.WriteLine($"Attempting login with: {Username}/{Password}");

        if (Username == "admin" && Password == "admin")
        {
            var navigationService = App.ServiceProvider.GetRequiredService<NavigationService>();
            navigationService.NavigateTo<HomeViewModel>();
        }
        else
        {
            MessageBox.Show("Invalid credentials.");
        }
    }

}