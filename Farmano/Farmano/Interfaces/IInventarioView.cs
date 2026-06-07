using System;
using System.Windows.Forms;

namespace Farmano.Interfaces
{
    public interface IInventarioView
    {
        int IdMedicamento { get; }

        int Cantidad { get; }

        DataGridView MovimientosLista { get; }

        event EventHandler EntradaEvent;

        event EventHandler SalidaEvent;

        ComboBox MedicamentosCombo { get; }
    }
}