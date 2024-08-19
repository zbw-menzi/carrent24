namespace CarRent.Persistence
{
    using CarRent.Common.Domain;
    using CarRent.Feature.Cars.Infrastructure;

    using Microsoft.EntityFrameworkCore;

    public class CarRentDbContext : DbContext, IUnitOfWork
    {
        public CarRentDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public int CommitChanges()
        {
            return SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CarConfiguration());

            // Autoregistration
            //modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
