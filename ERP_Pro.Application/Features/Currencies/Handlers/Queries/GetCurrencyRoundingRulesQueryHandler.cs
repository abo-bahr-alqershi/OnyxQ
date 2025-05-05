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
    /// معالج استعلام الحصول على قواعد تقريب العملة
    /// </summary>
    public class GetCurrencyRoundingRulesQueryHandler : IRequestHandler<GetCurrencyRoundingRulesQuery, List<CurrencyRoundingRuleDto>>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public GetCurrencyRoundingRulesQueryHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<List<CurrencyRoundingRuleDto>> Handle(GetCurrencyRoundingRulesQuery request, CancellationToken cancellationToken)
        {
            // التحقق من وجود العملة
            var currency = await _currencyRepository.GetByIdAsync(CurrencyId.Create(request.CurrencyId));
            if (currency == null)
            {
                throw new InvalidOperationException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // الحصول على قواعد التقريب
            var rules = await _currencyRepository.GetRoundingRulesAsync(currency.Id);

            // تحويل النتائج إلى DTOs
            return rules.Select(rule => new CurrencyRoundingRuleDto
            {
                Id = rule.Id.Value,
                CurrencyId = rule.CurrencyId.Value,
                RoundingType = rule.RoundingType,
                RoundingUnit = rule.RoundingUnit,
                MinAmount = rule.MinAmount,
                MaxAmount = rule.MaxAmount,
                RoundingAccount = rule.RoundingAccount
            }).ToList();
        }
    }
} 