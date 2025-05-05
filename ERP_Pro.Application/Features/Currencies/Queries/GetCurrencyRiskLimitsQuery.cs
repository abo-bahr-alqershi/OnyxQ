using System;
using System.Collections.Generic;
using MediatR;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Queries
{
    /// <summary>
    /// استعلام الحصول على حدود مخاطر العملة
    /// </summary>
    public class GetCurrencyRiskLimitsQuery : IRequest<List<CurrencyRiskLimitDto>>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }

        /// <summary>
        /// تصفية حسب الحالة النشطة فقط
        /// </summary>
        public bool? ActiveOnly { get; set; }
    }
} 