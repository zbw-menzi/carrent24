﻿namespace CarRent.Feature.Cars.Infrastructure
{
    using CarRent.Feature.Cars.Domain;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.LicensePlate)
                   .HasConversion(
                        convertFromProviderExpression: x => LicensePlate.Create(x),
                        convertToProviderExpression: x => x.Value
                    )
                   .HasMaxLength(256);
        }
    }
}
