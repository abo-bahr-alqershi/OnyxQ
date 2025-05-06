using System;
using MediatR;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.GetCurrentFiscalPeriod
{
    /// <summary>
    /// استعلام جلب الفترة المحاسبية الحالية
    /// </summary>
    public class GetCurrentFiscalPeriodQuery : IRequest<FiscalPeriodDto>
    {
        /// <summary>
        /// معرف السنة المالية (اختياري: للبحث في سنة محددة فقط)
        /// </summary>
        public Guid? FiscalYearId { get; set; }
    }
} 