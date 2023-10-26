using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

using Skornel02.ETR.Api;
using Skornel02.ETR.Api.Endpoints;
using Skornel02.ETR.Api.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new()
    {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
});

builder.Services.AddSingleton<PasswordHasher<User>>();

var connectionString = builder.Configuration.GetConnectionString("ETRContext");
builder.Services.AddDbContext<ETRContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
#if DEBUG
    .EnableDetailedErrors(true)
    .EnableSensitiveDataLogging(true)
#endif
    );

builder.Services
    .AddAuthentication()
    .AddBearerToken();

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.EnablePersistAuthorization());
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapAuthEndpoints();
app.MapUserEndpoints();
app.MapProfileEndpoints();

app.UseStaticFiles("/static");
app.MapFallbackToFile("index.html");

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetService<ETRContext>();

    context?.Database.EnsureCreated();
}

app.Run();