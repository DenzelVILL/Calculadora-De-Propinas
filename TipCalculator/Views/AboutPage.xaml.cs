using TipCalculator.ViewModels;

namespace TipCalculator.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
		BindingContext = new AboutViewModels();
	}
}