using Farmano.Presenters;
using System;
using System.Windows.Forms;

namespace Farmano.Views
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.pnlUsuarios.Click += new System.EventHandler(this.pnlUsuarios_Click);

            this.pnlClientes.Click += new System.EventHandler(this.pnlClientes_Click);

            this.pnlProveedores.Click += new System.EventHandler(this.pnlProveedores_Click);

            this.pnlProducto.Click += new System.EventHandler(this.pnlProducto_Click);

            this.pnlInventario.Click += new System.EventHandler(this.pnlInventario_Click);

            this.pnlVentas.Click += new System.EventHandler(this.pnlVentas_Click);

            this.pnlReportes.Click += new System.EventHandler(this.pnlReportes_Click);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        // ==========================
        // PRODUCTOS
        // ==========================
        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductoForm frm = new ProductoForm();

            ProductoPresenter presenter =
                new ProductoPresenter(frm);

            frm.ShowDialog();
        }

        // ==========================
        // CLIENTES
        // ==========================
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ClienteForm frm = new ClienteForm();

            ClientePresenter presenter =
                new ClientePresenter(frm);

            frm.ShowDialog();
        }

        // ==========================
        // PROVEEDORES
        // ==========================
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            ProveedorForm frm =
                new ProveedorForm();

            frm.ShowDialog();
        }

        // ==========================
        // TARJETA USUARIOS
        // ==========================
        private void pnlUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Módulo Usuarios en construcción");
        }

        // ==========================
        // TARJETA CLIENTES
        // ==========================
        private void pnlClientes_Click(object sender, EventArgs e)
        {
            ClienteForm frm = new ClienteForm();

            ClientePresenter presenter =
                new ClientePresenter(frm);

            frm.ShowDialog();
        }

        // ==========================
        // TARJETA PROVEEDORES
        // ==========================
        private void pnlProveedores_Click(object sender, EventArgs e)
        {
            ProveedorForm frm =
                new ProveedorForm();

            ProveedorPresenter presenter =
                new ProveedorPresenter(frm);

            frm.ShowDialog();
        }

        // ==========================
        // TARJETA PRODUCTOS
        // ==========================
        private void pnlProducto_Click(object sender, EventArgs e)
        {
            ProductoForm frm =
                new ProductoForm();

            ProductoPresenter presenter =
                new ProductoPresenter(frm);

            frm.ShowDialog();
        }

        // ==========================
        // TARJETA INVENTARIO
        // ==========================
        private void pnlInventario_Click(object sender, EventArgs e)
        {
            InventarioForm frm =
        new InventarioForm();

            InventarioPresenter presenter =
                new InventarioPresenter(frm);

            frm.ShowDialog();
        }

        // ==========================
        // TARJETA VENTAS
        // ==========================
        private void pnlVentas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ventas en construcción");
        }

        // ==========================
        // TARJETA REPORTES
        // ==========================
        private void pnlReportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Reportes en construcción");
        }

        private void panelMenu_Paint(
            object sender,
            PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(
            object sender,
            EventArgs e)
        {

        }

        private void pnlUsuarios_Paint(
            object sender,
            PaintEventArgs e)
        {
            UsuariosForm frm =
       new UsuariosForm();

            frm.ShowDialog();
        }

        private void pnlClientes_Paint(
            object sender,
            PaintEventArgs e)
        {
            ClienteForm frm =
        new ClienteForm();

            ClientePresenter presenter =
                new ClientePresenter(frm);

            frm.ShowDialog();
        }

        private void label4_Click(
            object sender,
            EventArgs e)
        {

        }

        private void pnlProducto_Paint(
    object sender,
    PaintEventArgs e)
        {
        }
        private void pnlProveedores_Paint(object sender, PaintEventArgs e)
        {
            ProveedorForm frm =
      new ProveedorForm();

            frm.ShowDialog();
        }
    }
}