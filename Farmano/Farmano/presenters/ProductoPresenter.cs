using Farmano.Interfaces;
using Farmano.Models;
using Farmano.Repositories;
using Farmano.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Farmano.Presenters
{
    public class ProductoPresenter
    {
        private IProductoView view;
        private MedicamentoRepository repo;
        private ProductoForm frm;

        public ProductoPresenter(IProductoView view)
        {
            this.view = view;

            repo = new MedicamentoRepository();

            this.view.GuardarEvent += GuardarProducto;
            CargarMedicamentos();

            this.view.BuscarEvent += BuscarProducto;

            this.view.EditarEvent += EditarProducto;

            this.view.EliminarEvent += EliminarProducto;

            this.view.EntradaEvent += EntradaInventario;

            this.view.SalidaEvent += SalidaInventario;
        }
        private void SalidaInventario(object sender,EventArgs e)
        {
            if (repo.SalidaStock(
                view.IdMedicamento,
                view.Cantidad))
            {
                MessageBox.Show(
                    "Stock actualizado");

                CargarMedicamentos();
            }
            else
            {
                MessageBox.Show(
                    "No hay stock suficiente");
            }
        }
        private void EntradaInventario(object sender,EventArgs e)
        {
            if (repo.EntradaStock(
                view.IdMedicamento,
                view.Cantidad))
            {
                MessageBox.Show(
                    "Stock actualizado");

                CargarMedicamentos();
            }
        }

        private void EliminarProducto(object sender,EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                    "¿Desea eliminar este medicamento?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                if (repo.Eliminar(view.IdMedicamento))
                {
                    MessageBox.Show(
                        "Medicamento eliminado");

                    CargarMedicamentos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar");
                }
            }
        }

        private void BuscarProducto(object sender, EventArgs e)
        {
            view.ProductosLista.DataSource = repo.Buscar(view.BuscarTexto);
        }

        private void CargarMedicamentos()
        {
            view.ProductosLista.DataSource = null;
            view.ProductosLista.DataSource = repo.Listar();

            VerificarStockBajo();
        }

        private void GuardarProducto(object sender, EventArgs e)
        {
            MessageBox.Show("Entró al Presenter");

            Medicamento m = new Medicamento()
            {
                Codigo = view.Codigo,
                Nombre = view.Nombre,
                NumeroFabricacion = view.NumeroFabricacion,
                Presentacion = view.Presentacion,
                Stock = view.Stock,
                Precio = view.Precio
            };

            if (repo.Guardar(m))
            {
                MessageBox.Show("Medicamento guardado correctamente");

                CargarMedicamentos();
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
        }



        private void EditarProducto(object sender, EventArgs e)
        {
            Medicamento m =
                new Medicamento()
                {
                    IdMedicamento =
                        view.IdMedicamento,

                    Codigo =
                        view.Codigo,

                    Nombre =
                        view.Nombre,

                    NumeroFabricacion =
                        view.NumeroFabricacion,

                    Presentacion =
                        view.Presentacion,

                        Stock = view.Stock,
                    Precio = view.Precio
                };

            if (repo.Actualizar(m))
            {
                MessageBox.Show(
                    "Medicamento actualizado");
            }
        }

        private void VerificarStockBajo()
        {
            bool hayStockBajo = false;

            foreach (DataGridViewRow fila in view.ProductosLista.Rows)
            {
                if (fila.Cells["Stock"].Value != null)
                {
                    int stock =
                        Convert.ToInt32(
                            fila.Cells["Stock"].Value);

                    if (stock < 10)
                    {
                        fila.DefaultCellStyle.BackColor =
                            Color.LightCoral;

                        fila.DefaultCellStyle.ForeColor =
                            Color.Black;

                        hayStockBajo = true;
                    }
                }
            }

            if (hayStockBajo)
            {
                MessageBox.Show(
                    "Existen medicamentos con stock menor a 10 unidades.",
                    "Alerta de Inventario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        } 
    }
}