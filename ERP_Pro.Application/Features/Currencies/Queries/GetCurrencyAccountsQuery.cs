using System;
using System.Collections.Generic;
using MediatR;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Queries
{
    /// <summary>
    /// استعلام الحصول على حسابات العملة
    /// </summary>
    public class GetCurrencyAccountsQuery : IRequest<List<CurrencyAccountDto>>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }
    }
} 