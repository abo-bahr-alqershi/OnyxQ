using System;
using System.Collections.Generic;
using MediatR;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Queries
{
    /// <summary>
    /// استعلام الحصول على قواعد تقريب العملة
    /// </summary>
    public class GetCurrencyRoundingRulesQuery : IRequest<List<CurrencyRoundingRuleDto>>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }
    }
}