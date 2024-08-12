namespace CarRent.Domain.Common
{
    public abstract class ValueObject : IEquatable<ValueObject?>
    {
        protected ValueObject()
        {
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as ValueObject);
        }


        public bool Equals(ValueObject? other)
        {
            if (other is null)
            {
                return false;
            }

            if (GetType() != other.GetType())
            {
                return false;
            }

            return EqualityComponents.SequenceEqual(other.EqualityComponents);
        }

        public override int GetHashCode()
        {
            HashCode hashCode = default;

            foreach (var obj in EqualityComponents)
            {
                hashCode.Add(obj);
            }

            return hashCode.ToHashCode();
        }

        protected abstract IEnumerable<object?> EqualityComponents { get; }
    }
}
