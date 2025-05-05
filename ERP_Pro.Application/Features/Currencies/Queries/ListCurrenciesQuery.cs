using System.Collections.Generic;
using MediatR;
using ERP_Pro.Application.Features.Currencies.Dtos;

namespace ERP_Pro.Application.Features.Currencies.Queries
{
    /// <summary>
    /// استعلام قائمة العملات
    /// </summary>
    public class ListCurrenciesQuery : IRequest<List<CurrencyDto>>
    {
        /// <summary>
        /// البحث بالاسم
        /// </summary>
        public string SearchTerm { get; set; }

        /// <summary>
        /// عرض العملات النشطة فقط
        /// </summary>
        public bool? ActiveOnly { get; set; }

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