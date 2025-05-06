using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using ERP_Pro.Domain.FinanceAccounting.Entities;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateRiskLimit
{
    /// <summary>
    /// معالج أمر إنشاء حد مخاطر جديد للعملة
    /// </summary>
    public class CreateRiskLimitCommandHandler : IRequestHandler<CreateRiskLimitCommand, Guid>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrentUserService _currentUserService;

        public CreateRiskLimitCommandHandler(
            ICurrencyRepository currencyRepository,
            ICurrentUserService currentUserService)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));
        }

        public async Task<Guid> Handle(CreateRiskLimitCommand request, CancellationToken cancellationToken)
        {
            // التحقق من وجود العملة
            var currency = await _currencyRepository.GetByIdAsync(request.CurrencyId);
            if (currency == null)
            {
                throw new KeyNotFoundException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // إنشاء كيان حد المخاطر
            var riskLimit = CurrencyRiskLimit.Create(
                request.CurrencyId,
                request.MinRate,
                request.MaxRate,
                request.WarningThreshold,
                request.TargetRate,
                request.AlertEnabled,
                _currentUserService.UserId);

            // إضافة حد المخاطر في المستودع
            var result = await _currencyRepository.AddRiskLimitAsync(riskLimit);

            return result.Id;
        }
    }
} 