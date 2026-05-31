using Farmano.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmano.Views
{
    public partial class ProductoForm : Form, IProductoView
    {
        // Evento público para notificar guardado desde la vista
        public event EventHandler GuardarEvent;

        public event EventHandler EliminarEvent;

        public ProductoForm()
        {
            InitializeComponent();
            btnGuardar.Click += delegate
            {
                GuardarEvent?.Invoke(
                    this,
                    EventArgs.Empty);
            };

            btnBuscar.Click += delegate
            {
                BuscarEvent?.Invoke(
                    this,
                    EventArgs.Empty);
            };

            btnEditar.Click += delegate
            {
                EditarEvent?.Invoke(
                    this,
                    EventArgs.Empty);
            };
            btnEliminar.Click += delegate
            {
                EliminarEvent?.Invoke(
                    this,
                    EventArgs.Empty);
            };

            btnEntrada.Click += delegate
            {
                EntradaEvent?.Invoke(
                    this,
                    EventArgs.Empty);
            };

            btnSalida.Click += delegate
            {
                SalidaEvent?.Invoke(
                    this,
                    EventArgs.Empty);
            };
        }

        public string BuscarTexto
        {
            get { return txtBuscar.Text; }
        }

        public event EventHandler BuscarEvent;



        private void dgvProductos_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvProductos.Rows[e.RowIndex];

                idMedicamento =
                    Convert.ToInt32(
                        fila.Cells["IdMedicamento"].Value);

                txtCodigo.Text =
                    fila.Cells["Codigo"].Value.ToString();

                txtNombre.Text =
                    fila.Cells["Nombre"].Value.ToString();

                txtFabricacion.Text =
                    fila.Cells["NumeroFabricacion"].Value.ToString();

                txtPresentacion.Text =
                    fila.Cells["Presentacion"].Value.ToString();
                txtStock.Text =
                    fila.Cells["Stock"].Value.ToString();
                txtPrecio.Text =
                    fila.Cells["Precio"].Value.ToString();
            }
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {

        }
        public DataGridView ProductosLista
        {
            get { return dgvProductos; }
        }

        
        private int idMedicamento;

        public int IdMedicamento
        {
            get { return idMedicamento; }
            set { idMedicamento = value; }
        }

        public string Codigo
        {
            get { return txtCodigo.Text; }
        }

        public string Nombre
        {
            get { return txtNombre.Text; }
        }

        public string NumeroFabricacion
        {
            get { return txtFabricacion.Text; }
        }

        public string Presentacion
        {
            get { return txtPresentacion.Text; }

        }

        public string StockText
        {
            get { return txtStock.Text; }
        }

        public string PrecioText
        {
            get { return txtPrecio.Text; }
        }

        public event EventHandler EditarEvent;
        public event EventHandler ProductosEvent;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón Guardar presionado");
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        public int Stock
        {
            get
            {
                MessageBox.Show("Texto Stock = " + txtStock.Text);
                int stock;
                int.TryParse(txtStock.Text, out stock);
                return stock;
            }
        }

        public decimal Precio
        {
            get
            {
                decimal precio;
                decimal.TryParse(txtPrecio.Text, out precio);
                return precio;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public int Cantidad
        {
            get
            {
                int cantidad;
                int.TryParse(txtCantidad.Text, out cantidad);
                return cantidad;
            }
        }

        public event EventHandler EntradaEvent;

        public event EventHandler SalidaEvent;
    }
}
