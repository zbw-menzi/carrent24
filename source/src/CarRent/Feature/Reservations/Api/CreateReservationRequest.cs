namespace CarRent.Feature.Reservations.Api
{
    public class CreateReservationRequest
    {
        public Guid UserId { get; init; }

        public Guid ClassId { get; init; }
    }
}