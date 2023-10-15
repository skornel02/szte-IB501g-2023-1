using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api;
using Skornel02.ETR.Api.Endpoints;
using Skornel02.ETR.Api.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<PasswordHasher<User>>();

var connectionString = builder.Configuration.GetConnectionString("ETRContext");
builder.Services.AddDbContext<ETRContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
#if DEBUG
    .EnableDetailedErrors(true)
    .EnableSensitiveDataLogging(true)
#endif
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapUserEndpoints();
app.MapAuthEndpoints();

app.UseStaticFiles("/static");
app.MapFallbackToFile("index.html");

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetService<ETRContext>();

    context.Database.EnsureCreated();
}

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}