using Farmano.Interfaces;
using Farmano.Interfaz;
using System;
using System.Windows.Forms;
using Farmano.Presenters;

namespace Farmano.Views
{
    public partial class LoginForm :
        Form, ILoginView
    {
        public LoginForm()
        {
            InitializeComponent();

            btnLogin.Click += delegate
            {
                LoginEvent?.Invoke(this, EventArgs.Empty);
            };

            btnRegistro.Click += delegate
            {
                RegistroForm registro =
                new RegistroForm();

                RegistroPresenter presenter =
                new RegistroPresenter(registro);

                registro.ShowDialog();
            };
        }

        public string Usuario
        {
            get { return txtUsuario.Text; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
        }

        public event EventHandler LoginEvent;

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}