using System;
using System.Windows.Forms;

namespace Farmano.Interfaces
{
    
    public interface IProductoView
    {
        DataGridView ProductosLista { get; }

        string BuscarTexto { get; }

        event EventHandler BuscarEvent;
        event EventHandler ProductosEvent;
        int IdMedicamento { get; set; }

        event EventHandler EditarEvent;

        string Codigo { get; }

        string Nombre { get; }

        string NumeroFabricacion { get; }

        string Presentacion { get; }

        int Stock { get; }

        decimal Precio { get; }

        int Cantidad { get; }

        event EventHandler GuardarEvent;
        event EventHandler EliminarEvent;
        event EventHandler EntradaEvent;
        event EventHandler SalidaEvent;
    }
}