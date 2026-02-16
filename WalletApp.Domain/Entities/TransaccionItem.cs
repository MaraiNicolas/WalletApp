using System;
using System.Collections.Generic;
using System.Text;
using WalletApp.Domain.Entities.NewFolder;

namespace WalletApp.Domain.Entities
{
    public class TransaccionItem : Entidad<int>
    {
        public TransaccionItem()
        {
            this.Guid = Guid.NewGuid();
        }
        #region Atributos
        public Guid Guid { get; private set; }
        public Guid GuidReferencia { get; private set; }
        public int TransaccionId { get; private set; }
        public string Referencia1 { get; private set; }
        public string Referencia2 { get; private set; } 
        #endregion
        #region Metodos
        #endregion
    }
}
