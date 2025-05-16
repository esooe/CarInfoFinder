using CarInfoFinder.Application.Interfaces;
using CarInfoFinder.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<IVehicleService, VehicleService>();

builder.Services.AddControllers();

// Add Swagger/OpenAPI support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger and Swagger UI in ALL environments (not just Development)
app.UseSwagger();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "CarInfoFinder.Api v1");
});

// app.UseHttpsRedirection();
// app.UseAuthorization();

app.MapControllers();

app.Run();
