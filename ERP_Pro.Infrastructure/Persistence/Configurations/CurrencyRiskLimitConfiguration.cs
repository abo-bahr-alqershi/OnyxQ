using ERP_Pro.Domain.FinanceAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_Pro.Infrastructure.Persistence.Configurations
{
    public class CurrencyRiskLimitConfiguration : IEntityTypeConfiguration<CurrencyRiskLimit>
    {
        public void Configure(EntityTypeBuilder<CurrencyRiskLimit> builder)
        {
            builder.ToTable("CurrencyRiskLimits", "FinanceAccounting");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.MinRate)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(r => r.MaxRate)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(r => r.WarningThreshold)
                .HasPrecision(5, 2)
                .IsRequired();

            builder.Property(r => r.TargetRate)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(r => r.AlertEnabled)
                .IsRequired();

            builder.Property(r => r.LastUpdated)
                .IsRequired();

            builder.Property(r => r.UpdatedBy)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasOne(r => r.Currency)
                .WithMany()
                .HasForeignKey(r => r.CurrencyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 