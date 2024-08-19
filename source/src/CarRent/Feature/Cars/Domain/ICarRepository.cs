namespace CarRent.Feature.Cars.Domain
{
    using CarRent.Common.Domain;

    public interface ICarRepository : IRepository<Car>
    {
        IReadOnlyList<Car> GetCars();
    }
}
