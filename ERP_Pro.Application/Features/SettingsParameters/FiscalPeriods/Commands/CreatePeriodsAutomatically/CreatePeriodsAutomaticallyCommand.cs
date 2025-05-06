using System;
using MediatR;
using ERP_Pro.Domain.SettingsParameters.Enums;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Commands.CreatePeriodsAutomatically
{
    /// <summary>
    /// أمر إنشاء الفترات المحاسبية تلقائياً
    /// </summary>
    public class CreatePeriodsAutomaticallyCommand : IRequest<Guid[]>
    {
        /// <summary>
        /// معرف السنة المالية
        /// </summary>
        public Guid FiscalYearId { get; set; }

        /// <summary>
        /// نوع الفترات المحاسبية
        /// </summary>
        public FiscalPeriodTypeEnum PeriodType { get; set; }

        /// <summary>
        /// عدد الفترات (اختياري - سيتم حسابه تلقائياً بناءً على نوع الفترة)
        /// </summary>
        public int? PeriodsCount { get; set; }

        /// <summary>
        /// نمط تسمية الفترات العربية (مثال: "الربع {0} {1}")
        /// </summary>
        public string NameArPattern { get; set; }

        /// <summary>
        /// نمط تسمية الفترات الإنجليزية (مثال: "Q{0} {1}")
        /// </summary>
        public string NameEnPattern { get; set; }

        /// <summary>
        /// إضافة فترة إقفال (اختياري)
        /// </summary>
        public bool AddClosingPeriod { get; set; }

        /// <summary>
        /// اسم فترة الإقفال العربية (اختياري)
        /// </summary>
        public string ClosingPeriodNameAr { get; set; }

        /// <summary>
        /// اسم فترة الإقفال الإنجليزية (اختياري)
        /// </summary>
        public string ClosingPeriodNameEn { get; set; }
    }
} 