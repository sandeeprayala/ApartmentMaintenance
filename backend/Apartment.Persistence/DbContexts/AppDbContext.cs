using Apartment.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apartment.Persistence.DbContexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Community> Community => Set<Community>();

    public DbSet<Block> Blocks => Set<Block>();

    public DbSet<Flat> Flats => Set<Flat>();

    public DbSet<Owner> Owners => Set<Owner>();

    public DbSet<Tenant> Tenants => Set<Tenant>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
