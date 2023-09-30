using Microsoft.EntityFrameworkCore;

using Skornel02.ETR.Api.Entities;

namespace Skornel02.ETR.Api;

public class ETRContext : DbContext
{
    public ETRContext(DbContextOptions<ETRContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
}