namespace CarRent.Feature.Cars.Api
{
    using CarRent.Feature.Cars.Domain;

    using FastEndpoints;

    using System.Threading;
    using System.Threading.Tasks;

    public class GetCarByIdEndpoint : EndpointWithoutRequest<CarResponse>
    {
        private readonly ICarRepository _repository;

        public GetCarByIdEndpoint(ICarRepository repository)
        {
            _repository = repository;
        }

        public override void Configure()
        {
            Get("/cars/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            ////var carId = Route<Guid>("id");
            ////var car = _repository.FindById(carId);
            ////await SendAsync(new CarResponse
            ////{
            ////    Id = car.Id,
            ////    Name = car.LicensePlate
            ////}, StatusCodes.Status200OK, ct);
        }
    }
}
