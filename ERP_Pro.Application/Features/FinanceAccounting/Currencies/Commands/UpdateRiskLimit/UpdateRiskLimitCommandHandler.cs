using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.UpdateRiskLimit
{
    /// <summary>
    /// معالج أمر تحديث حد مخاطر العملة
    /// </summary>
    public class UpdateRiskLimitCommandHandler : IRequestHandler<UpdateRiskLimitCommand, bool>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrentUserService _currentUserService;

        public UpdateRiskLimitCommandHandler(
            ICurrencyRepository currencyRepository,
            ICurrentUserService currentUserService)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));
        }

        public async Task<bool> Handle(UpdateRiskLimitCommand request, CancellationToken cancellationToken)
        {
            // الحصول على حد المخاطر
            var riskLimit = await _currencyRepository.GetRiskLimitByIdAsync(request.Id);
            if (riskLimit == null)
            {
                throw new KeyNotFoundException($"حد المخاطر بالمعرف {request.Id} غير موجود");
            }

            // التحقق من أن العملة المحددة في الطلب هي نفسها المرتبطة بحد المخاطر
            if (riskLimit.CurrencyId != request.CurrencyId)
            {
                throw new InvalidOperationException("معرف العملة لا يطابق العملة المرتبطة بحد المخاطر");
            }

            // تحديث حد المخاطر
            riskLimit.Update(
                request.MinRate,
                request.MaxRate,
                request.WarningThreshold,
                request.TargetRate,
                request.AlertEnabled,
                _currentUserService.UserId);

            // حفظ التغييرات
            await _currencyRepository.UpdateRiskLimitAsync(riskLimit);

            return true;
        }
    }
} 