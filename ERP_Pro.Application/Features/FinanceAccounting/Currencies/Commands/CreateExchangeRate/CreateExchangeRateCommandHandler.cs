using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.Common.Interfaces;
using ERP_Pro.Application.Contracts.Persistence.FinanceAccounting;
using ERP_Pro.Domain.FinanceAccounting.Entities;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.CreateExchangeRate
{
    /// <summary>
    /// معالج أمر إنشاء سعر صرف جديد
    /// </summary>
    public class CreateExchangeRateCommandHandler : IRequestHandler<CreateExchangeRateCommand, Guid>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrencyExchangeRateRepository _exchangeRateRepository;
        private readonly ICurrentUserService _currentUserService;

        public CreateExchangeRateCommandHandler(
            ICurrencyRepository currencyRepository,
            ICurrencyExchangeRateRepository exchangeRateRepository,
            ICurrentUserService currentUserService)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
            _exchangeRateRepository = exchangeRateRepository ?? throw new ArgumentNullException(nameof(exchangeRateRepository));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));
        }

        public async Task<Guid> Handle(CreateExchangeRateCommand request, CancellationToken cancellationToken)
        {
            // التحقق من وجود العملة
            var currency = await _currencyRepository.GetByIdAsync(request.CurrencyId);
            if (currency == null)
            {
                throw new KeyNotFoundException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // إنشاء كيان سعر الصرف
            var exchangeRate = CurrencyExchangeRate.Create(
                request.CurrencyId,
                request.EffectiveDate,
                request.RateType,
                request.Rate,
                request.Source ?? "Manual",
                request.Notes,
                _currentUserService.UserId);

            // إضافة سعر الصرف في المستودع
            var result = await _exchangeRateRepository.AddAsync(exchangeRate);

            return result.Id;
        }
    }
} 