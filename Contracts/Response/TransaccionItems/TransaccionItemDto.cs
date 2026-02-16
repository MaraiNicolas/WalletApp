using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.Response.TransaccionItems
{
    public class TransaccionItemDto
    {
        public Guid Guid { get; set; }
        public Guid GuidReferencia { get; set; }
        public int TransaccionId { get; set; }
        public string Referencia1 { get; set; }
        public string Referencia2 { get; set; }

    }
}
