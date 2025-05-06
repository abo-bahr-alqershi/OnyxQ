using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using ERP_Pro.Application.FinanceAccounting.Repositories;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetCurrencyById
{
    /// <summary>
    /// معالج استعلام الحصول على تفاصيل عملة محددة بالمعرف
    /// </summary>
    public class GetCurrencyByIdQueryHandler : IRequestHandler<GetCurrencyByIdQuery, CurrencyDetailsDto>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public GetCurrencyByIdQueryHandler(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CurrencyDetailsDto> Handle(GetCurrencyByIdQuery request, CancellationToken cancellationToken)
        {
            var currency = await _currencyRepository.GetByIdAsync(request.Id);
            if (currency == null)
            {
                throw new Exception($"العملة برقم {request.Id} غير موجودة");
            }

            var result = _mapper.Map<CurrencyDetailsDto>(currency);

            // استرجاع أسعار الصرف للعملة
            var exchangeRates = await _currencyRepository.GetExchangeRatesAsync(currency.Id);
            result.ExchangeRates = _mapper.Map<System.Collections.Generic.List<CurrencyExchangeRateDto>>(exchangeRates);

            // يمكن إضافة معلومات إضافية هنا مثل أسماء الحسابات المرتبطة

            return result;
        }
    }
} 