using System.Collections.Generic;
using ERP_Pro.Application.Features.FiscalYears.Dtos;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;

namespace ERP_Pro.Application.Features.FiscalYears.Queries
{
    /// <summary>
    /// استعلام لعرض قائمة السنوات المالية
    /// </summary>
    public class ListFiscalYearsQuery : IRequest<List<FiscalYearDto>>
    {
        /// <summary>
        /// الكلمة المفتاحية للبحث
        /// </summary>
        public string SearchKeyword { get; set; }

        /// <summary>
        /// حالة السنة المالية
        /// </summary>
        public FiscalYearStatusEnum? Status { get; set; }

        /// <summary>
        /// عرض السنوات المالية الافتراضية فقط
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// ترتيب النتائج حسب
        /// </summary>
        public string OrderBy { get; set; } = "StartDate";

        /// <summary>
        /// اتجاه الترتيب
        /// </summary>
        public string OrderDirection { get; set; } = "DESC";

        /// <summary>
        /// رقم الصفحة
        /// </summary>
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// حجم الصفحة
        /// </summary>
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// تضمين الفترات المحاسبية
        /// </summary>
        public bool IncludePeriods { get; set; }
    }
} 