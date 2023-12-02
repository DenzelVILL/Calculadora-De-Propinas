using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui;
using System.Windows.Input;
using TipCalculator.Models;

namespace TipCalculator.ViewModels
{
    public class TipCalculatorViewModel : ObservableObject
    {
        private static TipCalculatorViewModel _instance;

        public static TipCalculatorViewModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TipCalculatorViewModel();
                return _instance;
            }
        }

        private TipCalculatorModel _tipModel;

        public TipCalculatorModel TipModel
        {
            get { return _tipModel; }
            set { SetProperty(ref _tipModel, value, nameof(TipModel)); }
        }

        public ICommand CalcularPropinaCommand => new RelayCommand(CalcularPropina);
        public ICommand LimpiarDatosCommand => new RelayCommand(LimpiarDatos);

        public TipCalculatorViewModel()
        {
            _tipModel = new TipCalculatorModel();
            _tipModel.Total = 0;
            _tipModel.NumeroDePersonas = 0;
            _tipModel.Porcentaje = 0;
            _tipModel.Resultado = string.Empty;
        }

        
        public void CalcularPropina()
        {
            double total = _tipModel.Total;
            int numGente = _tipModel.NumeroDePersonas;
            double tipPorcentaje = _tipModel.Porcentaje;

            if (double.TryParse(total.ToString(), out total) &&
                int.TryParse(numGente.ToString(), out numGente))
            {
                double tipCantidad = total * (tipPorcentaje / 100);
                double tipxpersona = tipCantidad / numGente;
                double totalmasTip = total + tipCantidad;
                double totalPorPerson = totalmasTip / numGente;

                _tipModel.Resultado =
                    $"Propina: {tipCantidad:C2}\n" +
                    $"Propina Por Persona: {tipxpersona:C2}\n" +
                    $"Total a Pagar: {totalmasTip:C2}\n" +
                    $"Total por Persona: {totalPorPerson:C2}";
            }
            else
            {
                _tipModel.Resultado = "Por favor, ingrese valores válidos.";
            }

            _tipModel.PorcentajeString = $"Porcentaje: {_tipModel.Porcentaje:F0}%";
            OnPropertyChanged(nameof(TipModel));
        }
       
        public void LimpiarDatos()
        {
            _tipModel.Total = 0;
            _tipModel.Porcentaje = 0;
            _tipModel.NumeroDePersonas = 0;
            _tipModel.Resultado = string.Empty;
            OnPropertyChanged(nameof(TipModel));
        }





    }
}