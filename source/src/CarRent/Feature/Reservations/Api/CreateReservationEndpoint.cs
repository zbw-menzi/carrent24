namespace CarRent.Feature.Reservations.Api
{
    using FastEndpoints;

    using System.Threading;
    using System.Threading.Tasks;

    public class CreateReservationEndpoint : Endpoint<CreateReservationRequest, CreateReservationResponse>
    {
        public override void Configure()
        {
            Post("/reservations");
            AllowAnonymous();
        }

        public override Task HandleAsync(CreateReservationRequest req, CancellationToken ct)
        {
            return base.HandleAsync(req, ct);
        }
    }
}
