using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.Currencies.Dtos;
using ERP_Pro.Application.Features.Currencies.Queries;

namespace ERP_Pro.Application.Features.Currencies.Handlers.Queries
{
    /// <summary>
    /// معالج استعلام الحصول على عملة بالرمز
    /// </summary>
    public class GetCurrencyByCodeQueryHandler : IRequestHandler<GetCurrencyByCodeQuery, CurrencyDto>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public GetCurrencyByCodeQueryHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<CurrencyDto> Handle(GetCurrencyByCodeQuery request, CancellationToken cancellationToken)
        {
            var currency = await _currencyRepository.GetByCodeAsync(request.Code);
            if (currency == null)
            {
                throw new InvalidOperationException($"العملة بالرمز {request.Code} غير موجودة");
            }

            return new CurrencyDto
            {
                Id = currency.Id.Value,
                Code = currency.Code,
                IsoCode = currency.IsoCode,
                NameAr = currency.NameAr,
                NameEn = currency.NameEn,
                Symbol = currency.Symbol,
                Country = currency.Country,
                IsBaseCurrency = currency.IsBaseCurrency,
                Status = currency.Status,
                DecimalPlaces = currency.DecimalPlaces,
                ThousandsSeparator = currency.ThousandsSeparator,
                DecimalSeparator = currency.DecimalSeparator,
                SymbolPosition = currency.SymbolPosition,
                FractionName = currency.FractionName,
                FractionValue = currency.FractionValue,
                UseSpaceBetweenSymbolAndValue = currency.UseSpaceBetweenSymbolAndValue,
                ShowTrailingZeros = currency.ShowTrailingZeros,
                CurrentExchangeRate = currency.CurrentExchangeRate,
                LastExchangeRateUpdate = currency.LastExchangeRateUpdate,
                Notes = currency.Notes
            };
        }
    }
} 