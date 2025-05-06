using System;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetCurrencyById
{
    /// <summary>
    /// استعلام للحصول على تفاصيل عملة محددة بالمعرف
    /// </summary>
    public class GetCurrencyByIdQuery : IRequest<CurrencyDetailsDto>
    {
        public Guid Id { get; }

        public GetCurrencyByIdQuery(Guid id)
        {
            Id = id;
        }
    }
} 