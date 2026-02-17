using WalletApp.Domain.Core.Primitivos;

namespace WalletApp.Domain.Entities
{
    public class Transaccion : Entidad<long>
    {
        public Transaccion()
        {
            this.Guid = Guid.NewGuid();
            this.FechaAlta = DateTime.Now;
            this.FechaModificacion = new DateTime(1900, 1, 1);
        }
        #region Atributos
        public Guid Guid { get; private set; }
        public string Descripcion { get; private set; }
        public decimal Importe { get; private set; }
        public short TransaccionTipoId { get; private set; }
        public short MonedaId { get; private set; } 
        #endregion
        #region AtributosRelacionales
        public TransaccionTipo TransaccionTipo { get; private set; }
        public Moneda Moneda { get; private set; }
        #endregion
        #region Metodos
        public static Transaccion Create(string descripcion, decimal importe, short tipoTransaccionId, short monedaId)
        {
            Transaccion rNew =new Transaccion();
            rNew.Descripcion = descripcion;
            rNew.Importe = importe;
            rNew.TransaccionTipoId = tipoTransaccionId;
            rNew.MonedaId = monedaId;
            return rNew;
        }
        #endregion

    }
}
