namespace CarRent.Feature.Cars.Domain
{
    using CarRent.Common.Domain;

    public static class CarErrors
    {
        public static DomainException InvalidLicensePlate(string licenseFormat) =>
            new DomainException("Cars.InvalidLicensePlate", $"The license plate must have the following format {licenseFormat}.");
    }
}
