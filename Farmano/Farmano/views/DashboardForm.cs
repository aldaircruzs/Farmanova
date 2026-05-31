using Farmano.Presenters;
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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductoForm frm =  new ProductoForm();

            //Aqui se crea el Presenter y se conecta con la vista
            ProductoPresenter presenter = new ProductoPresenter(frm);

            frm.ShowDialog();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

            private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ClienteForm frm = new ClienteForm();

            ClientePresenter presenter =
                new ClientePresenter(frm);

            frm.ShowDialog();
        }
    }

}

