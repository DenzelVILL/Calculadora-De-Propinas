using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator.ViewModels
{
    public partial class AboutViewModels :  ObservableObject
    {
        [ObservableProperty]
        private string _apiVersion;

        public AboutViewModels()
        {
            ApiVersion = "Versión 0.1";
        }

        [RelayCommand]
        public async Task OpenPreferences() 
        {
            await Shell.Current.GoToAsync("UserPreferences");
        
        }

       
    }
}
