using WalletApp.Domain.Entities.NewFolder;

namespace WalletApp.Domain.Entities
{
    public class Transaccion : Entidad<long>
    {
        public Transaccion()
        {
            this.Guid = Guid.NewGuid();
        }
        #region Atributos
        public Guid Guid { get; set; }
        public string Descripcion { get; set; }
        public decimal Importe { get; set; }
        public short TransaccionTipoId { get; set; }
        public short MonedaId { get; set; } 
        #endregion
        #region AtributosRelacionales
        public TransaccionTipo TransaccionTipo { get; set; }
        public Moneda Moneda { get; set; }
        #endregion
        #region Metodos
        #endregion

    }
}
