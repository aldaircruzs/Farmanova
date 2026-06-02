using Farmano.Interfaz;
using Farmano.Repositories;
using System;
using Farmano.Views;
using System.Windows.Forms;

namespace Farmano.Presenters
{
    public class LoginPresenter
    {
        private ILoginView view;
        private UsuarioRepository repository;

        public LoginPresenter(ILoginView view)
        {
            this.view = view;

            repository = new UsuarioRepository();

            this.view.LoginEvent += LoginUsuario;
        }

        private void LoginUsuario(
            object sender,
            EventArgs e)
        {
            var usuario =
                repository.Login(
                    view.Usuario,
                    view.Password);

            if (usuario != null)
            {

                DashboardForm dashboard =
                    new DashboardForm();

                ((Form)view).Hide();

                dashboard.ShowDialog();

                ((Form)view).Show();
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos");
            }
        }
    }
}