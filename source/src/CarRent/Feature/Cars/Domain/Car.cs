namespace CarRent.Feature.Cars.Domain
{
    using CarRent.Common.Domain;

    public class Car : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
    }
}
