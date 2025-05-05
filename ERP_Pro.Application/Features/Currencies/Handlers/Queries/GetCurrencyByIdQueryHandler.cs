using System;
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
    /// معالج استعلام الحصول على عملة بالمعرف
    /// </summary>
    public class GetCurrencyByIdQueryHandler : IRequestHandler<GetCurrencyByIdQuery, CurrencyDto>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public GetCurrencyByIdQueryHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<CurrencyDto> Handle(GetCurrencyByIdQuery request, CancellationToken cancellationToken)
        {
            var currency = await _currencyRepository.GetByIdAsync(CurrencyId.Create(request.Id));
            if (currency == null)
            {
                throw new InvalidOperationException($"العملة بالمعرف {request.Id} غير موجودة");
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