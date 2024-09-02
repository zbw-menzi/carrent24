namespace CarRent.Feature.Reservations.Infrastructure
{
    using CarRent.Feature.Cars.Domain;
    using CarRent.Feature.Reservations.Domain;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            // Map the primary key
            builder.HasKey(r => r.Id);

            // Map other properties
            builder.Property(r => r.StartDate).IsRequired();
            builder.Property(r => r.EndDate).IsRequired();
            builder.Property(r => r.TotalAmount).IsRequired();

            // Map the relations
            builder.HasOne(r => r.CarClass)
                   .WithMany();

            builder.HasOne(r => r.Customer)
                   .WithMany();
        }
    }
}
