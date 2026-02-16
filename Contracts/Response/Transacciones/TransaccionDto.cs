using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Response.Transacciones
{
    public class TransaccionDto
    {
        public Guid Guid { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }
        public string TransaccionTipo { get; set; }
        public string Moneda { get; set; }

    }
}
