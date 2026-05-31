using System;

namespace Farmano.Interfaces
{
    public interface IRegistroView
    {
        string Nombre { get; }

        string Apellidos { get; }

        string Correo { get; }

        string Telefono { get; }

        string Usuario { get; }

        string Password { get; }


        event EventHandler GuardarEvent;
         
            

    }
}