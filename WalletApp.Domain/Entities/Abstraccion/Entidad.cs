namespace WalletApp.Domain.Entities.NewFolder
{
    public class Entidad<T>
    {
        public T Id { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
