using System;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalYears.ViewModels
{
    /// <summary>
    /// نموذج عنصر قائمة السنوات المالية
    /// </summary>
    public class FiscalYearListItemDto
    {
        /// <summary>
        /// المعرف
        /// </summary>
        public Guid Id { get; set; }

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
        /// عدد الفترات المحاسبية
        /// </summary>
        public int PeriodsCount { get; set; }

        /// <summary>
        /// عدد الفترات المفتوحة
        /// </summary>
        public int OpenPeriodsCount { get; set; }

        /// <summary>
        /// الحالة كنسبة مئوية (مدى اكتمال السنة المالية)
        /// </summary>
        public int CompletionPercentage { get; set; }
    }
} 