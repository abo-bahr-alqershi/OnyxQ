using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Configurations.SettingsParameters
{
    /// <summary>
    /// تكوين كيان الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodConfiguration : IEntityTypeConfiguration<FiscalPeriod>
    {
        /// <summary>
        /// تطبيق التكوين
        /// </summary>
        public void Configure(EntityTypeBuilder<FiscalPeriod> builder)
        {
            builder.ToTable("FiscalPeriods", "settings");

            // المفتاح الأساسي
            builder.HasKey(p => p.Id);

            // الخصائص
            builder.Property(p => p.Code)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(p => p.NameAr)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.NameEn)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.PeriodNumber)
                .IsRequired();

            builder.Property(p => p.StartDate)
                .IsRequired();

            builder.Property(p => p.EndDate)
                .IsRequired();

            builder.Property(p => p.Status)
                .IsRequired();

            builder.Property(p => p.PeriodType)
                .IsRequired();

            builder.Property(p => p.Notes)
                .HasMaxLength(500);

            // العلاقات
            builder.HasOne(p => p.FiscalYear)
                .WithMany(y => y.FiscalPeriods)
                .HasForeignKey(p => p.FiscalYearId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // الفهارس
            builder.HasIndex(p => new { p.FiscalYearId, p.PeriodNumber }).IsUnique();
            builder.HasIndex(p => new { p.FiscalYearId, p.Code }).IsUnique();
            builder.HasIndex(p => new { p.StartDate, p.EndDate });
            builder.HasIndex(p => p.Status);
            
            // الافتراضيات
            builder.Property(p => p.IsClosingDefault)
                .HasDefaultValue(false);

            // تحقق من عدم تداخل الفترات في نفس السنة المالية
            builder.HasQueryFilter(p => !p.IsDeleted);
        }
    }
} 