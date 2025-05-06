using System;
using System.Collections.Generic;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetRiskLimits
{
    /// <summary>
    /// استعلام للحصول على حدود مخاطر العملة
    /// </summary>
    public class GetRiskLimitsQuery : IRequest<List<CurrencyRiskLimitDto>>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }
    }
} 