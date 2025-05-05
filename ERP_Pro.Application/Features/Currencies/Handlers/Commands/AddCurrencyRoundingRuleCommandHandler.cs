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
    /// معالج أمر إضافة قاعدة تقريب للعملة
    /// </summary>
    public class AddCurrencyRoundingRuleCommandHandler : IRequestHandler<AddCurrencyRoundingRuleCommand, CurrencyRoundingRuleDto>
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly ICurrentUser _currentUser;

        public AddCurrencyRoundingRuleCommandHandler(ICurrencyRepository currencyRepository, ICurrentUser currentUser)
        {
            _currencyRepository = currencyRepository;
            _currentUser = currentUser;
        }

        public async Task<CurrencyRoundingRuleDto> Handle(AddCurrencyRoundingRuleCommand request, CancellationToken cancellationToken)
        {
            // الحصول على العملة
            var currency = await _currencyRepository.GetByIdAsync(CurrencyId.Create(request.CurrencyId));
            if (currency == null)
            {
                throw new InvalidOperationException($"العملة بالمعرف {request.CurrencyId} غير موجودة");
            }

            // إنشاء معرف فريد لقاعدة التقريب
            var ruleId = CurrencyRoundingRuleId.CreateUnique();

            // إضافة قاعدة التقريب للعملة
            currency.AddRoundingRule(
                ruleId,
                request.RoundingType,
                request.RoundingUnit,
                request.MinAmount,
                request.MaxAmount,
                request.RoundingAccount);

            // الحصول على قاعدة التقريب التي تم إنشاؤها
            var createdRule = currency.RoundingRules[currency.RoundingRules.Count - 1];

            // تعيين معلومات المستخدم
            typeof(Currency).GetProperty("LastModifiedBy").SetValue(currency, _currentUser.UserId);
            typeof(CurrencyRoundingRule).GetProperty("CreatedBy").SetValue(createdRule, _currentUser.UserId);
            typeof(CurrencyRoundingRule).GetProperty("LastModifiedBy").SetValue(createdRule, _currentUser.UserId);

            // حفظ التغييرات
            await _currencyRepository.UpdateAsync(currency);
            await _currencyRepository.SaveChangesAsync();

            // إعادة DTO لقاعدة التقريب
            return new CurrencyRoundingRuleDto
            {
                Id = createdRule.Id.Value,
                CurrencyId = createdRule.CurrencyId.Value,
                RoundingType = createdRule.RoundingType,
                RoundingUnit = createdRule.RoundingUnit,
                MinAmount = createdRule.MinAmount,
                MaxAmount = createdRule.MaxAmount,
                RoundingAccount = createdRule.RoundingAccount
            };
        }
    }
} 