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

            MessageBox.Show("Formulario creado");

            btnGuardar.Click += delegate
            {
                GuardarEvent?.Invoke(
                    this,
                    EventArgs.Empty);
            };
        }

        public string BuscarTexto
        {
            get { return txtBuscar.Text; }
        }

        public event EventHandler BuscarEvent;



        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
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
            dgvProductos.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;

            dgvProductos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProductos.MultiSelect = false;

            dgvProductos.ReadOnly = true;

            dgvProductos.RowHeadersVisible = false;

            dgvProductos.AllowUserToAddRows = false;
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

        public event EventHandler ProductosEvent;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
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
                int stock;
                return int.TryParse(txtStock.Text, out stock) ? stock : -1;
            }
        }

        public decimal Precio
        {
            get
            {
                decimal precio;
                return decimal.TryParse(txtPrecio.Text, out precio) ? precio : -1;
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
                return int.TryParse(txtCantidad.Text, out cantidad) ? cantidad : 0;
            }
        }

        public event EventHandler EntradaEvent;

        public event EventHandler SalidaEvent;
        public event EventHandler EditarEvent;

        event EventHandler IProductoView.EditarEvent
        {
            add { EditarEvent += value; }
            remove { EditarEvent -= value; }
        }

        public event EventHandler NuevoEvent;
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtFabricacion.Clear();
            txtPresentacion.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();

            IdMedicamento = 0;

            txtCodigo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarEvent?.Invoke(
       this,
       EventArgs.Empty);
        }

        void IProductoView.LimpiarCampos()
        {
            LimpiarCampos();
        }
    }
}
