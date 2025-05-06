using System.Collections.Generic;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetCurrencies
{
    /// <summary>
    /// استعلام للحصول على قائمة العملات
    /// </summary>
    public class GetCurrenciesQuery : IRequest<List<CurrencyDto>>
    {
        public bool? ActiveOnly { get; set; }
        public string SearchTerm { get; set; }
    }
} 