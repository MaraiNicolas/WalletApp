using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Request.Usuarios
{
    public class UsuarioModificarRequest
    {
        public Guid Guid { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroDoc { get;  set; }
        public string Email { get;  set; }
        public string Password { get;  set; }
    }
}
