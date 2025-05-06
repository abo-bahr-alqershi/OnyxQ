using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Persistence.Configurations
{
    /// <summary>
    /// تكوين كيان الرقم المستخدم
    /// </summary>
    public class UsedNumberConfiguration : IEntityTypeConfiguration<UsedNumber>
    {
        public void Configure(EntityTypeBuilder<UsedNumber> builder)
        {
            builder.ToTable("UsedNumbers");

            builder.HasKey(e => e.Id);

            // الخصائص المطلوبة
            builder.Property(e => e.SequenceId)
                .IsRequired();

            builder.Property(e => e.FormattedNumber)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.RawNumber)
                .IsRequired();

            builder.Property(e => e.UsageDate)
                .IsRequired();

            // الخصائص العادية
            builder.Property(e => e.DocumentType)
                .HasMaxLength(50);

            // العلاقات
            builder.HasOne(e => e.Branch)
                .WithMany()
                .HasForeignKey(e => e.BranchId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
} 