using ERP_Pro.Domain.FinanceAccounting.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP_Pro.Infrastructure.Persistence.Configurations
{
    /// <summary>
    /// تكوين كيان سعر صرف العملة في قاعدة البيانات
    /// </summary>
    public class CurrencyExchangeRateConfiguration : IEntityTypeConfiguration<CurrencyExchangeRate>
    {
        public void Configure(EntityTypeBuilder<CurrencyExchangeRate> builder)
        {
            builder.ToTable("CurrencyExchangeRates", "Finance");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();
            
            builder.Property(x => x.CurrencyId)
                .IsRequired();
                
            builder.Property(x => x.EffectiveDate)
                .IsRequired();
                
            builder.Property(x => x.RateType)
                .IsRequired()
                .HasMaxLength(20);
                
            builder.Property(x => x.Rate)
                .IsRequired()
                .HasPrecision(18, 8);
                
            builder.Property(x => x.Source)
                .HasMaxLength(50);
                
            builder.Property(x => x.Notes)
                .HasMaxLength(500);
                
            builder.Property(x => x.CreatedAt)
                .IsRequired();
                
            builder.Property(x => x.CreatedBy)
                .HasMaxLength(100);
                
            builder.Property(x => x.LastModifiedAt);
                
            builder.Property(x => x.LastModifiedBy)
                .HasMaxLength(100);
                
            // العلاقة مع العملة
            builder.HasOne(x => x.Currency)
                .WithMany()
                .HasForeignKey(x => x.CurrencyId)
                .OnDelete(DeleteBehavior.Cascade);
                
            // مؤشر مركب على العملة والتاريخ ونوع السعر
            builder.HasIndex(x => new { x.CurrencyId, x.EffectiveDate, x.RateType });
        }
    }
} 