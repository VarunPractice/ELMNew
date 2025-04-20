using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ELM.WPF.ViewModels
{
    public partial class LoginViewModel:ViewModelBase
    {
        [ObservableProperty]
        private string _username = string.Empty;
        [ObservableProperty]
        private string _password = string.Empty;
        [RelayCommand]
        private void Login()
        {
            if (Username == "admin" && Password == "admin")
                MessageBox.Show("Login successful!");
            else
                MessageBox.Show("Invalid credentials.");
        }
    }
}
