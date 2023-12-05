using TipCalculator.ViewModels;

namespace TipCalculator.Views;

public partial class UserPreferencePage : ContentPage
{
	public UserPreferencePage()
	{
		InitializeComponent();
		BindingContext = new UserPreferencesViewModel();
	}
}