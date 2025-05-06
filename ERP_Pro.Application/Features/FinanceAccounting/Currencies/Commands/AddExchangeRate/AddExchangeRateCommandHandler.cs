using System;
using System.Threading;
using System.Threading.Tasks;
using ERP_Pro.Application.FinanceAccounting.Repositories;
using ERP_Pro.Domain.FinanceAccounting.Entities;
using MediatR;

namespace ERP_Pro.Application.Features.FinanceAccounting.Currencies.Commands.AddExchangeRate
{
    /// <summary>
    /// معالج أمر إضافة سعر صرف جديد للعملة
    /// </summary>
    public class AddExchangeRateCommandHandler : IRequestHandler<AddExchangeRateCommand, Guid>
    {
        private readonly ICurrencyRepository _currencyRepository;

        public AddExchangeRateCommandHandler(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? throw new ArgumentNullException(nameof(currencyRepository));
        }

        public async Task<Guid> Handle(AddExchangeRateCommand request, CancellationToken cancellationToken)
        {
            // التأكد من وجود العملة
            var currency = await _currencyRepository.GetByIdAsync(request.CurrencyId);
            if (currency == null)
            {
                throw new Exception($"العملة برقم {request.CurrencyId} غير موجودة");
            }

            // التحقق من صحة سعر الصرف
            if (request.Rate <= 0)
            {
                throw new Exception("سعر الصرف يجب أن يكون أكبر من صفر");
            }

            // إنشاء كيان سعر صرف جديد
            var exchangeRate = CurrencyExchangeRate.Create(
                request.CurrencyId,
                request.EffectiveDate,
                request.RateType,
                request.Rate,
                request.Source,
                request.Notes);

            // إضافة سعر الصرف للعملة
            await _currencyRepository.AddExchangeRateAsync(exchangeRate);

            return exchangeRate.Id;
        }
    }
} 