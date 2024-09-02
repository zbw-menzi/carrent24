namespace CarRent.Feature.Cars.Domain
{
    using CarRent.Common.Domain;

    public abstract class CarClass : Entity
    {
        protected CarClass(decimal amount)
        {
            Amount = amount;
        }

        public decimal Amount { get; }
    }
}
