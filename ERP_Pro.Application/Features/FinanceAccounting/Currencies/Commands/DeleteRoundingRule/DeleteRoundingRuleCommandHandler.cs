using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.DeleteRoundingRule
{
    /// <summary>
    /// معالج أمر حذف قاعدة تقريب
    /// </summary>
    public class DeleteRoundingRuleCommandHandler : IRequestHandler<DeleteRoundingRuleCommand, bool>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public DeleteRoundingRuleCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
        }

        public async Task<bool> Handle(DeleteRoundingRuleCommand request, CancellationToken cancellationToken)
        {
            // التحقق من وجود قاعدة التقريب
            var roundingRule = await _currencyRepository.GetRoundingRuleByIdAsync(request.Id);
            if (roundingRule == null)
            {
                throw new KeyNotFoundException($"قاعدة التقريب بالمعرف {request.Id} غير موجودة");
            }

            // حذف قاعدة التقريب
            await _currencyRepository.DeleteRoundingRuleAsync(request.Id);

            return true;
        }
    }
} 