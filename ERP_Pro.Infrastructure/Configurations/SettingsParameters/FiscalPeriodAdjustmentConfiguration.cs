using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Configurations.SettingsParameters
{
    /// <summary>
    /// تكوين كيان تسوية الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodAdjustmentConfiguration : IEntityTypeConfiguration<FiscalPeriodAdjustment>
    {
        /// <summary>
        /// تطبيق التكوين
        /// </summary>
        public void Configure(EntityTypeBuilder<FiscalPeriodAdjustment> builder)
        {
            builder.ToTable("FiscalPeriodAdjustments", "settings");

            // المفتاح الأساسي
            builder.HasKey(a => a.Id);

            // الخصائص
            builder.Property(a => a.AdjustmentDate)
                .IsRequired();

            builder.Property(a => a.AdjustmentType)
                .IsRequired();

            builder.Property(a => a.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(a => a.PerformedBy)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Notes)
                .HasMaxLength(500);

            // العلاقات
            builder.HasOne(a => a.FiscalPeriod)
                .WithMany(p => p.PeriodAdjustments)
                .HasForeignKey(a => a.FiscalPeriodId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // الفهارس
            builder.HasIndex(a => a.FiscalPeriodId);
            builder.HasIndex(a => a.AdjustmentDate);
            builder.HasIndex(a => a.AdjustmentType);
            builder.HasIndex(a => a.JournalEntryId);
            builder.HasIndex(a => a.Status);
            
            // تحقق من عدم تكرار التسويات
            builder.HasQueryFilter(a => !a.IsDeleted);
        }
    }
}