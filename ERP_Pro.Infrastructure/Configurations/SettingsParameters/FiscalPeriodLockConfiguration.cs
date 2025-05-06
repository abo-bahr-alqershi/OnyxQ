using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Configurations.SettingsParameters
{
    /// <summary>
    /// تكوين كيان تأمين الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodLockConfiguration : IEntityTypeConfiguration<FiscalPeriodLock>
    {
        /// <summary>
        /// تطبيق التكوين
        /// </summary>
        public void Configure(EntityTypeBuilder<FiscalPeriodLock> builder)
        {
            builder.ToTable("FiscalPeriodLocks", "settings");

            // المفتاح الأساسي
            builder.HasKey(l => l.Id);

            // الخصائص
            builder.Property(l => l.LockStartDate)
                .IsRequired();

            builder.Property(l => l.LockType)
                .IsRequired();

            builder.Property(l => l.Reason)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(l => l.PerformedBy)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(l => l.UnlockedBy)
                .HasMaxLength(100);

            builder.Property(l => l.Notes)
                .HasMaxLength(500);

            // العلاقات
            builder.HasOne(l => l.FiscalPeriod)
                .WithMany(p => p.PeriodLocks)
                .HasForeignKey(l => l.FiscalPeriodId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // الفهارس
            builder.HasIndex(l => l.FiscalPeriodId);
            builder.HasIndex(l => l.LockStartDate);
            builder.HasIndex(l => l.LockEndDate);
            builder.HasIndex(l => l.LockType);
            
            // تحقق من عدم تداخل فترات التأمين
            builder.HasQueryFilter(l => !l.IsDeleted);
        }
    }
} 