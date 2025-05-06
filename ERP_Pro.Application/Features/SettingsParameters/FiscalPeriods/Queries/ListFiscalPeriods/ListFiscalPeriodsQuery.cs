using System;
using System.Collections.Generic;
using MediatR;
using ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.ViewModels;

namespace ERP_Pro.Application.Features.SettingsParameters.FiscalPeriods.Queries.ListFiscalPeriods
{
    /// <summary>
    /// استعلام جلب قائمة الفترات المحاسبية
    /// </summary>
    public class ListFiscalPeriodsQuery : IRequest<List<FiscalPeriodListItemDto>>
    {
        /// <summary>
        /// معرف السنة المالية (اختياري: لجلب فترات سنة محددة فقط)
        /// </summary>
        public Guid? FiscalYearId { get; set; }
        
        /// <summary>
        /// حالة الفترة (اختياري: لجلب فترات بحالة محددة فقط)
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// كلمة البحث (اختياري: للبحث في الرمز أو الاسم)
        /// </summary>
        public string SearchTerm { get; set; }

        /// <summary>
        /// رقم الصفحة
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// عدد العناصر في الصفحة
        /// </summary>
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// مجال الترتيب
        /// </summary>
        public string SortBy { get; set; } = "PeriodNumber";

        /// <summary>
        /// اتجاه الترتيب (تصاعدي أو تنازلي)
        /// </summary>
        public string SortDirection { get; set; } = "asc";
    }
} 