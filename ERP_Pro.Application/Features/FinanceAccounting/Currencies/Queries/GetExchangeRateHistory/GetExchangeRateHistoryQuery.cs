using System;
using System.Collections.Generic;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetExchangeRateHistory
{
    /// <summary>
    /// استعلام للحصول على تاريخ أسعار صرف عملة معينة
    /// </summary>
    public class GetExchangeRateHistoryQuery : IRequest<List<ExchangeRateHistoryDto>>
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; set; }
        
        /// <summary>
        /// تاريخ البداية (اختياري)
        /// </summary>
        public DateTime? StartDate { get; set; }
        
        /// <summary>
        /// تاريخ النهاية (اختياري)
        /// </summary>
        public DateTime? EndDate { get; set; }
        
        /// <summary>
        /// نوع سعر الصرف (اختياري)
        /// </summary>
        public string RateType { get; set; }
        
        /// <summary>
        /// رقم الصفحة (للصفحات)
        /// </summary>
        public int? PageNumber { get; set; }
        
        /// <summary>
        /// حجم الصفحة (للصفحات)
        /// </summary>
        public int? PageSize { get; set; }
    }
} 