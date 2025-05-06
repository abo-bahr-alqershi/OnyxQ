using System;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels
{
    /// <summary>
    /// نموذج حالة الفترة المحاسبية
    /// </summary>
    public class PeriodStatusDto
    {
        /// <summary>
        /// معرف الفترة المحاسبية
        /// </summary>
        public Guid? FiscalPeriodId { get; set; }

        /// <summary>
        /// معرف السنة المالية
        /// </summary>
        public Guid? FiscalYearId { get; set; }

        /// <summary>
        /// رمز السنة المالية
        /// </summary>
        public string FiscalYearCode { get; set; }

        /// <summary>
        /// رقم الفترة التسلسلي
        /// </summary>
        public int? PeriodNumber { get; set; }

        /// <summary>
        /// رمز الفترة
        /// </summary>
        public string PeriodCode { get; set; }

        /// <summary>
        /// اسم الفترة
        /// </summary>
        public string PeriodName { get; set; }

        /// <summary>
        /// تاريخ الاستعلام
        /// </summary>
        public DateTime QueryDate { get; set; }

        /// <summary>
        /// حالة الفترة
        /// </summary>
        public FiscalPeriodStatusEnum Status { get; set; }

        /// <summary>
        /// اسم حالة الفترة
        /// </summary>
        public string StatusName { get; set; }

        /// <summary>
        /// مؤمنة
        /// </summary>
        public bool IsLocked { get; set; }

        /// <summary>
        /// نوع التأمين (إذا كانت مؤمنة)
        /// </summary>
        public LockTypeEnum? LockType { get; set; }

        /// <summary>
        /// اسم نوع التأمين
        /// </summary>
        public string LockTypeName { get; set; }

        /// <summary>
        /// سبب التأمين
        /// </summary>
        public string LockReason { get; set; }

        /// <summary>
        /// الفترة موجودة
        /// </summary>
        public bool PeriodExists { get; set; }

        /// <summary>
        /// التاريخ ضمن فترة محاسبية
        /// </summary>
        public bool DateInPeriod { get; set; }

        /// <summary>
        /// التاريخ ضمن سنة مالية
        /// </summary>
        public bool DateInFiscalYear { get; set; }
    }
} 