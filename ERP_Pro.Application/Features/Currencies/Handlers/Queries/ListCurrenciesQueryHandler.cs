using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.Currencies.Dtos;
using ERP_Pro.Application.Features.Currencies.Queries;

namespace ERP_Pro.Application.Features.Currencies.Handlers.Queries
{
    /// <summary>
    /// معالج استعلام قائمة العملات
    /// </summary>
    public class ListCurrenciesQueryHandler : IRequestHandler<ListCurrenciesQuery, List<CurrencyDto>>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public ListCurrenciesQueryHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<List<CurrencyDto>> Handle(ListCurrenciesQuery request, CancellationToken cancellationToken)
        {
            var currencies = await _currencyRepository.ListAsync(
                request.SearchTerm,
                request.ActiveOnly,
                request.PageNumber,
                request.PageSize);

            return currencies.Select(currency => new CurrencyDto
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
            }).ToList();
        }
    }
} 