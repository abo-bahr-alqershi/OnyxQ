using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Persistence.Configurations
{
    /// <summary>
    /// تكوين كيان الفرع
    /// </summary>
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branches");

            builder.HasKey(e => e.Id);

            // الخصائص المطلوبة
            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.NameAr)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.BranchType)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.CompanyInfoId)
                .IsRequired();

            // الخصائص العادية
            builder.Property(e => e.NameEn)
                .HasMaxLength(100);

            builder.Property(e => e.CommercialRegistrationNo)
                .HasMaxLength(50);

            builder.Property(e => e.TaxRegistrationNo)
                .HasMaxLength(50);

            // معلومات الاتصال
            builder.Property(e => e.Address)
                .HasMaxLength(200);

            builder.Property(e => e.City)
                .HasMaxLength(50);

            builder.Property(e => e.Region)
                .HasMaxLength(50);

            builder.Property(e => e.Country)
                .HasMaxLength(50);

            builder.Property(e => e.PostalCode)
                .HasMaxLength(20);

            builder.Property(e => e.Phone)
                .HasMaxLength(20);

            builder.Property(e => e.Email)
                .HasMaxLength(100);

            // معلومات إدارية
            builder.Property(e => e.ManagerName)
                .HasMaxLength(100);

            builder.Property(e => e.ManagerEmail)
                .HasMaxLength(100);

            builder.Property(e => e.ManagerPhone)
                .HasMaxLength(20);

            builder.Property(e => e.Status)
                .HasMaxLength(20);

            builder.Property(e => e.Notes)
                .HasMaxLength(500);

            // العلاقات
            builder.HasOne<CompanyInfo>()
                .WithMany(e => e.Branches)
                .HasForeignKey(e => e.CompanyInfoId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Branch>()
                .WithMany()
                .HasForeignKey(e => e.ParentBranchId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(false);

            builder.HasMany(e => e.Warehouses)
                .WithOne()
                .HasForeignKey(e => e.BranchId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 