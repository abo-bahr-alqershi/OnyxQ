using System;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels
{
    /// <summary>
    /// نموذج بيانات الفترة المحاسبية
    /// </summary>
    public class FiscalPeriodDto
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
        /// رمز السنة المالية
        /// </summary>
        public string FiscalYearCode { get; set; }
        
        /// <summary>
        /// اسم السنة المالية
        /// </summary>
        public string FiscalYearName { get; set; }

        /// <summary>
        /// رقم الفترة التسلسلي
        /// </summary>
        public int PeriodNumber { get; set; }

        /// <summary>
        /// رمز الفترة
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم الفترة بالعربية
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
        /// اسم نوع الفترة
        /// </summary>
        public string PeriodTypeName { get; set; }

        /// <summary>
        /// حالة الفترة
        /// </summary>
        public FiscalPeriodStatusEnum Status { get; set; }

        /// <summary>
        /// اسم حالة الفترة
        /// </summary>
        public string StatusName { get; set; }

        /// <summary>
        /// الفترة الافتراضية للإقفال
        /// </summary>
        public bool IsClosingDefault { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// اسم منشئ الفترة المحاسبية
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
        /// عدد عمليات التأمين المرتبطة بالفترة
        /// </summary>
        public int LocksCount { get; set; }

        /// <summary>
        /// عدد التسويات المرتبطة بالفترة
        /// </summary>
        public int AdjustmentsCount { get; set; }
    }
} 