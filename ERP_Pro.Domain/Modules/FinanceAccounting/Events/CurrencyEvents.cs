using System;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Events
{
    /// <summary>
    /// حدث إنشاء عملة جديدة
    /// </summary>
    public record CurrencyCreatedEvent(CurrencyId CurrencyId, string Code, string NameAr, string NameEn, string Symbol) : IDomainEvent;

    /// <summary>
    /// حدث تحديث عملة
    /// </summary>
    public record CurrencyUpdatedEvent(CurrencyId CurrencyId, string Code, string NameAr, string NameEn, string Symbol) : IDomainEvent;

    /// <summary>
    /// حدث تغيير حالة عملة
    /// </summary>
    public record CurrencyStatusChangedEvent(CurrencyId CurrencyId, CurrencyStatusEnum NewStatus) : IDomainEvent;

    /// <summary>
    /// حدث تعيين عملة كأساسية
    /// </summary>
    public record CurrencySetAsBaseEvent(CurrencyId CurrencyId, CurrencyId PreviousBaseCurrencyId) : IDomainEvent;

    /// <summary>
    /// حدث تحديث سعر صرف عملة
    /// </summary>
    public record CurrencyExchangeRateUpdatedEvent(CurrencyId CurrencyId, decimal Rate, DateTime EffectiveDate, ExchangeRateTypeEnum RateType, ExchangeRateSourceEnum Source) : IDomainEvent;

    /// <summary>
    /// حدث إضافة قاعدة تقريب عملة
    /// </summary>
    public record CurrencyRoundingRuleAddedEvent(CurrencyId CurrencyId, CurrencyRoundingRuleId RuleId, CurrencyRoundingTypeEnum RoundingType, decimal RoundingUnit) : IDomainEvent;

    /// <summary>
    /// حدث تحديث قاعدة تقريب عملة
    /// </summary>
    public record CurrencyRoundingRuleUpdatedEvent(CurrencyId CurrencyId, CurrencyRoundingRuleId RuleId, CurrencyRoundingTypeEnum RoundingType, decimal RoundingUnit) : IDomainEvent;

    /// <summary>
    /// حدث ربط حساب بعملة
    /// </summary>
    public record CurrencyAccountLinkedEvent(CurrencyId CurrencyId, CurrencyAccountId AccountId, CurrencyAccountTypeEnum AccountType, string AccountNumber) : IDomainEvent;
} 