using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TipCalculator.Models;
using System.Windows.Input;

namespace TipCalculator.ViewModels
{
    
    public class AportacionViewModel : ObservableObject
    {
        private static AportacionViewModel _instance;

        public static AportacionViewModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AportacionViewModel();
                return _instance;
            }
        }

        private AportacionModel _aportacionModel;

        public AportacionModel AportacionModel
        {
            get { return _aportacionModel; }
            set { SetProperty(ref _aportacionModel, value, nameof(AportacionModel)); }
        }

        public ICommand CalcularAportacionCommand => new RelayCommand(CalcularAportacion);
        public ICommand LimpiarDatosCommand => new RelayCommand(LimpiarDatos);

        public AportacionViewModel()
        {
            _aportacionModel = new AportacionModel();
            _aportacionModel.NumberDeContribuyentes = 1;
            _aportacionModel.CantidadAportacion = 0;
            _aportacionModel.TotalContribucion = 0;
            _aportacionModel.Cambio = 0;
            _aportacionModel.Total = string.Empty;
        }

        public void CalcularAportacion()
        {
            int numeroDeContribuyentes = _aportacionModel.NumberDeContribuyentes;
            decimal cantidadAportacion = _aportacionModel.CantidadAportacion;

            if (numeroDeContribuyentes > 0 && cantidadAportacion >= 0)
            {
                _aportacionModel.TotalContribucion = numeroDeContribuyentes * cantidadAportacion;
                _aportacionModel.Total =
                    $"Total a Aportar: {_aportacionModel.TotalContribucion:C2}\n";
            }
            else
            {
                _aportacionModel.Total = "Por favor, ingrese valores válidos.";
            }

            OnPropertyChanged(nameof(AportacionModel));
        }

        public void LimpiarDatos()
        {
            _aportacionModel.NumberDeContribuyentes = 1;
            _aportacionModel.CantidadAportacion = 0;
            _aportacionModel.TotalContribucion = 0;
            _aportacionModel.Cambio = 0;
            _aportacionModel.Total = string.Empty;
            OnPropertyChanged(nameof(AportacionModel));
        }
    }

}
