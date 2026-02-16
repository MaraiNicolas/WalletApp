using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Response.Monedas
{
    public class MonedaDto
    {
        public Guid Guid { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
    }
}
