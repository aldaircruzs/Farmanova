using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmano.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nombre { get; set; } 

        public string UsuarioLogin { get; set; }

        public string Password { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Apellidos { get; set; }
        public string Contraseña { get; internal set; }
    }
}
