using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        public double Total { get; set; }
        public int NumeroDePersonas { get; set; }
        public double Porcentaje { get; set; }
        public string PorcentajeString { get; set; }
        public string Resultado { get; set; }

    }
}
