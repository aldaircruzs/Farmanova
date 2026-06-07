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
            this.view.EliminarEvent += EliminarProveedor;
            this.view.BuscarEvent += BuscarProveedor;
            this.view.NuevoEvent += NuevoProveedor;


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
                IdProveedor = view.IdProveedor,
                Nombre = view.Nombre,
                Direccion = view.Direccion,
                NumeroTelefono = view.NumeroTelefono,
                NumeroCertificacion = view.NumeroCertificacion,
                CP = view.CP,
                RFC = view.RFC
            };

            bool resultado;

            if (view.IdProveedor == 0)
            {
                resultado = repo.Guardar(p);

                if (resultado)
                {
                    MessageBox.Show(
                        "Proveedor registrado correctamente");
                }
            }
            else
            {
                resultado = repo.Actualizar(p);

                if (resultado)
                {
                    MessageBox.Show(
                        "Proveedor actualizado correctamente");
                }
            }

            if (resultado)
            {
                CargarProveedores();
                view.LimpiarCampos();
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

        // Añadido: manejador para el evento NuevoEvent
        private void NuevoProveedor(object sender,EventArgs e)
        {
            view.LimpiarCampos();
        }
    }
}