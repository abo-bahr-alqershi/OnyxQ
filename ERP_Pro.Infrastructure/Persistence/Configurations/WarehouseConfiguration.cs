using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ERP_Pro.Domain.InventoryWarehousing.Entities;

namespace ERP_Pro.Infrastructure.Persistence.Configurations
{
    /// <summary>
    /// تكوين كيان المستودع
    /// </summary>
    public class WarehouseConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.ToTable("Warehouses");

            builder.HasKey(e => e.Id);

            // الخصائص المطلوبة
            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.NameAr)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.WarehouseType)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.BranchId)
                .IsRequired();

            // الخصائص العادية
            builder.Property(e => e.NameEn)
                .HasMaxLength(100);

            builder.Property(e => e.Area)
                .HasPrecision(18, 2);

            builder.Property(e => e.Capacity)
                .HasPrecision(18, 2);

            // معلومات الموقع
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

            // معلومات إدارية
            builder.Property(e => e.KeeperName)
                .HasMaxLength(100);

            builder.Property(e => e.KeeperEmail)
                .HasMaxLength(100);

            builder.Property(e => e.KeeperPhone)
                .HasMaxLength(20);

            builder.Property(e => e.Status)
                .HasMaxLength(20);

            builder.Property(e => e.Notes)
                .HasMaxLength(500);

            // العلاقات
            builder.HasOne<ERP_Pro.Domain.SettingsParameters.Entities.Branch>()
                .WithMany(e => e.Warehouses)
                .HasForeignKey(e => e.BranchId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 