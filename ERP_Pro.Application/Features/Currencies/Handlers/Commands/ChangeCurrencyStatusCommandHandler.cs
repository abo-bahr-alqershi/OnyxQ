using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Abstractions.Base;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.Currencies.Commands;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Application.Features.Currencies.Handlers.Commands
{
    /// <summary>
    /// معالج أمر تغيير حالة العملة
    /// </summary>
    public class ChangeCurrencyStatusCommandHandler : IRequestHandler<ChangeCurrencyStatusCommand, bool>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrentUser _currentUser;

        public ChangeCurrencyStatusCommandHandler(ICurrencyRepository currencyRepository, ICurrentUser currentUser)
        {
            _currencyRepository = currencyRepository;
            _currentUser = currentUser;
        }

        public async Task<bool> Handle(ChangeCurrencyStatusCommand request, CancellationToken cancellationToken)
        {
            // الحصول على العملة
            var currency = await _currencyRepository.GetByIdAsync(CurrencyId.Create(request.Id));
            if (currency == null)
            {
                throw new InvalidOperationException($"العملة بالمعرف {request.Id} غير موجودة");
            }

            // تغيير حالة العملة
            currency.ChangeStatus(request.NewStatus);

            // تعيين معلومات المستخدم
            typeof(Domain.Modules.FinanceAccounting.Entities.Currency).GetProperty("LastModifiedBy").SetValue(currency, _currentUser.UserId);

            // حفظ التغييرات
            await _currencyRepository.UpdateAsync(currency);
            await _currencyRepository.SaveChangesAsync();

            return true;
        }
    }
} 