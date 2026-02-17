using WalletApp.Domain.Core.Primitivos;

namespace WalletApp.Domain.Entities
{
    public class Moneda : Entidad<short>
    {
        public Moneda()
        {
            this.Guid = Guid.NewGuid();
        }
        #region Atributos
        public Guid Guid { get; private set; }
        public string Nombre { get; private set; }
        public string NombreCorto { get; private set; }
        #endregion
        #region Metodos
        public static Moneda Create(string nombre, string nombreCorto) 
        {
            Moneda rNew = new Moneda();
            rNew.Nombre = nombre;
            rNew.NombreCorto = nombreCorto;
            return rNew;
        }
        #endregion
    }
}
