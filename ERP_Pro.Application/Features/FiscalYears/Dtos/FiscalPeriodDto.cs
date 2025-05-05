using System;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Features.FiscalYears.Dtos
{
    /// <summary>
    /// DTO للفترة المحاسبية
    /// </summary>
    public class FiscalPeriodDto
    {
        /// <summary>
        /// رقم التعريف
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// رقم السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; set; }

        /// <summary>
        /// رقم الفترة
        /// </summary>
        public int PeriodNumber { get; set; }

        /// <summary>
        /// رمز الفترة
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم الفترة
        /// </summary>
        public string NameAr { get; set; }

        /// <summary>
        /// اسم الفترة بالإنجليزية
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
        /// نوع الفترة
        /// </summary>
        public FiscalPeriodTypeEnum PeriodType { get; set; }

        /// <summary>
        /// نوع الفترة (للعرض)
        /// </summary>
        public string PeriodTypeName => PeriodType.ToString();

        /// <summary>
        /// حالة الفترة
        /// </summary>
        public FiscalPeriodStatusEnum Status { get; set; }

        /// <summary>
        /// حالة الفترة (للعرض)
        /// </summary>
        public string StatusName => Status.ToString();

        /// <summary>
        /// الفترة الافتراضية للإقفال
        /// </summary>
        public bool IsClosingDefault { get; set; }

        /// <summary>
        /// رمز الفترة في التقويم
        /// </summary>
        public string CalendarReference { get; set; }

        /// <summary>
        /// تاريخ آخر إغلاق
        /// </summary>
        public DateTime? LastClosingDate { get; set; }

        /// <summary>
        /// تاريخ آخر إعادة فتح
        /// </summary>
        public DateTime? LastReopenDate { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// المستخدم الذي أنشأ الفترة المحاسبية
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// تاريخ إنشاء الفترة المحاسبية
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل للفترة المحاسبية
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// تاريخ آخر تعديل للفترة المحاسبية
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// عدد القيود المحاسبية في الفترة
        /// </summary>
        public int JournalEntriesCount { get; set; }
    }
} 