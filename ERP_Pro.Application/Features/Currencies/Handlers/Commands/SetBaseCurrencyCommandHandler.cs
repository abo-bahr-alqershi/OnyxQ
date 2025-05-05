using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Abstractions.Base;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.Currencies.Commands;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Application.Features.Currencies.Handlers.Commands
{
    /// <summary>
    /// معالج أمر تعيين العملة الأساسية
    /// </summary>
    public class SetBaseCurrencyCommandHandler : IRequestHandler<SetBaseCurrencyCommand, bool>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrentUser _currentUser;

        public SetBaseCurrencyCommandHandler(ICurrencyRepository currencyRepository, ICurrentUser currentUser)
        {
            _currencyRepository = currencyRepository;
            _currentUser = currentUser;
        }

        public async Task<bool> Handle(SetBaseCurrencyCommand request, CancellationToken cancellationToken)
        {
            // الحصول على العملة
            var currency = await _currencyRepository.GetByIdAsync(CurrencyId.Create(request.Id));
            if (currency == null)
            {
                throw new InvalidOperationException($"العملة بالمعرف {request.Id} غير موجودة");
            }

            // التحقق من أن العملة نشطة
            if (currency.Status != CurrencyStatusEnum.Active)
            {
                throw new InvalidOperationException("لا يمكن تعيين عملة غير نشطة كعملة أساسية");
            }

            // الحصول على العملة الأساسية الحالية إن وجدت
            var currentBaseCurrency = await _currencyRepository.GetBaseCurrencyAsync();
            CurrencyId previousBaseCurrencyId = null;
            
            if (currentBaseCurrency != null)
            {
                // لا نفعل شيء إذا كانت هي بالفعل العملة الأساسية
                if (currentBaseCurrency.Id.Value == request.Id)
                {
                    return true;
                }
                
                previousBaseCurrencyId = currentBaseCurrency.Id;
                
                // إلغاء تعيين العملة الأساسية الحالية
                currentBaseCurrency.UnsetAsBaseCurrency();
                
                // تعيين معلومات المستخدم للعملة الأساسية السابقة
                typeof(Domain.Modules.FinanceAccounting.Entities.Currency).GetProperty("LastModifiedBy").SetValue(currentBaseCurrency, _currentUser.UserId);
                
                // حفظ التغييرات للعملة الأساسية السابقة
                await _currencyRepository.UpdateAsync(currentBaseCurrency);
            }

            // تعيين العملة الجديدة كعملة أساسية
            currency.SetAsBaseCurrency(previousBaseCurrencyId);
            
            // إذا لزم الأمر، يمكن هنا تعديل سعر الصرف للعملة الأساسية ليكون 1
            currency.UpdateExchangeRate(1, ExchangeRateTypeEnum.Base, ExchangeRateSourceEnum.Manual);

            // تعيين معلومات المستخدم
            typeof(Domain.Modules.FinanceAccounting.Entities.Currency).GetProperty("LastModifiedBy").SetValue(currency, _currentUser.UserId);

            // حفظ التغييرات
            await _currencyRepository.UpdateAsync(currency);
            await _currencyRepository.SaveChangesAsync();

            return true;
        }
    }
} 