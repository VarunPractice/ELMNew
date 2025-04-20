using ELM.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELM.WPF.Services
{
    public class NavigationService
    {
        public event Action<ViewModelBase>? CurrentViewModelChanged;
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                CurrentViewModelChanged?.Invoke(value);
            }
        }
        public void NavigateTo<T>() where T : ViewModelBase
        {
            CurrentViewModel = Activator.CreateInstance<T>();
        }
    }
}
