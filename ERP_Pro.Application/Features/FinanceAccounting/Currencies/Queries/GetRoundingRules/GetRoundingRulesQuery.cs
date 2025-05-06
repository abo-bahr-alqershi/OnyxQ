using System;
using System.Collections.Generic;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetRoundingRules
{
    /// <summary>
    /// استعلام للحصول على قواعد تقريب العملة
    /// </summary>
    public class GetRoundingRulesQuery : IRequest<List<CurrencyRoundingRuleDto>>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }
    }
} 