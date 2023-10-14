using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api.Entities;

namespace Skornel02.ETR.Api;

public class ETRContext(DbContextOptions<ETRContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ETRContext).Assembly);
    }
}