namespace WalletApp.Domain.Core.Primitivos
{
    public abstract class Entidad<T> : IEquatable<Entidad<T>>
    {
        public T Id { get; private set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaAlta { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity"/> class.
        /// </summary>
        /// <param name="id">The entity identifier.</param>
        protected Entidad(T id) : this()
        {
            Id = id ?? default;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity"/> class.
        /// </summary>
        /// <remarks>
        /// Required by EF Core.
        /// </remarks>
        protected Entidad()
        {
        }

        public static bool operator ==(Entidad<T> left, Entidad<T> right)
        {
            if (left is null && right is null)
                return true;
            if (left is null || right is null)
                return false;
            return left.Equals(right);
        }
        public static bool operator !=(Entidad<T> left, Entidad<T> right) => !(left == right);

        public bool Equals(Entidad<T>? other)
        {
            if(other is null)
            {
                return false;
            }
            return ReferenceEquals(this, other) || Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if(obj is null)
            {
                return false;
            }
            if(ReferenceEquals(this, obj))
            {
                return true;
            }
            if(obj.GetType()!= GetType())
            {
                return false;
            }
            if(!(obj is Entidad<T> other))
            {
                return false;
            }
            return Id.Equals(other.Id);
        }

        ///<inheritdoc/>
        public override int GetHashCode() => Id.GetHashCode();
    }
}
