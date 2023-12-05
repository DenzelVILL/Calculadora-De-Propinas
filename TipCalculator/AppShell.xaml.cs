using TipCalculator.Views;

namespace TipCalculator
{
    public partial class AppShell : Shell
    {


        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("UserPreferences", typeof(UserPreferencePage));
        }
    }
}