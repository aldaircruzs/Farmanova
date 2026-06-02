using Farmano.Interfaces;
using Farmano.Models;
using Farmano.Repositories;
using System;
using System.Windows.Forms;

namespace Farmano.Presenters
{
    public class ProveedorPresenter
    {
        private IProveedorView view;
        private ProveedorRepository repo;

        public ProveedorPresenter(IProveedorView view)
        {
            this.view = view;

            repo = new ProveedorRepository();

            this.view.GuardarEvent += GuardarProveedor;
            this.view.EditarEvent += EditarProveedor;
            this.view.EliminarEvent += EliminarProveedor;
            this.view.BuscarEvent += BuscarProveedor;

            CargarProveedores();
        }

        private void CargarProveedores()
        {
            view.ProveedoresLista.DataSource = null;
            view.ProveedoresLista.DataSource = repo.Listar();
        }

        private void GuardarProveedor(
            object sender,
            EventArgs e)
        {
            Proveedor p = new Proveedor()
            {
                Nombre = view.Nombre,
                Direccion = view.Direccion,
                NumeroTelefono = view.NumeroTelefono,
                NumeroCertificacion = view.NumeroCertificacion,
                CP = view.CP,
                RFC = view.RFC
            };

            if (repo.Guardar(p))
            {
                MessageBox.Show(
                    "Proveedor guardado correctamente");

                CargarProveedores();
            }
            else
            {
                MessageBox.Show(
                    "Error al guardar proveedor");
            }
        }

        private void EditarProveedor(
            object sender,
            EventArgs e)
        {
            Proveedor p = new Proveedor()
            {
                IdProveedor = view.IdProveedor,
                Nombre = view.Nombre,
                Direccion = view.Direccion,
                NumeroTelefono = view.NumeroTelefono,
                NumeroCertificacion = view.NumeroCertificacion,
                CP = view.CP,
                RFC = view.RFC
            };

            if (repo.Actualizar(p))
            {
                MessageBox.Show(
                    "Proveedor actualizado");

                CargarProveedores();
            }
        }

        private void EliminarProveedor(
            object sender,
            EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                    "¿Desea eliminar este proveedor?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (repo.Eliminar(view.IdProveedor))
                {
                    MessageBox.Show(
                        "Proveedor eliminado");

                    CargarProveedores();
                }
            }
        }

        private void BuscarProveedor(
            object sender,
            EventArgs e)
        {
            view.ProveedoresLista.DataSource =
                repo.Buscar(view.BuscarTexto);
        }
    }
}