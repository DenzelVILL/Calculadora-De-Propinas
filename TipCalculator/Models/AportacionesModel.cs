using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace TipCalculator.Models
{
    public class AportacionModel
    {
        public int NumberDeContribuyentes { get; set; }
        public decimal CantidadAportacion { get; set; }
        public decimal TotalContribucion { get; set; }
        public decimal Cambio { get; set; }
        public string Total { get; set; }

    }

    
}
