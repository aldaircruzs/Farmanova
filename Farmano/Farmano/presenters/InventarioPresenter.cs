using Farmano.Interfaces;
using Farmano.Repositories;
using System;
using System.Windows.Forms;

namespace Farmano.Presenters
{
    public class InventarioPresenter
    {
        private IInventarioView view;
        private InventarioRepository repo;
        private MedicamentoRepository medicamentoRepo;

        public InventarioPresenter(IInventarioView view)
        {
            this.view = view;

            repo = new InventarioRepository();
            medicamentoRepo = new MedicamentoRepository();

            this.view.EntradaEvent += Entrada;
            this.view.SalidaEvent += Salida;

            CargarMedicamentos();
            CargarMovimientos();
        }

        private void CargarMovimientos()
        {
            view.MovimientosLista.DataSource =
                repo.ListarMovimientos();
        }

        private void CargarMedicamentos()
        {
            view.MedicamentosCombo.DataSource =
        medicamentoRepo.Listar();

            view.MedicamentosCombo.DisplayMember =
                "Nombre";

            view.MedicamentosCombo.ValueMember =
                "IdMedicamento";
        }

        private void Entrada(
            object sender,
            EventArgs e)
        {
            if (repo.RegistrarEntrada(
                view.IdMedicamento,
                view.Cantidad))
            {
                MessageBox.Show(
                    "Entrada registrada");

                CargarMovimientos();
            }
        }

        private void Salida(
            object sender,
            EventArgs e)
        {
            if (repo.RegistrarSalida(
                view.IdMedicamento,
                view.Cantidad))
            {
                MessageBox.Show(
                    "Salida registrada");

                CargarMovimientos();
            }
            else
            {
                MessageBox.Show(
                    "Stock insuficiente");
            }
        }
    }
}