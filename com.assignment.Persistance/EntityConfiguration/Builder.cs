using com.assignment.DomainEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace com.assignment.Persistance.EntityConfiguration;

internal  sealed class TarifMasterBuilder: IEntityTypeConfiguration<TariffMaster>
{
    public void Configure(EntityTypeBuilder<TariffMaster> builder)
    {
        builder.ToTable("tariff_master");
        builder.HasKey(x => x.TariffId);
        builder.Property(x => x.RebateDays)
            .HasColumnName("rebate_days")
            .IsRequired();
        builder.Property(x => x.PenaltyDays)
            .HasColumnName("penalty_days")
            .IsRequired();
        builder.Property(x => x.PenaltyRate)
            .HasColumnName("penalty_rate")
            .IsRequired();
        builder.HasMany(x => x.TariffDetails)
            .WithOne(b => b.TarifMaster).HasForeignKey(x => x.TariffId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

internal  sealed class TariffDetailsBuilder: IEntityTypeConfiguration<TariffDetails>
{
    public void Configure(EntityTypeBuilder<TariffDetails> builder)
    {
        builder.ToTable("tariff_details");
        builder.HasKey(x => x.TariffId);
        builder.Property(x => x.StartUnit)
            .HasColumnName("start_unit")
            .IsRequired();
        builder.Property(x => x.EndUnit)
            .HasColumnName("end_unit")
            .IsRequired();
        builder.Property(x => x.EnergyRate)
            .HasColumnName("energy_rate")
            .IsRequired();
        builder.Property(x => x.ServiceCharge)
            .HasColumnName("service_charge")
            .IsRequired();
    }
}