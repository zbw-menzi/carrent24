namespace CarRent.Feature.Cars.Api
{
    using CarRent.Feature.Cars.Domain;

    using FastEndpoints;

    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;

    public class GetCarsEndpoint : EndpointWithoutRequest<IEnumerable<CarResponse>>
    {
        private readonly ICarRepository _repository;

        public GetCarsEndpoint(ICarRepository repository)
        {
            _repository = repository;
        }

        public override void Configure()
        {
            Get("/cars");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var cars = _repository.GetCars();

            var response = cars.Select(car => new CarResponse
            {
                Id = car.Id,
                Name = car.Name
            });

            await SendOkAsync(response, ct);
        }
    }
}
