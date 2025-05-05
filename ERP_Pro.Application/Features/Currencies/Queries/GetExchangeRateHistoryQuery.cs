using System;
using System.Collections.Generic;
using MediatR;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Queries
{
    /// <summary>
    /// استعلام الحصول على تاريخ أسعار الصرف
    /// </summary>
    public class GetExchangeRateHistoryQuery : IRequest<List<ExchangeRateHistoryDto>>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }

        /// <summary>
        /// تاريخ البداية
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// تاريخ النهاية
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// رقم الصفحة
        /// </summary>
        public int? PageNumber { get; set; }

        /// <summary>
        /// حجم الصفحة
        /// </summary>
        public int? PageSize { get; set; }
    }
} 