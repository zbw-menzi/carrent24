namespace CarRent.Feature.Cars.Domain
{
    using CarRent.Common.Domain;

    public class Car : Entity, IAggregateRoot
    {
        private Car()
        {
        }

        private Car(
            LicensePlate licensePlate,
            CarClass carClass,
            string brand,
            string type)
        {
            LicensePlate = licensePlate;
            Class = carClass;
            Brand = brand;
            Type = type;
        }

        public LicensePlate LicensePlate { get; private set; }

        public CarClass Class { get; private set; }

        public string Brand { get; private set; }
        
        public string Type { get; private set; }

        /// <summary>
        /// Creates a new Car instance.
        /// </summary>
        /// <param name="licensePlate">The license plate of the car.</param>
        /// <param name="carClass">The class of the car.</param>
        /// <param name="brand">The brand of the car.</param>
        /// <param name="type">The type of the car.</param>
        /// <exception cref="ArgumentNullException">Thrown when any of the parameters is null or whitespace.</exception>
        /// <exception cref="DomainException">Thrown when a domain-specific exception occurs.</exception>
        /// <returns>The newly created Car instance.</returns>
        public static Car Create(
            string licensePlate,
            CarClass carClass,
            string brand,
            string type)
        {
            ArgumentNullException.ThrowIfNullOrWhiteSpace(licensePlate);
            ArgumentNullException.ThrowIfNull(carClass);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(brand);
            ArgumentNullException.ThrowIfNullOrWhiteSpace(type);

            return new Car(LicensePlate.Create(licensePlate), carClass, brand, type);
        }
    }
}
