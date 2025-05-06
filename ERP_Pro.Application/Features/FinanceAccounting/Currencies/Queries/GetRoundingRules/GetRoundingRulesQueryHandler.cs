using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetRoundingRules
{
    /// <summary>
    /// معالج استعلام للحصول على قواعد تقريب العملة
    /// </summary>
    public class GetRoundingRulesQueryHandler : IRequestHandler<GetRoundingRulesQuery, List<CurrencyRoundingRuleDto>>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public GetRoundingRulesQueryHandler(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<CurrencyRoundingRuleDto>> Handle(GetRoundingRulesQuery request, CancellationToken cancellationToken)
        {
            // التحقق من وجود العملة
            var currency = await _currencyRepository.GetByIdAsync(request.CurrencyId);
            if (currency == null)
            {
                throw new KeyNotFoundException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // الحصول على قواعد التقريب
            var roundingRules = await _currencyRepository.GetRoundingRulesAsync(request.CurrencyId);

            // تحويل النتائج إلى DTO
            return _mapper.Map<List<CurrencyRoundingRuleDto>>(roundingRules);
        }
    }
} 