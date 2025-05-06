using System;
using MediatR;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.CheckPeriodStatusForDate
{
    /// <summary>
    /// استعلام للتحقق من حالة الفترة لتاريخ محدد
    /// </summary>
    public class CheckPeriodStatusForDateQuery : IRequest<PeriodStatusDto>
    {
        /// <summary>
        /// التاريخ المراد التحقق منه
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// معرف السنة المالية (اختياري: للبحث في سنة محددة فقط)
        /// </summary>
        public Guid? FiscalYearId { get; set; }
    }
} 