using System;
using System.Collections.Generic;
using System.Text;
using WalletApp.Domain.Core.Primitivos;

namespace WalletApp.Domain.Entities
{
    public class TransaccionTipo : Entidad<short>
    {
        public TransaccionTipo()
        {
            
        }
        #region Atributos
        public string Descripcion { get; private set; }
        #endregion
    }
}
