using System;
using System.Collections.Generic;
using ERP_Pro.Domain.SettingsParameters.Enums;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalYears.ViewModels
{
    /// <summary>
    /// نموذج تفاصيل السنة المالية
    /// </summary>
    public class FiscalYearDetailsDto
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
        /// اسم الشركة
        /// </summary>
        public string CompanyName { get; set; }

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
        /// نمط ترقيم الفترات
        /// </summary>
        public string PeriodNumberingPattern { get; set; }

        /// <summary>
        /// معرف حساب الأرباح المحتجزة
        /// </summary>
        public Guid? RetainedEarningsAccountId { get; set; }

        /// <summary>
        /// اسم حساب الأرباح المحتجزة
        /// </summary>
        public string RetainedEarningsAccountName { get; set; }

        /// <summary>
        /// رقم حساب الأرباح المحتجزة
        /// </summary>
        public string RetainedEarningsAccountNumber { get; set; }

        /// <summary>
        /// معرف حساب نتيجة النشاط
        /// </summary>
        public Guid? IncomeStatementAccountId { get; set; }

        /// <summary>
        /// اسم حساب نتيجة النشاط
        /// </summary>
        public string IncomeStatementAccountName { get; set; }

        /// <summary>
        /// رقم حساب نتيجة النشاط
        /// </summary>
        public string IncomeStatementAccountNumber { get; set; }

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
        /// إعدادات الترحيل
        /// </summary>
        public CarryOverSettingsDto CarryOverSettings { get; set; }

        /// <summary>
        /// إعدادات التأمين
        /// </summary>
        public LockSettingsDto LockSettings { get; set; }

        /// <summary>
        /// الفترات المحاسبية ضمن السنة المالية
        /// </summary>
        public List<FiscalPeriodListItemDto> FiscalPeriods { get; set; }

        /// <summary>
        /// سجلات عمليات الإقفال
        /// </summary>
        public List<FiscalYearClosingDto> ClosingRecords { get; set; }

        /// <summary>
        /// المنشئ
        /// </summary>
        public FiscalYearDetailsDto()
        {
            FiscalPeriods = new List<FiscalPeriodListItemDto>();
            ClosingRecords = new List<FiscalYearClosingDto>();
        }
    }

    /// <summary>
    /// نموذج إعدادات ترحيل الأرصدة
    /// </summary>
    public class CarryOverSettingsDto
    {
        /// <summary>
        /// ترحيل أرصدة الأصول
        /// </summary>
        public bool CarryOverAssets { get; set; }

        /// <summary>
        /// ترحيل أرصدة الخصوم
        /// </summary>
        public bool CarryOverLiabilities { get; set; }

        /// <summary>
        /// ترحيل أرصدة حقوق الملكية
        /// </summary>
        public bool CarryOverEquity { get; set; }

        /// <summary>
        /// ترحيل أرصدة العملاء
        /// </summary>
        public bool CarryOverCustomers { get; set; }

        /// <summary>
        /// ترحيل أرصدة الموردين
        /// </summary>
        public bool CarryOverVendors { get; set; }

        /// <summary>
        /// ترحيل أرصدة المخزون
        /// </summary>
        public bool CarryOverInventory { get; set; }

        /// <summary>
        /// ترحيل أرصدة البنود المفتوحة
        /// </summary>
        public bool CarryOverOpenItems { get; set; }

        /// <summary>
        /// ترحيل الميزانيات التقديرية
        /// </summary>
        public bool CarryOverBudgets { get; set; }

        /// <summary>
        /// إضافة قيود التسوية التلقائية قبل الترحيل
        /// </summary>
        public bool AutoAdjustBeforeCarryOver { get; set; }

        /// <summary>
        /// طريقة حساب الأرباح المحتجزة
        /// </summary>
        public string RetainedEarningsMethod { get; set; }
    }

    /// <summary>
    /// نموذج إعدادات التأمين
    /// </summary>
    public class LockSettingsDto
    {
        /// <summary>
        /// تأمين تلقائي للفترات المغلقة
        /// </summary>
        public bool AutoLockClosedPeriods { get; set; }

        /// <summary>
        /// السماح بإعادة فتح الفترات المغلقة من قبل المستخدمين المصرح لهم
        /// </summary>
        public bool AllowReopenByAuthorizedUsers { get; set; }

        /// <summary>
        /// تأمين الفترات بعد مرور فترة محددة
        /// </summary>
        public bool LockPeriodsAfterDuration { get; set; }

        /// <summary>
        /// المدة بالأيام قبل تأمين الفترة تلقائياً
        /// </summary>
        public int DaysBeforeAutoLock { get; set; }

        /// <summary>
        /// إرسال تنبيهات قبل تأمين الفترات
        /// </summary>
        public bool SendNotificationsBeforeLocking { get; set; }

        /// <summary>
        /// منع التعديل في الفترات المغلقة حتى للمسؤولين
        /// </summary>
        public bool PreventEditingInClosedPeriods { get; set; }

        /// <summary>
        /// السماح بالإستثناءات في التأمين
        /// </summary>
        public bool AllowLockExceptions { get; set; }
    }

    /// <summary>
    /// نموذج عملية إقفال السنة المالية
    /// </summary>
    public class FiscalYearClosingDto
    {
        /// <summary>
        /// المعرف
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// معرف السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; set; }

        /// <summary>
        /// تاريخ الإقفال
        /// </summary>
        public DateTime ClosingDate { get; set; }

        /// <summary>
        /// نوع الإقفال
        /// </summary>
        public ClosingTypeEnum ClosingType { get; set; }

        /// <summary>
        /// اسم نوع الإقفال
        /// </summary>
        public string ClosingTypeName { get; set; }

        /// <summary>
        /// حالة الإقفال
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// المستخدم المنفذ للإقفال
        /// </summary>
        public string PerformedBy { get; set; }

        /// <summary>
        /// معرف قيد الإقفال
        /// </summary>
        public Guid? ClosingJournalEntryId { get; set; }

        /// <summary>
        /// رقم قيد الإقفال
        /// </summary>
        public string ClosingJournalEntryNumber { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }
    }
} 