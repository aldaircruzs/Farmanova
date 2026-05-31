using Farmano.Interfaces;
using Farmano.Models;
using Farmano.Repositories;
using Farmano.Views;
using System;
using System.Windows.Forms;

namespace Farmano.Presenters
{
    public class ClientePresenter
    {
        private IClienteView view;
        private ClienteRepository repo;
        private ClienteForm frm;

        public ClientePresenter(IClienteView view)
        {
            this.view = view;

            repo = new ClienteRepository();

            view.GuardarEvent += GuardarCliente;
            view.EliminarEvent += EliminarCliente;

            CargarClientes();
        }

        public ClientePresenter(ClienteForm frm)
        {
            this.frm = frm;
        }

        private void GuardarCliente(
            object sender,
            EventArgs e)
        {
            Cliente c = new Cliente()
            {
                NumeroCliente =
                    view.NumeroCliente,

                Nombre =
                    view.Nombre,

                Apellido =
                    view.Apellido,

                CorreoElectronico =
                    view.CorreoElectronico,

                Telefono =
                    view.Telefono
            };

            if (repo.Guardar(c))
            {
                MessageBox.Show(
                    "Cliente guardado");

                CargarClientes();
            }
        }

        private void EliminarCliente(
            object sender,
            EventArgs e)
        {
            if (repo.Eliminar(view.IdCliente))
            {
                MessageBox.Show(
                    "Cliente eliminado");

                CargarClientes();
            }
        }

        private void CargarClientes()
        {
            view.ClientesLista.DataSource = null;
            view.ClientesLista.DataSource = repo.Listar();
        }
    }
}