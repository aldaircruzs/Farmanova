using System;
using System.Windows.Forms;

namespace Farmano.Interfaces
{
    public interface IProveedorView
    {
        int IdProveedor { get; set; }

        string Nombre { get; }

        string Direccion { get; }

        string NumeroTelefono { get; }

        string NumeroCertificacion { get; }

        string CP { get; }

        string RFC { get; }

        string BuscarTexto { get; }

        DataGridView ProveedoresLista { get; }

        event EventHandler GuardarEvent;

        event EventHandler EditarEvent;

        event EventHandler EliminarEvent;

        event EventHandler BuscarEvent;
    }
}