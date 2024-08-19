namespace CarRent.Feature.Cars.Api
{
    using CarRent.Common.Domain;
    using CarRent.Feature.Cars.Domain;

    using FastEndpoints;

    using System.Threading;
    using System.Threading.Tasks;

    public class CreateCarEndpoint : Endpoint<CarRequest, CarResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICarRepository _repository;

        public CreateCarEndpoint(IUnitOfWork unitOfWork, ICarRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public override void Configure()
        {
            Post("/cars");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CarRequest req, CancellationToken ct)
        {
            var car = new Car
            {
                Name = req.Name
            };

            _repository.Add(car);

            _unitOfWork.CommitChanges();

            await SendCreatedAtAsync<GetCarByIdEndpoint>(null, new CarResponse
            {
                Id = car.Id,
                Name = car.Name
            });
        }
    }
}
