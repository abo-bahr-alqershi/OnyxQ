using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Persistence.Configurations
{
    /// <summary>
    /// تكوين كيان سجل تدقيق التسلسل
    /// </summary>
    public class SequenceAuditConfiguration : IEntityTypeConfiguration<SequenceAudit>
    {
        public void Configure(EntityTypeBuilder<SequenceAudit> builder)
        {
            builder.ToTable("SequenceAudits");

            builder.HasKey(e => e.Id);

            // الخصائص المطلوبة
            builder.Property(e => e.SequenceId)
                .IsRequired();

            builder.Property(e => e.Type)
                .IsRequired();

            builder.Property(e => e.Timestamp)
                .IsRequired();

            builder.Property(e => e.UserId)
                .IsRequired();

            // الخصائص العادية
            builder.Property(e => e.Details)
                .HasMaxLength(1000);

            // العلاقات
            builder.HasOne(e => e.Branch)
                .WithMany()
                .HasForeignKey(e => e.BranchId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
} 