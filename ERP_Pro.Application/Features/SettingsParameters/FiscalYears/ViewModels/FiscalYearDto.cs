using System;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalYears.ViewModels
{
    /// <summary>
    /// نموذج بيانات السنة المالية
    /// </summary>
    public class FiscalYearDto
    {
        /// <summary>
        /// المعرف
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// معرف الشركة
        /// </summary>
        public Guid CompanyInfoId { get; set; }

        /// <summary>
        /// رمز السنة المالية
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم السنة المالية بالعربية
        /// </summary>
        public string NameAr { get; set; }

        /// <summary>
        /// اسم السنة المالية بالإنجليزية
        /// </summary>
        public string NameEn { get; set; }

        /// <summary>
        /// تاريخ البداية
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// تاريخ النهاية
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// مدة السنة المالية بالأيام
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// نوع التقويم المستخدم
        /// </summary>
        public CalendarTypeEnum CalendarType { get; set; }

        /// <summary>
        /// اسم نوع التقويم المستخدم
        /// </summary>
        public string CalendarTypeName { get; set; }

        /// <summary>
        /// حالة السنة المالية
        /// </summary>
        public FiscalYearStatusEnum Status { get; set; }

        /// <summary>
        /// اسم حالة السنة المالية
        /// </summary>
        public string StatusName { get; set; }

        /// <summary>
        /// السنة المالية الافتراضية
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// معرف حساب الأرباح المحتجزة
        /// </summary>
        public Guid? RetainedEarningsAccountId { get; set; }

        /// <summary>
        /// اسم حساب الأرباح المحتجزة
        /// </summary>
        public string RetainedEarningsAccountName { get; set; }

        /// <summary>
        /// معرف حساب نتيجة النشاط
        /// </summary>
        public Guid? IncomeStatementAccountId { get; set; }

        /// <summary>
        /// اسم حساب نتيجة النشاط
        /// </summary>
        public string IncomeStatementAccountName { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// اسم منشئ السنة المالية
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// تاريخ آخر تحديث
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// اسم آخر من قام بالتعديل
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// عدد الفترات المحاسبية
        /// </summary>
        public int PeriodsCount { get; set; }
    }
} 