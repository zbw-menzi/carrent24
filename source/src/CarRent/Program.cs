using CarRent.Common.Domain;
using CarRent.Feature.Cars.Domain;
using CarRent.Feature.Cars.Infrastructure;
using CarRent.Persistence;

using FastEndpoints;
using FastEndpoints.Swagger;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<CarRentDbContext>(options =>
{
    options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=carrent2;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
});

builder.Services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<CarRentDbContext>());

builder.Services
    .AddFastEndpoints()
    .SwaggerDocument();

builder.Services.AddScoped<ICarRepository, CarRepository>();

var app = builder.Build();

app.UseFastEndpoints()
   .UseSwaggerGen(); ;

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<CarRentDbContext>();
    
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();
}

app.UseHttpsRedirection();

app.Run();
