using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetExchangeRateHistory
{
    /// <summary>
    /// معالج استعلام للحصول على تاريخ أسعار صرف عملة معينة
    /// </summary>
    public class GetExchangeRateHistoryQueryHandler : IRequestHandler<GetExchangeRateHistoryQuery, List<ExchangeRateHistoryDto>>
    {
        private readonly ICurrencyExchangeRateRepository _exchangeRateRepository;
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public GetExchangeRateHistoryQueryHandler(
            ICurrencyExchangeRateRepository exchangeRateRepository,
            ICurrencyRepository currencyRepository,
            IMapper mapper)
        {
            _exchangeRateRepository = exchangeRateRepository ?? throw new ArgumentNullException(nameof(exchangeRateRepository));
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<ExchangeRateHistoryDto>> Handle(GetExchangeRateHistoryQuery request, CancellationToken cancellationToken)
        {
            // التحقق من وجود العملة
            var currency = await _currencyRepository.GetByIdAsync(request.CurrencyId);
            if (currency == null)
            {
                throw new KeyNotFoundException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // الحصول على سجلات أسعار الصرف
            var exchangeRates = await _exchangeRateRepository.GetExchangeRateHistoryAsync(
                request.CurrencyId,
                request.StartDate,
                request.EndDate,
                request.RateType,
                request.PageNumber,
                request.PageSize);

            // تحويل النتائج إلى DTO
            var result = _mapper.Map<List<ExchangeRateHistoryDto>>(exchangeRates);
            
            // إضافة معلومات العملة لكل سجل
            foreach (var item in result)
            {
                item.CurrencyCode = currency.Code;
            }

            return result;
        }
    }
} 