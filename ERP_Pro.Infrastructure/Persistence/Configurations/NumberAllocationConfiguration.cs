using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Persistence.Configurations
{
    /// <summary>
    /// تكوين كيان تخصيص النطاق
    /// </summary>
    public class NumberAllocationConfiguration : IEntityTypeConfiguration<NumberAllocation>
    {
        public void Configure(EntityTypeBuilder<NumberAllocation> builder)
        {
            builder.ToTable("NumberAllocations");

            builder.HasKey(e => e.Id);

            // الخصائص المطلوبة
            builder.Property(e => e.SequenceId)
                .IsRequired();

            builder.Property(e => e.RangeStart)
                .IsRequired();

            builder.Property(e => e.RangeEnd)
                .IsRequired();

            builder.Property(e => e.AllocationDate)
                .IsRequired();

            builder.Property(e => e.AllocatedByUserId)
                .IsRequired();

            builder.Property(e => e.Status)
                .IsRequired();

            // الخصائص العادية
            builder.Property(e => e.Reason)
                .HasMaxLength(500);

            builder.Property(e => e.BranchName)
                .HasMaxLength(100);

            builder.Property(e => e.CurrentNumber)
                .IsRequired();

            // العلاقات
            builder.HasOne(e => e.Branch)
                .WithMany()
                .HasForeignKey(e => e.BranchId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
} 