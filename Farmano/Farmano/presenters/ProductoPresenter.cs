using Farmano.Interfaces;
using Farmano.Models;
using Farmano.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Farmano.Presenters
{
    public class ProductoPresenter
    {
        private IProductoView view;
        private MedicamentoRepository repo;
        private bool hayStockBajo;

        public ProductoPresenter(IProductoView view)
        {
            this.view = view;

            repo = new MedicamentoRepository();

            this.view.GuardarEvent += GuardarProducto;
            CargarMedicamentos();

            this.view.BuscarEvent += BuscarProducto;

            this.view.EliminarEvent += EliminarProducto;

            this.view.EntradaEvent += EntradaInventario;

            this.view.SalidaEvent += SalidaInventario;
            this.view.NuevoEvent += NuevoProducto;

        }
        private void SalidaInventario(object sender,EventArgs e)
        {
            if (!ValidarSeleccion())
            {
                return;
            }

            if (!ValidarCantidad())
            {
                return;
            }

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
            if (!ValidarSeleccion())
            {
                return;
            }

            if (!ValidarCantidad())
            {
                return;
            }

            if (repo.EntradaStock(
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
                    "No se pudo actualizar el stock");
            }
        }

        private void EliminarProducto(object sender,EventArgs e)
        {
            if (!ValidarSeleccion())
            {
                return;
            }

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
            Medicamento m = new Medicamento()
            {
                IdMedicamento = view.IdMedicamento,
                Codigo = view.Codigo,
                Nombre = view.Nombre,
                NumeroFabricacion = view.NumeroFabricacion,
                Presentacion = view.Presentacion,
                Stock = view.Stock,
                Precio = view.Precio
            };

            bool resultado;

            if (view.IdMedicamento == 0)
            {
                resultado = repo.Guardar(m);

                if (resultado)
                {
                    MessageBox.Show(
                        "Medicamento registrado correctamente");
                }
            }
            else
            {
                resultado = repo.Actualizar(m);

                if (resultado)
                {
                    MessageBox.Show(
                        "Medicamento actualizado correctamente");
                }
            }

            if (resultado)
            {
                CargarMedicamentos();
            }
        }
           private void VerificarStockBajo()
        {
            hayStockBajo = false;

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
                    else if (stock < 30)
                    {
                        fila.DefaultCellStyle.BackColor =
                            Color.Khaki;

                        fila.DefaultCellStyle.ForeColor =
                            Color.Black;
                    }
                    else
                    {
                        fila.DefaultCellStyle.BackColor =
                            Color.LightGreen;

                        fila.DefaultCellStyle.ForeColor =
                            Color.Black;
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
        private bool ValidarSeleccion()
        {
            // Asume que IdMedicamento es 0 cuando no hay selección
            if (view.IdMedicamento <= 0)
            {
                MessageBox.Show("Seleccione un medicamento.");
                return false;
            }
            return true;
        }

        private bool ValidarCantidad()
        {
            // Asume que Cantidad es un valor numérico (int/decimal) proporcionado por la vista
            if (view.Cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida (mayor que 0).");
                return false;
            }
            return true;
        }
        private void NuevoProducto( object sender,EventArgs e)
        {
            view.LimpiarCampos();
        }
    }
}
