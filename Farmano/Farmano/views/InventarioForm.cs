using Farmano.Interfaces;
using System;
using System.Windows.Forms;

namespace Farmano.Views
{
    public partial class InventarioForm :
        Form,
        IInventarioView
    {
        public InventarioForm()
        {
            InitializeComponent();

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

        public event EventHandler EntradaEvent;
        public event EventHandler SalidaEvent;

        public int IdMedicamento
        {
            get
            {
                if (cmbMedicamento.SelectedValue == null)
                    return 0;

                return Convert.ToInt32(
                    cmbMedicamento.SelectedValue);
            }
        }

        public int Cantidad
        {
            get
            {
                int cantidad;

                if (!int.TryParse(
                    txtCantidad.Text,
                    out cantidad))
                {
                    return 0;
                }

                return cantidad;
            }
        }

        public DataGridView MovimientosLista
        {
            get { return dgvMovimientos; }
        }

        public ComboBox MedicamentosCombo
        {
            get { return cmbMedicamento; }
        }

        private void InventarioForm_Load(
            object sender,
            EventArgs e)
        {
            dgvMovimientos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvMovimientos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvMovimientos.MultiSelect = false;

            dgvMovimientos.ReadOnly = true;

            dgvMovimientos.RowHeadersVisible = false;

            dgvMovimientos.AllowUserToAddRows = false;
        }

        private void cmbMedicamento_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }
    }
}