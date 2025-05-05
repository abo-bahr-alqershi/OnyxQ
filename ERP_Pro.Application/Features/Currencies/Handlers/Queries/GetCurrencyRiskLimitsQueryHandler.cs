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
    public class GetCurrencyRiskLimitsQueryHandler : IRequestHandler<GetCurrencyRiskLimitsQuery, List<CurrencyRiskLimitDto>>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public GetCurrencyRiskLimitsQueryHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<List<CurrencyRiskLimitDto>> Handle(GetCurrencyRiskLimitsQuery request, CancellationToken cancellationToken)
        {
            var currency = await _currencyRepository.GetByIdAsync(CurrencyId.Create(request.CurrencyId));
            if (currency == null)
            {
                throw new InvalidOperationException($"Currency with ID {request.CurrencyId} not found");
            }

            var riskLimits = await _currencyRepository.GetRiskLimitsAsync(currency.Id, request.ActiveOnly);

            return riskLimits.Select(rl => new CurrencyRiskLimitDto
            {
                Id = rl.Id.Value,
                CurrencyId = rl.CurrencyId.Value,
                CurrencyCode = currency.Code,
                CurrencyName = currency.NameAr,
                MaxDailyFluctuation = rl.MaxDailyFluctuation,
                AlertThreshold = rl.AlertThreshold,
                MaxExposure = rl.MaxExposure,
                IsActive = rl.IsActive,
                Notes = rl.Notes,
                CreatedOn = rl.CreatedOn,
                CreatedBy = rl.CreatedBy,
                LastModifiedOn = rl.LastModifiedOn,
                LastModifiedBy = rl.LastModifiedBy
            }).ToList();
        }
    }
} 