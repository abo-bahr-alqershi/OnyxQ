using System;
using MediatR;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.GetFiscalPeriodById
{
    /// <summary>
    /// استعلام جلب فترة محاسبية بالمعرف
    /// </summary>
    public class GetFiscalPeriodByIdQuery : IRequest<FiscalPeriodDetailsDto>
    {
        /// <summary>
        /// معرف الفترة المحاسبية
        /// </summary>
        public Guid Id { get; set; }
    }
} 