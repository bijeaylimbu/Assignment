using com.assignment.DomainEntities;
using com.assignment.Persistance.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace com.assignment.Persistance;

public partial class TariffCalculationDbContext : DbContext
{
    public TariffCalculationDbContext()
    {
        
    }

    public TariffCalculationDbContext(DbContextOptions<TariffCalculationDbContext> options) : base(options)
    {
        
    }
    public DbSet<TariffMaster> TariffMasters { get; set; }
    public DbSet<TariffDetails> TariffDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TarifMasterBuilder());
        modelBuilder.ApplyConfiguration(new TariffDetailsBuilder());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer()
            .UseSnakeCaseNamingConvention();
    }
}