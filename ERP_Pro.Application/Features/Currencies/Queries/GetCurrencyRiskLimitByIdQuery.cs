using System;
using MediatR;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Queries
{
    /// <summary>
    /// استعلام الحصول على حد مخاطر العملة بالمعرف
    /// </summary>
    public class GetCurrencyRiskLimitByIdQuery : IRequest<CurrencyRiskLimitDto>
    {
        /// <summary>
        /// معرف حد المخاطر
        /// </summary>
        public Guid Id { get; set; }
    }
} 