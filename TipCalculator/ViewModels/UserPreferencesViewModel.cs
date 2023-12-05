using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator.ViewModels
{
    public partial class UserPreferencesViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _displayName;

        [ObservableProperty]
        private string _themeSelection;

        [ObservableProperty]
        private bool _wifiOnly;

        
        public string ThemeGroupName => "Theme";

        public UserPreferencesViewModel() 
        {
            DisplayName = Preferences.Default.Get(nameof(DisplayName), string.Empty);
            ThemeSelection = Preferences.Default.Get(nameof(ThemeSelection), "Ligth");
            WifiOnly = Preferences.Default.Get(nameof(WifiOnly), false);

        }

        [RelayCommand]
        public void SavePreferences()
        {
            Preferences.Default.Set(nameof(DisplayName), DisplayName);
            Preferences.Default.Set(nameof(ThemeSelection), ThemeSelection);
            Preferences.Default.Set(nameof(WifiOnly), WifiOnly);


        }

    }
}
