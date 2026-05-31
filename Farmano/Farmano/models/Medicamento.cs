namespace Farmano.Models
{
    public class Medicamento
    {
        public int IdMedicamento { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string NumeroFabricacion { get; set; }

        public string Presentacion { get; set; }

        public int Stock { get; set; }

        public decimal Precio { get; set; }
    }
}