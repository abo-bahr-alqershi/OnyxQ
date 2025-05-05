using System;
using System.Collections.Generic;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Features.FiscalYears.Dtos
{
    /// <summary>
    /// DTO للسنة المالية
    /// </summary>
    public class FiscalYearDto
    {
        /// <summary>
        /// رقم التعريف
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// رمز السنة المالية
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم السنة المالية
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
        /// المدة بالأيام
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// نوع التقويم
        /// </summary>
        public CalendarTypeEnum CalendarType { get; set; }

        /// <summary>
        /// نوع التقويم (للعرض)
        /// </summary>
        public string CalendarTypeName => CalendarType.ToString();

        /// <summary>
        /// حالة السنة المالية
        /// </summary>
        public FiscalYearStatusEnum Status { get; set; }

        /// <summary>
        /// حالة السنة المالية (للعرض)
        /// </summary>
        public string StatusName => Status.ToString();

        /// <summary>
        /// السنة المالية الافتراضية
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// نمط ترقيم الفترات
        /// </summary>
        public string PeriodNumberingPattern { get; set; }

        /// <summary>
        /// حساب الأرباح المحتجزة
        /// </summary>
        public string RetainedEarningsAccountId { get; set; }

        /// <summary>
        /// حساب نتيجة النشاط
        /// </summary>
        public string IncomeStatementAccountId { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// المستخدم الذي أنشأ السنة المالية
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// تاريخ إنشاء السنة المالية
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل للسنة المالية
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// تاريخ آخر تعديل للسنة المالية
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// إعدادات الترحيل
        /// </summary>
        public string CarryOverSettings { get; set; }

        /// <summary>
        /// إعدادات التأمين
        /// </summary>
        public string LockSettings { get; set; }

        /// <summary>
        /// عدد الفترات المحاسبية
        /// </summary>
        public int PeriodsCount { get; set; }

        /// <summary>
        /// الفترات المحاسبية للسنة المالية
        /// </summary>
        public List<FiscalPeriodDto> FiscalPeriods { get; set; } = new List<FiscalPeriodDto>();
    }
} 