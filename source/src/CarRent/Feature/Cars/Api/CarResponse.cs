namespace CarRent.Feature.Cars.Api
{
    public class CarResponse
    {
        public required Guid Id { get; init; }

        public required string Name { get; init; }
    }
}
