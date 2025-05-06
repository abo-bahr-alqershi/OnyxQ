using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using ERP_Pro.Application.FinanceAccounting.Repositories;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetCurrencies
{
    /// <summary>
    /// معالج استعلام الحصول على قائمة العملات
    /// </summary>
    public class GetCurrenciesQueryHandler : IRequestHandler<GetCurrenciesQuery, List<CurrencyDto>>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public GetCurrenciesQueryHandler(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<CurrencyDto>> Handle(GetCurrenciesQuery request, CancellationToken cancellationToken)
        {
            var currencies = await _currencyRepository.GetAllAsync(request.ActiveOnly, request.SearchTerm);

            var result = new List<CurrencyDto>();
            
            foreach (var currency in currencies)
            {
                var dto = _mapper.Map<CurrencyDto>(currency);
                
                // الحصول على آخر سعر صرف للعملة
                var latestRate = currency.ExchangeRates?.OrderByDescending(r => r.EffectiveDate).FirstOrDefault();
                if (latestRate != null)
                {
                    dto.ExchangeRate = latestRate.Rate;
                    dto.LastExchangeRateUpdate = latestRate.EffectiveDate;
                }
                
                result.Add(dto);
            }
            
            return result;
        }
    }
} 