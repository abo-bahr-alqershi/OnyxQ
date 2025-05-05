using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Abstractions.Base;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.Currencies.Commands;
using ERP_Pro.Domain.Modules.FinanceAccounting.Entities;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Application.Features.Currencies.Handlers.Commands
{
    /// <summary>
    /// معالج أمر تحديث سعر الصرف
    /// </summary>
    public class UpdateExchangeRateCommandHandler : IRequestHandler<UpdateExchangeRateCommand, bool>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrentUser _currentUser;

        public UpdateExchangeRateCommandHandler(ICurrencyRepository currencyRepository, ICurrentUser currentUser)
        {
            _currencyRepository = currencyRepository;
            _currentUser = currentUser;
        }

        public async Task<bool> Handle(UpdateExchangeRateCommand request, CancellationToken cancellationToken)
        {
            // الحصول على العملة
            var currency = await _currencyRepository.GetByIdAsync(CurrencyId.Create(request.CurrencyId));
            if (currency == null)
            {
                throw new InvalidOperationException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // تحديث سعر الصرف
            currency.UpdateExchangeRate(request.Rate, request.RateType, request.Source);

            // إذا كانت هناك معلومات إضافية للمصدر الخارجي أو ملاحظات
            var historyEntry = currency.ExchangeRateHistory[currency.ExchangeRateHistory.Count - 1];
            historyEntry.SetExternalSourceInfo(request.ExternalSourceId, request.Notes);

            // تعيين معلومات المستخدم
            typeof(Currency).GetProperty("LastModifiedBy").SetValue(currency, _currentUser.UserId);
            typeof(ExchangeRateHistory).GetProperty("RecordedBy").SetValue(historyEntry, _currentUser.UserId);

            // حفظ التغييرات
            await _currencyRepository.UpdateAsync(currency);
            await _currencyRepository.SaveChangesAsync();

            return true;
        }
    }
} 