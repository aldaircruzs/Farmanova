using System;
using System.Windows.Forms;

namespace Farmano.Interfaces
{
    public interface IClienteView
    {
        int IdCliente { get; set; }

        int NumeroCliente { get; }

        string Nombre { get; }

        string Apellido { get; }

        string CorreoElectronico { get; }

        string Telefono { get; }

        string BuscarTexto { get; }

        DataGridView ClientesLista { get; }

        event EventHandler GuardarEvent;
        event EventHandler EditarEvent;
        event EventHandler EliminarEvent;
        event EventHandler BuscarEvent;
    }
}