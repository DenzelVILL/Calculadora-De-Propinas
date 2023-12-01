namespace TipCalculator.Views
{
    public partial class TipCalculatorPage : ContentPage
    {
        public TipCalculatorPage()
        {
            InitializeComponent();
        }

        private void CalcularPropina(object sender, EventArgs e)
        {
            if (double.TryParse(totaltip.Text, out double total) &&
                int.TryParse(NumPersona.Text, out int numGente))
            {
                double tipPorcentaje = barraporcentaje.Value;
                double tipCantidad = total * (tipPorcentaje / 100);
                double tipxpersona = tipCantidad / numGente;
                double totalmasTip = total + tipCantidad;
                double totalPorPerson = totalmasTip / numGente;

                resultLabel.Text =
                    $"Propina: {tipCantidad:C2}\n" +
                    $"Propina Por Persona: {tipxpersona:C2}\n" +
                    $"Total a Pagar: {totalmasTip:C2}\n" +
                    $"Total por Persona: {totalPorPerson:C2}";
            }

            else
            {
                resultLabel.Text = "Por favor, ingrese valores válidos.";
            }


        }
        private void LimpiarDatos(object sender, EventArgs e)
        {


        }
    }
}