using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using ERP_Pro.Application.Features.FinanceAccounting.Currencies.ViewModels;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Queries.GetRiskLimits
{
    /// <summary>
    /// معالج استعلام للحصول على حدود مخاطر العملة
    /// </summary>
    public class GetRiskLimitsQueryHandler : IRequestHandler<GetRiskLimitsQuery, List<CurrencyRiskLimitDto>>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public GetRiskLimitsQueryHandler(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<List<CurrencyRiskLimitDto>> Handle(GetRiskLimitsQuery request, CancellationToken cancellationToken)
        {
            // التحقق من وجود العملة
            var currency = await _currencyRepository.GetByIdAsync(request.CurrencyId);
            if (currency == null)
            {
                throw new KeyNotFoundException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // الحصول على حدود المخاطر
            var riskLimits = await _currencyRepository.GetRiskLimitsAsync(request.CurrencyId);
            
            // تحويل النتائج إلى DTO
            var result = _mapper.Map<List<CurrencyRiskLimitDto>>(riskLimits);
            
            // إضافة رمز العملة
            foreach (var limit in result)
            {
                limit.CurrencyCode = currency.Code;
            }

            return result;
        }
    }
} 