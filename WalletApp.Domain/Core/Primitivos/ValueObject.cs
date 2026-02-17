using System;
using System.Collections.Generic;
using System.Text;

namespace WalletApp.Domain.Core.Primitivos
{
    /// <summary>
    /// Represents the base class all value objects derive from.
    /// </summary>
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        public bool Equals(ValueObject? other) => !(other is null) && GetAtomicValues().SequenceEqual(other.GetAtomicValues());
        /// <inheritdoc/>
        public static bool operator !=(ValueObject left, ValueObject right) => !(left == right);
        /// <inheritdoc/> 
        public static bool operator == (ValueObject left, ValueObject right)
        {
            if(left is null && right is null)
                return true;

            if (left is null || right is null)
                return false;
            return left.Equals(right);
        } 
        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(GetType() != obj.GetType())
            {
                return false;
            }
            if(!(obj is ValueObject other))
            {
                return false;
            }
            return GetAtomicValues().SequenceEqual(other.GetAtomicValues()); 
        }
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            HashCode hashCode = new HashCode();
            foreach(object obj in GetAtomicValues())
            {
                hashCode.Add(obj);
            }
            return hashCode.ToHashCode();
        }

        /// <summary>
        /// Gets the atomic value of the value object
        /// </summary>
        /// <returns>The collection of objects representing the value object values.</returns>
        protected abstract IEnumerable<object> GetAtomicValues();
    }
}
