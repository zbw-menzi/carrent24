namespace CarRent.Domain.Common
{
    using System.Collections.Generic;

    public abstract class Entity : IEquatable<Entity?>
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Entity);
        }

        public bool Equals(Entity? other)
        {
            return other is not null &&
                   Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator ==(Entity? left, Entity? right)
        {
            return EqualityComparer<Entity>.Default.Equals(left, right);
        }

        public static bool operator !=(Entity? left, Entity? right)
        {
            return !(left == right);
        }
    }
}
