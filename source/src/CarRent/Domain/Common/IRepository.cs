namespace CarRent.Domain.Common
{
    public interface IRepository<TAggregate>
        where TAggregate : Entity, IAggregateRoot
    {
        TAggregate FindById(Guid id);

        void Add(TAggregate entity);

        void Remove(TAggregate entity);
    }
}
