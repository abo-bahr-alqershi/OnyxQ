using ERP_Pro.Domain.FinanceAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_Pro.Infrastructure.Persistence.Configurations
{
    /// <summary>
    /// تكوين كيان العملة في قاعدة البيانات
    /// </summary>
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.ToTable("Currencies", "Finance");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            
            // إعداد الخصائص الأساسية
            builder.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(10);
            
            builder.HasIndex(x => x.Code)
                .IsUnique();
                
            builder.Property(x => x.IsoCode)
                .HasMaxLength(10);
                
            builder.Property(x => x.NameAr)
                .IsRequired()
                .HasMaxLength(100);
                
            builder.Property(x => x.NameEn)
                .HasMaxLength(100);
                
            builder.Property(x => x.Symbol)
                .HasMaxLength(10);
                
            builder.Property(x => x.Country)
                .HasMaxLength(100);
                
            builder.Property(x => x.DecimalPlaces)
                .IsRequired();
                
            builder.Property(x => x.FractionName)
                .HasMaxLength(50);
                
            builder.Property(x => x.FractionValue)
                .HasPrecision(18, 8);
                
            builder.Property(x => x.ThousandsSeparator)
                .HasMaxLength(5);
                
            builder.Property(x => x.DecimalSeparator)
                .HasMaxLength(5);
                
            builder.Property(x => x.IsBase)
                .IsRequired();
                
            builder.Property(x => x.Status)
                .IsRequired()
                .HasConversion<string>()
                .HasMaxLength(20);
                
            builder.Property(x => x.Notes)
                .HasMaxLength(500);
                
            builder.Property(x => x.ArWordsTemplate)
                .HasMaxLength(500);
                
            builder.Property(x => x.EnWordsTemplate)
                .HasMaxLength(500);
                
            builder.Property(x => x.RoundingUnit)
                .HasPrecision(18, 8);
                
            // العلاقات
            builder.HasMany(x => x.ExchangeRateHistory)
                .WithOne()
                .HasForeignKey(x => x.CurrencyId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(x => x.RoundingRules)
                .WithOne()
                .HasForeignKey(x => x.CurrencyId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(x => x.Accounts)
                .WithOne()
                .HasForeignKey(x => x.CurrencyId)
                .OnDelete(DeleteBehavior.Cascade);
                
            builder.HasMany(x => x.RiskLimits)
                .WithOne()
                .HasForeignKey(x => x.CurrencyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 