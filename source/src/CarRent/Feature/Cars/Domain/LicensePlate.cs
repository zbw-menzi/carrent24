namespace CarRent.Feature.Cars.Domain
{
    using CarRent.Common.Domain;

    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class LicensePlate : ValueObject
    {
        public string Value { get; private set; }

        private LicensePlate(string value)
        {
            Value = value;
        }

        protected override IEnumerable<object?> EqualityComponents
        {
            get
            {
                yield return Value;
            }
        }

        public static LicensePlate Create(string licensePlate)
        {
            if (!Regex.IsMatch(licensePlate, @"^[A-Z]{2}\-\d+$"))
            {
                throw CarErrors.InvalidLicensePlate(@"^[A-Z]{2}\-\d+$");
            }

            return new LicensePlate(licensePlate);
        }
    }
}
