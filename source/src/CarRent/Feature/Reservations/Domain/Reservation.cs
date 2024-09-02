namespace CarRent.Feature.Reservations.Domain
{
    using CarRent.Common.Domain;
    using CarRent.Feature.Cars.Domain;
    using CarRent.Feature.Customers.Domain;

    using System.Diagnostics.CodeAnalysis;

    public class Reservation : Entity
    {
        [ExcludeFromCodeCoverage(Justification = "EF Core")]
        private Reservation()
        {
        }

        private Reservation(Customer customer, CarClass carClass, DateOnly startDate, DateOnly endDate)
        {
            Customer = customer;
            CarClass = carClass;
            StartDate = startDate;
            EndDate = endDate;
            TotalAmount = CarClass.Amount * DurationInDays;
        }

        public Customer Customer { get; private set; }

        public CarClass CarClass { get; private set; }

        public DateOnly StartDate { get; private set; }

        public DateOnly EndDate { get; private set; }

        public int DurationInDays => EndDate.DayNumber - StartDate.DayNumber;

        public decimal TotalAmount { get; private set; }

        public static Reservation Create(Customer customer, CarClass carClass, DateOnly startDate, DateOnly endDate)
        {
            return new Reservation(customer, carClass, startDate, endDate);
        }
    }
}
