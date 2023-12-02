using Microsoft.Maui;
using Microsoft.Maui.Controls;
using TipCalculator.Models;
using TipCalculator.ViewModels;

namespace TipCalculator.Views
{
    public partial class TipCalculatorPage : ContentPage
    {
        private TipCalculatorViewModel _viewModel;

        public TipCalculatorPage()
        {
            InitializeComponent();
            _viewModel = new TipCalculatorViewModel();
            BindingContext = _viewModel;
           
        }

        public void CalcularPropina(object sender, EventArgs e)
        {
            _viewModel.CalcularPropina();
        }

        public void LimpiarDatos(object sender, EventArgs e)
        {
            _viewModel.LimpiarDatos();
        }

        private void SliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            _viewModel.TipModel.PorcentajeString = $"Porcentaje: {e.NewValue:F0}%";
           
            PorcentajeLabel.Text = _viewModel.TipModel.PorcentajeString;
        }


    }
}

