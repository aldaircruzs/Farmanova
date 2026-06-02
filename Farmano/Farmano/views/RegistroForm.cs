using Farmano.Interfaces;
using System;
using System.Windows.Forms;

namespace Farmano.Views
{
    public partial class RegistroForm :
        Form, IRegistroView
    {
        public RegistroForm()
        {
            InitializeComponent();

            btnRegistrar.Click += delegate
            {
                GuardarEvent?.Invoke(
                    this,
                    EventArgs.Empty
                );
            };
        }

        public string Nombre
        {
            get { return txtNombre.Text; }
        }

        public string Apellidos
        {
            get { return txtApellidos.Text; }
        }

        public string Correo
        {
            get { return txtCorreo.Text; }
        }

        public string Telefono
        {
            get { return txtTelefono.Text; }
        }

        public string Usuario
        {
            get { return txtUsuario.Text; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
        }

        public event EventHandler GuardarEvent;


        private void RegistroForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

      
    }
}