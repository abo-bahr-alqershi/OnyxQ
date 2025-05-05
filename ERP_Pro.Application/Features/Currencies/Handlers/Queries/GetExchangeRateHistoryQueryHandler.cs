using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.Currencies.Dtos;
using ERP_Pro.Application.Features.Currencies.Queries;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Application.Features.Currencies.Handlers.Queries
{
    /// <summary>
    /// معالج استعلام الحصول على تاريخ أسعار الصرف
    /// </summary>
    public class GetExchangeRateHistoryQueryHandler : IRequestHandler<GetExchangeRateHistoryQuery, List<ExchangeRateHistoryDto>>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public GetExchangeRateHistoryQueryHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<List<ExchangeRateHistoryDto>> Handle(GetExchangeRateHistoryQuery request, CancellationToken cancellationToken)
        {
            // التحقق من وجود العملة
            var currency = await _currencyRepository.GetByIdAsync(CurrencyId.Create(request.CurrencyId));
            if (currency == null)
            {
                throw new InvalidOperationException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // الحصول على تاريخ أسعار الصرف
            var history = await _currencyRepository.GetExchangeRateHistoryAsync(
                currency.Id,
                request.StartDate,
                request.EndDate,
                request.PageNumber,
                request.PageSize);

            // تحويل النتائج إلى DTOs
            return history.Select(item => new ExchangeRateHistoryDto
            {
                Id = item.Id.Value,
                CurrencyId = item.CurrencyId.Value,
                CurrencyCode = currency.Code,
                CurrencyName = currency.NameAr,
                Rate = item.Rate,
                EffectiveDate = item.EffectiveDate,
                RateType = item.RateType,
                Source = item.Source,
                ExternalSourceId = item.ExternalSourceId,
                RecordedBy = item.RecordedBy,
                RecordedOn = item.RecordedOn,
                Notes = item.Notes
            }).ToList();
        }
    }
} 