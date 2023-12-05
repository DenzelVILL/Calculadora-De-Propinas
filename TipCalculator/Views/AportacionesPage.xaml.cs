// AportacionesPage.xaml.cs
using Microsoft.Maui.Controls;
using TipCalculator.ViewModels;


namespace TipCalculator.Views
{
    public partial class AportacionPage : ContentPage
    {
        private AportacionViewModel _viewModel;

        public AportacionPage()
        {
            InitializeComponent();
            _viewModel = new AportacionViewModel();
            BindingContext = _viewModel;
        }

        public void CalcularAportacion(object sender, EventArgs e)
        {
            _viewModel.CalcularAportacion();
        }

        public void LimpiarDatos(object sender, EventArgs e)
        {
            _viewModel.LimpiarDatos();
        }
    }
}
