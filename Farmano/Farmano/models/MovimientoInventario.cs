using System;

namespace Farmano.Models
{
    public class MovimientoInventario
    {
        public int IdMovimiento { get; set; }

        public int IdMedicamento { get; set; }

        public string Medicamento { get; set; }

        public string TipoMovimiento { get; set; }

        public int Cantidad { get; set; }

        public DateTime Fecha { get; set; }
    }
}