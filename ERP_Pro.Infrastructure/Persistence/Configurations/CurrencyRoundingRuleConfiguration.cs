using ERP_Pro.Domain.FinanceAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_Pro.Infrastructure.Persistence.Configurations
{
    public class CurrencyRoundingRuleConfiguration : IEntityTypeConfiguration<CurrencyRoundingRule>
    {
        public void Configure(EntityTypeBuilder<CurrencyRoundingRule> builder)
        {
            builder.ToTable("CurrencyRoundingRules", "FinanceAccounting");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Description)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(r => r.RoundingValue)
                .HasPrecision(18, 6)
                .IsRequired();

            builder.Property(r => r.DecimalPlaces)
                .IsRequired();

            builder.Property(r => r.IsActive)
                .IsRequired();

            builder.HasOne(r => r.Currency)
                .WithMany()
                .HasForeignKey(r => r.CurrencyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 