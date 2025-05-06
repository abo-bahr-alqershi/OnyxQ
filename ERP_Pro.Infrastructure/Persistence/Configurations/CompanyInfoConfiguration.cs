using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ERP_Pro.Domain.SettingsParameters.Entities;

namespace ERP_Pro.Infrastructure.Persistence.Configurations
{
    /// <summary>
    /// تكوين كيان معلومات الشركة
    /// </summary>
    public class CompanyInfoConfiguration : IEntityTypeConfiguration<CompanyInfo>
    {
        public void Configure(EntityTypeBuilder<CompanyInfo> builder)
        {
            builder.ToTable("CompanyInfo");

            builder.HasKey(e => e.Id);

            // الخصائص المطلوبة
            builder.Property(e => e.NameAr)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.TaxRegistrationNo)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.BaseCurrencyCode)
                .IsRequired()
                .HasMaxLength(3);

            // الخصائص العادية
            builder.Property(e => e.NameEn)
                .HasMaxLength(100);

            builder.Property(e => e.LogoPath)
                .HasMaxLength(500);

            builder.Property(e => e.CommercialRegistrationNo)
                .HasMaxLength(50);

            builder.Property(e => e.LegalForm)
                .HasMaxLength(50);

            builder.Property(e => e.Capital)
                .HasPrecision(18, 2);

            builder.Property(e => e.CapitalCurrencyCode)
                .HasMaxLength(3);

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

            builder.Property(e => e.POBox)
                .HasMaxLength(20);

            builder.Property(e => e.Phone)
                .HasMaxLength(20);

            builder.Property(e => e.AlternatePhone)
                .HasMaxLength(20);

            builder.Property(e => e.Fax)
                .HasMaxLength(20);

            builder.Property(e => e.Email)
                .HasMaxLength(100);

            builder.Property(e => e.Website)
                .HasMaxLength(100);

            // معلومات الممثل القانوني
            builder.Property(e => e.LegalRepresentativeName)
                .HasMaxLength(100);

            builder.Property(e => e.LegalRepresentativePosition)
                .HasMaxLength(50);

            builder.Property(e => e.LegalRepresentativeIdNo)
                .HasMaxLength(50);

            builder.Property(e => e.LegalRepresentativeIdType)
                .HasMaxLength(50);

            builder.Property(e => e.LegalRepresentativePhone)
                .HasMaxLength(20);

            builder.Property(e => e.LegalRepresentativeEmail)
                .HasMaxLength(100);

            // إعدادات النظام
            builder.Property(e => e.FiscalYearType)
                .HasMaxLength(20);

            builder.Property(e => e.RoundingPolicy)
                .HasMaxLength(20);

            builder.Property(e => e.BalanceDisplayMethod)
                .HasMaxLength(20);

            builder.Property(e => e.DefaultLanguage)
                .HasMaxLength(5);

            // العلاقات
            builder.HasMany(e => e.Branches)
                .WithOne()
                .HasForeignKey(e => e.CompanyInfoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 