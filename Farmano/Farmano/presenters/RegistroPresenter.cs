using Farmano.Interfaces;
using Farmano.Models;
using Farmano.Repositories;
using System;
using System.Windows.Forms;

namespace Farmano.Presenters
{
    public class RegistroPresenter
    {
        private IRegistroView view;
        private UsuarioRepository repository;

        public RegistroPresenter(IRegistroView view)
        {
            this.view = view;
            repository = new UsuarioRepository();

            this.view.GuardarEvent += GuardarUsuario;
        }

        private void GuardarUsuario(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Nombre = view.Nombre,
                Apellidos = view.Apellidos,
                Correo = view.Correo,
                Telefono = view.Telefono,
                UsuarioLogin = view.Usuario,
                Contraseña = view.Password,
                
            };

            bool resultado = repository.Registrar(usuario);

            if (resultado)
            {
                MessageBox.Show("Usuario registrado correctamente");

                ((Form)view).Close();
            }
            else
            {
                MessageBox.Show("Error al registrar usuario");
            }
        }

        
    }
}