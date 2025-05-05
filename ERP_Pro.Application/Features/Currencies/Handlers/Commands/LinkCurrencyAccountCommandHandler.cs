using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ERP_Pro.Application.Abstractions.Base;
using ERP_Pro.Application.Abstractions.Repositories;
using ERP_Pro.Application.Features.Currencies.Commands;
using ERP_Pro.Application.Features.Currencies.Dtos;
using ERP_Pro.Domain.Modules.FinanceAccounting.Entities;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Application.Features.Currencies.Handlers.Commands
{
    /// <summary>
    /// معالج أمر ربط حساب بالعملة
    /// </summary>
    public class LinkCurrencyAccountCommandHandler : IRequestHandler<LinkCurrencyAccountCommand, CurrencyAccountDto>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrentUser _currentUser;

        public LinkCurrencyAccountCommandHandler(ICurrencyRepository currencyRepository, ICurrentUser currentUser)
        {
            _currencyRepository = currencyRepository;
            _currentUser = currentUser;
        }

        public async Task<CurrencyAccountDto> Handle(LinkCurrencyAccountCommand request, CancellationToken cancellationToken)
        {
            // الحصول على العملة
            var currency = await _currencyRepository.GetByIdAsync(CurrencyId.Create(request.CurrencyId));
            if (currency == null)
            {
                throw new InvalidOperationException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // إنشاء معرف فريد للحساب
            var accountId = CurrencyAccountId.CreateUnique();

            // ربط الحساب بالعملة
            currency.LinkAccount(
                accountId,
                request.AccountType,
                request.AccountNumber,
                request.AccountName);

            // الحصول على الحساب الذي تم إنشاؤه
            var createdAccount = currency.CurrencyAccounts[currency.CurrencyAccounts.Count - 1];

            // تعيين معلومات المستخدم
            typeof(Currency).GetProperty("LastModifiedBy").SetValue(currency, _currentUser.UserId);
            typeof(CurrencyAccount).GetProperty("CreatedBy").SetValue(createdAccount, _currentUser.UserId);
            typeof(CurrencyAccount).GetProperty("LastModifiedBy").SetValue(createdAccount, _currentUser.UserId);

            // حفظ التغييرات
            await _currencyRepository.UpdateAsync(currency);
            await _currencyRepository.SaveChangesAsync();

            // إعادة DTO للحساب
            return new CurrencyAccountDto
            {
                Id = createdAccount.Id.Value,
                CurrencyId = createdAccount.CurrencyId.Value,
                AccountType = createdAccount.AccountType,
                AccountNumber = createdAccount.AccountNumber,
                AccountName = createdAccount.AccountName,
                AccountTypeDescription = GetAccountTypeDescription(createdAccount.AccountType)
            };
        }

        /// <summary>
        /// الحصول على وصف نوع الحساب
        /// </summary>
        private string GetAccountTypeDescription(ERP_Pro.Shared.Enums.Domain.CurrencyAccountTypeEnum accountType)
        {
            return accountType switch
            {
                ERP_Pro.Shared.Enums.Domain.CurrencyAccountTypeEnum.ExchangeRateGains => "أرباح فروق العملة",
                ERP_Pro.Shared.Enums.Domain.CurrencyAccountTypeEnum.ExchangeRateLosses => "خسائر فروق العملة",
                ERP_Pro.Shared.Enums.Domain.CurrencyAccountTypeEnum.CurrencyRevaluation => "إعادة تقييم العملة",
                ERP_Pro.Shared.Enums.Domain.CurrencyAccountTypeEnum.RoundingDifferences => "فروق التقريب",
                ERP_Pro.Shared.Enums.Domain.CurrencyAccountTypeEnum.CurrencySettlement => "تسوية العملة",
                _ => accountType.ToString()
            };
        }
    }
} 