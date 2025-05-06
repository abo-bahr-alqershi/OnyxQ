using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using ERP_Pro.Domain.FinanceAccounting.Entities;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateRoundingRule
{
    /// <summary>
    /// معالج أمر إنشاء قاعدة تقريب جديدة للعملة
    /// </summary>
    public class CreateRoundingRuleCommandHandler : IRequestHandler<CreateRoundingRuleCommand, Guid>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CreateRoundingRuleCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
        }

        public async Task<Guid> Handle(CreateRoundingRuleCommand request, CancellationToken cancellationToken)
        {
            // التحقق من وجود العملة
            var currency = await _currencyRepository.GetByIdAsync(request.CurrencyId);
            if (currency == null)
            {
                throw new KeyNotFoundException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // تحويل نوع التقريب من نص إلى قيمة التعداد
            if (!Enum.TryParse(request.RoundingType, out CurrencyRoundingTypeEnum roundingType))
            {
                throw new ArgumentException($"نوع التقريب '{request.RoundingType}' غير صالح");
            }

            // إنشاء كيان قاعدة التقريب
            var roundingRule = CurrencyRoundingRule.Create(
                request.CurrencyId,
                roundingType,
                request.Description,
                request.RoundingValue,
                request.DecimalPlaces,
                request.IsActive);

            // إضافة قاعدة التقريب في المستودع
            var result = await _currencyRepository.AddRoundingRuleAsync(roundingRule);

            return result.Id;
        }
    }
} 