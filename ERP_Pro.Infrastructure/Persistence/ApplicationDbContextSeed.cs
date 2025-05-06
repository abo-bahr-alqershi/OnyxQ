using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ERP_Pro.Domain.SettingsParameters.Entities;
using ERP_Pro.Domain.InventoryWarehousing.Entities;

namespace ERP_Pro.Infrastructure.Persistence
{
    /// <summary>
    /// بذر البيانات الأولية في قاعدة البيانات
    /// </summary>
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedSampleDataAsync(ApplicationDbContext context, ILogger<ApplicationDbContext> logger)
        {
            try
            {
                // إضافة بيانات الشركة إذا لم تكن موجودة
                if (!context.CompanyInfo.Any())
                {
                    logger.LogInformation("بدء زراعة بيانات الشركة");

                    var companyInfo = CompanyInfo.Create(
                        "شركة أونكس للحلول البرمجية",
                        "Onyx Software Solutions",
                        "123456789",
                        "SAR");

                    companyInfo.UpdateBasicInfo(
                        "شركة أونكس للحلول البرمجية",
                        "Onyx Software Solutions",
                        "CR123456",
                        DateTime.Parse("2020-01-01"),
                        "123456789",
                        DateTime.Parse("2020-01-01"),
                        "شركة ذات مسؤولية محدودة",
                        1000000,
                        "SAR");

                    companyInfo.UpdateContactInfo(
                        "شارع الملك فهد، حي العليا",
                        "الرياض",
                        "الرياض",
                        "المملكة العربية السعودية",
                        "12345",
                        "54321",
                        "+966 11 123 4567",
                        "+966 11 765 4321",
                        "+966 11 123 9999",
                        "info@onyx.sa",
                        "www.onyx.sa");

                    companyInfo.UpdateSystemSettings(
                        "SAR",
                        "Gregorian",
                        12,
                        2,
                        "Standard",
                        "DebitCredit",
                        true,
                        true,
                        "ar");

                    context.CompanyInfo.Add(companyInfo);

                    await context.SaveChangesAsync();
                    logger.LogInformation("تم زراعة بيانات الشركة بنجاح");

                    // إضافة فرع رئيسي
                    if (!context.Branches.Any())
                    {
                        logger.LogInformation("بدء زراعة بيانات الفرع الرئيسي");

                        var branch = Branch.Create(
                            companyInfo.Id,
                            "HQ",
                            "الفرع الرئيسي",
                            "Main Branch",
                            "Headquarters",
                            true);

                        branch.UpdateBasicInfo(
                            "الفرع الرئيسي",
                            "Main Branch",
                            "Headquarters",
                            "CR123456-001",
                            "123456789-001",
                            DateTime.Parse("2020-01-01"));

                        branch.UpdateContactInfo(
                            "شارع الملك فهد، حي العليا",
                            "الرياض",
                            "الرياض",
                            "المملكة العربية السعودية",
                            "12345",
                            "+966 11 123 4567",
                            "main@onyx.sa");

                        branch.UpdateAdministrativeInfo(
                            "أحمد محمد",
                            "ahmed@onyx.sa",
                            "+966 50 123 4567",
                            "الفرع الرئيسي للشركة");

                        companyInfo.AddBranch(branch);
                        context.Branches.Add(branch);

                        await context.SaveChangesAsync();
                        logger.LogInformation("تم زراعة بيانات الفرع الرئيسي بنجاح");

                        // إضافة مستودع رئيسي
                        if (!context.Warehouses.Any())
                        {
                            logger.LogInformation("بدء زراعة بيانات المستودع الرئيسي");

                            var warehouse = Warehouse.Create(
                                branch.Id,
                                "WH001",
                                "المستودع الرئيسي",
                                "Main Warehouse",
                                "General");

                            warehouse.UpdateBasicInfo(
                                "المستودع الرئيسي",
                                "Main Warehouse",
                                "General",
                                500,
                                10000,
                                DateTime.Parse("2020-01-01"));

                            warehouse.UpdateLocationInfo(
                                "المنطقة الصناعية",
                                "الرياض",
                                "الرياض",
                                "المملكة العربية السعودية",
                                "12345");

                            warehouse.UpdateAdministrativeInfo(
                                "سامي علي",
                                "sami@onyx.sa",
                                "+966 50 987 6543",
                                "المستودع الرئيسي للشركة");

                            branch.AddWarehouse(warehouse);
                            context.Warehouses.Add(warehouse);

                            await context.SaveChangesAsync();
                            logger.LogInformation("تم زراعة بيانات المستودع الرئيسي بنجاح");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "حدث خطأ أثناء زراعة بيانات قاعدة البيانات");
                throw;
            }
        }
    }
} 