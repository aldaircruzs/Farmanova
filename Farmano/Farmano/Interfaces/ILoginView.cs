using System;

namespace Farmano.Interfaz
{
    public interface ILoginView
    {
        string Usuario { get; }
        string Password { get; }

        event EventHandler LoginEvent;
    }
}