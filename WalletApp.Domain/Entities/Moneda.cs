using WalletApp.Domain.Entities.NewFolder;

namespace WalletApp.Domain.Entities
{
    public class Moneda : Entidad<short>
    {
        public Moneda()
        {
            this.Guid = Guid.NewGuid();
        }
        #region Atributos
        public Guid Guid { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        #endregion
    }
}
