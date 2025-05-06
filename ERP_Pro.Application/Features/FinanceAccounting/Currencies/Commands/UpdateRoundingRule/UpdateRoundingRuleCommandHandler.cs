using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using ERP_Pro.Shared.Enums.Domain;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateRoundingRule
{
    /// <summary>
    /// معالج أمر تحديث قاعدة تقريب العملة
    /// </summary>
    public class UpdateRoundingRuleCommandHandler : IRequestHandler<UpdateRoundingRuleCommand, bool>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public UpdateRoundingRuleCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
        }

        public async Task<bool> Handle(UpdateRoundingRuleCommand request, CancellationToken cancellationToken)
        {
            // الحصول على قاعدة التقريب
            var roundingRule = await _currencyRepository.GetRoundingRuleByIdAsync(request.Id);
            if (roundingRule == null)
            {
                throw new KeyNotFoundException($"قاعدة التقريب بالمعرف {request.Id} غير موجودة");
            }

            // التحقق من أن العملة المحددة في الطلب هي نفسها المرتبطة بقاعدة التقريب
            if (roundingRule.CurrencyId != request.CurrencyId)
            {
                throw new InvalidOperationException("معرف العملة لا يطابق العملة المرتبطة بقاعدة التقريب");
            }

            // تحويل نوع التقريب من نص إلى قيمة التعداد
            if (!Enum.TryParse(request.RoundingType, out CurrencyRoundingTypeEnum roundingType))
            {
                throw new ArgumentException($"نوع التقريب '{request.RoundingType}' غير صالح");
            }

            // تحديث قاعدة التقريب
            roundingRule.Update(
                roundingType,
                request.Description,
                request.RoundingValue,
                request.DecimalPlaces,
                request.IsActive);

            // حفظ التغييرات
            await _currencyRepository.UpdateRoundingRuleAsync(roundingRule);

            return true;
        }
    }
} 