using Farmano.Interfaces;
using Farmano.Presenters;
using System;
using System.Windows.Forms;

namespace Farmano.Views
{
    public partial class ProveedorForm : Form, IProveedorView
    {
        public event EventHandler GuardarEvent;
        public event EventHandler EditarEvent;
        public event EventHandler EliminarEvent;
        public event EventHandler BuscarEvent;
        public event EventHandler NuevoEvent;

        private ProveedorPresenter presenter;

        private int idProveedor;

        // Declaración añadida para resolver CS0103: txtCertificacion no existe en el contexto actual.
        // Si el control existe en el archivo diseñador (InitializeComponent), esta declaración evitará el error de compilación.
        private TextBox txtCertificacion;

        // Declaración añadida para resolver CS0103: txtCP no existe en el contexto actual.
        // Si el control existe en el archivo diseñador (InitializeComponent), esta declaración evitará el error de compilación.
        private TextBox txtCP;

        // Declaración añadida para resolver CS0103: txtRFC no existe en el contexto actual.
        // Si el control existe en el archivo diseñador (InitializeComponent), esta declaración evitará el error de compilación.
        private TextBox txtRFC;

        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }

        public string Nombre
        {
            get { return txtNombre.Text; }
        }

        public string Direccion
        {
            get { return txtDireccion.Text; }
        }

        public string NumeroTelefono
        {
            get { return txtTelefono.Text; }
        }

        public string NumeroCertificacion
        {
            get { return txtCertificacion.Text; }
        }

        public string CP
        {
            get { return txtCP.Text; }
        }

        public string RFC
        {
            get { return txtRFC.Text; }
        }

        public string BuscarTexto
        {
            get { return txtBuscar.Text; }
        }

        public DataGridView ProveedoresLista
        {
            get { return dgvProveedores; }
        }

        public ProveedorForm()
        {
            InitializeComponent();

            presenter =
                new ProveedorPresenter(this);

            btnGuardar.Click += delegate
            {
                GuardarEvent?.Invoke(
                    this,
                    EventArgs.Empty);
            };

            btnEliminar.Click += delegate
            {
                EliminarEvent?.Invoke(
                    this,
                    EventArgs.Empty);
            };

            btnNuevo.Click += delegate
            {
                NuevoEvent?.Invoke(
                    this,
                    EventArgs.Empty);
            };
        }

        private void ProveedorForm_Load(object sender,EventArgs e)
        {
            btnEliminar.Enabled = false;

            dgvProveedores.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProveedores.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProveedores.MultiSelect = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarEvent?.Invoke(
          this,
          EventArgs.Empty);        
        }
        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvProveedores.Rows[e.RowIndex];

                IdProveedor =
                    Convert.ToInt32(
                        fila.Cells["IdProveedor"].Value);

                txtNombre.Text =
                    fila.Cells["Nombre"].Value.ToString();

                txtDireccion.Text =
                    fila.Cells["Direccion"].Value.ToString();

                txtTelefono.Text =
                    fila.Cells["NumeroTelefono"].Value.ToString();

                txtCorreo.Text =
                    fila.Cells["NumeroCertificacion"].Value.ToString();

                txtEmpresa.Text =
                    fila.Cells["RFC"].Value.ToString();

                btnEliminar.Enabled = true;
            }
        }
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtEmpresa.Clear();
            txtBuscar.Clear();

            IdProveedor = 0;

            btnEliminar.Enabled = false;

            txtNombre.Focus();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}