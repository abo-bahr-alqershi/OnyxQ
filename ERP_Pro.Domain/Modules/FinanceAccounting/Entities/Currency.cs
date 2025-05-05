using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.Events;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// العملة
    /// </summary>
    public class Currency : AggregateRoot<CurrencyId>
    {
        // Private collections for one-to-many relationships
        private readonly List<CurrencyRoundingRule> _roundingRules = new();
        private readonly List<CurrencyDisplayRule> _displayRules = new();
        private readonly List<CurrencyAccount> _currencyAccounts = new();
        private readonly List<ExchangeRateHistory> _exchangeRateHistory = new();

        // Private constructor for EF Core
        private Currency() { }

        /// <summary>
        /// إنشاء عملة جديدة
        /// </summary>
        public Currency(
            CurrencyId id,
            string code,
            string nameAr,
            string nameEn,
            string symbol,
            int decimalPlaces,
            bool isBaseCurrency = false)
        {
            Id = id;
            Code = code;
            IsoCode = code; // Default to same as code
            NameAr = nameAr;
            NameEn = nameEn;
            Symbol = symbol;
            DecimalPlaces = decimalPlaces;
            IsBaseCurrency = isBaseCurrency;
            Status = CurrencyStatusEnum.Active;
            CreatedOn = DateTime.UtcNow;
            LastModifiedOn = DateTime.UtcNow;
            
            // Raise created event
            AddDomainEvent(new CurrencyCreatedEvent(Id, Code, NameAr, NameEn, Symbol));
        }

        /// <summary>
        /// الرمز الفريد للعملة
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// الرمز الدولي الرسمي للعملة
        /// </summary>
        public string IsoCode { get; private set; }

        /// <summary>
        /// اسم العملة بالعربية
        /// </summary>
        public string NameAr { get; private set; }

        /// <summary>
        /// اسم العملة بالإنجليزية
        /// </summary>
        public string NameEn { get; private set; }

        /// <summary>
        /// الرمز المختصر للعملة
        /// </summary>
        public string Symbol { get; private set; }

        /// <summary>
        /// الدولة التي تستخدم العملة
        /// </summary>
        public string Country { get; private set; }

        /// <summary>
        /// هل هي العملة الأساسية للنظام
        /// </summary>
        public bool IsBaseCurrency { get; private set; }

        /// <summary>
        /// حالة العملة
        /// </summary>
        public CurrencyStatusEnum Status { get; private set; }

        /// <summary>
        /// عدد الخانات العشرية
        /// </summary>
        public int DecimalPlaces { get; private set; }

        /// <summary>
        /// فاصل الآلاف
        /// </summary>
        public string ThousandsSeparator { get; private set; }

        /// <summary>
        /// فاصل الكسور العشرية
        /// </summary>
        public string DecimalSeparator { get; private set; }

        /// <summary>
        /// موقع عرض الرمز
        /// </summary>
        public CurrencySymbolPositionEnum SymbolPosition { get; private set; }

        /// <summary>
        /// الوحدة الفرعية للعملة
        /// </summary>
        public string FractionName { get; private set; }

        /// <summary>
        /// قيمة الوحدة الفرعية
        /// </summary>
        public decimal FractionValue { get; private set; }

        /// <summary>
        /// إضافة فراغ بين الرمز والقيمة
        /// </summary>
        public bool UseSpaceBetweenSymbolAndValue { get; private set; }

        /// <summary>
        /// إظهار الأصفار العشرية
        /// </summary>
        public bool ShowTrailingZeros { get; private set; }

        /// <summary>
        /// قالب تحويل المبالغ للكلمات بالعربية
        /// </summary>
        public string ArNumbersToWordsTemplate { get; private set; }

        /// <summary>
        /// قالب تحويل المبالغ للكلمات بالإنجليزية
        /// </summary>
        public string EnNumbersToWordsTemplate { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        /// <summary>
        /// سعر الصرف الحالي
        /// </summary>
        public decimal CurrentExchangeRate { get; private set; }

        /// <summary>
        /// تاريخ آخر تحديث لسعر الصرف
        /// </summary>
        public DateTime LastExchangeRateUpdate { get; private set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// المستخدم الذي أنشأ العملة
        /// </summary>
        public string CreatedBy { get; private set; }

        /// <summary>
        /// تاريخ آخر تعديل
        /// </summary>
        public DateTime LastModifiedOn { get; private set; }

        /// <summary>
        /// المستخدم الذي قام بآخر تعديل
        /// </summary>
        public string LastModifiedBy { get; private set; }

        /// <summary>
        /// قواعد تقريب العملة
        /// </summary>
        public IReadOnlyList<CurrencyRoundingRule> RoundingRules => _roundingRules.AsReadOnly();

        /// <summary>
        /// قواعد عرض العملة
        /// </summary>
        public IReadOnlyList<CurrencyDisplayRule> DisplayRules => _displayRules.AsReadOnly();

        /// <summary>
        /// حسابات العملة
        /// </summary>
        public IReadOnlyList<CurrencyAccount> CurrencyAccounts => _currencyAccounts.AsReadOnly();

        /// <summary>
        /// تاريخ أسعار الصرف
        /// </summary>
        public IReadOnlyList<ExchangeRateHistory> ExchangeRateHistory => _exchangeRateHistory.AsReadOnly();

        #region Methods

        /// <summary>
        /// تحديث معلومات العملة
        /// </summary>
        public void Update(
            string nameAr,
            string nameEn,
            string symbol,
            string country,
            int decimalPlaces,
            string notes)
        {
            NameAr = nameAr;
            NameEn = nameEn;
            Symbol = symbol;
            Country = country;
            DecimalPlaces = decimalPlaces;
            Notes = notes;
            LastModifiedOn = DateTime.UtcNow;
            
            AddDomainEvent(new CurrencyUpdatedEvent(Id, Code, NameAr, NameEn, Symbol));
        }

        /// <summary>
        /// تحديث إعدادات خصائص العملة
        /// </summary>
        public void UpdateProperties(
            int decimalPlaces,
            string thousandsSeparator,
            string decimalSeparator,
            CurrencySymbolPositionEnum symbolPosition,
            string fractionName,
            decimal fractionValue,
            bool useSpaceBetweenSymbolAndValue,
            bool showTrailingZeros)
        {
            DecimalPlaces = decimalPlaces;
            ThousandsSeparator = thousandsSeparator;
            DecimalSeparator = decimalSeparator;
            SymbolPosition = symbolPosition;
            FractionName = fractionName;
            FractionValue = fractionValue;
            UseSpaceBetweenSymbolAndValue = useSpaceBetweenSymbolAndValue;
            ShowTrailingZeros = showTrailingZeros;
            LastModifiedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// تحديث قوالب تحويل المبالغ إلى كلمات
        /// </summary>
        public void UpdateNumbersToWordsTemplates(
            string arNumbersToWordsTemplate,
            string enNumbersToWordsTemplate)
        {
            ArNumbersToWordsTemplate = arNumbersToWordsTemplate;
            EnNumbersToWordsTemplate = enNumbersToWordsTemplate;
            LastModifiedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// تغيير حالة العملة
        /// </summary>
        public void ChangeStatus(CurrencyStatusEnum newStatus)
        {
            // لا يمكن تعطيل العملة الأساسية
            if (IsBaseCurrency && newStatus == CurrencyStatusEnum.Inactive)
            {
                throw new InvalidOperationException("لا يمكن تعطيل العملة الأساسية");
            }

            Status = newStatus;
            LastModifiedOn = DateTime.UtcNow;
            
            AddDomainEvent(new CurrencyStatusChangedEvent(Id, newStatus));
        }

        /// <summary>
        /// تعيين العملة كعملة أساسية
        /// </summary>
        public void SetAsBaseCurrency(CurrencyId previousBaseCurrencyId)
        {
            if (Status == CurrencyStatusEnum.Inactive)
            {
                throw new InvalidOperationException("لا يمكن تعيين عملة معطلة كعملة أساسية");
            }

            IsBaseCurrency = true;
            LastModifiedOn = DateTime.UtcNow;
            
            AddDomainEvent(new CurrencySetAsBaseEvent(Id, previousBaseCurrencyId));
        }

        /// <summary>
        /// إلغاء تعيين العملة كعملة أساسية
        /// </summary>
        public void UnsetAsBaseCurrency()
        {
            IsBaseCurrency = false;
            LastModifiedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// تحديث سعر الصرف الحالي
        /// </summary>
        public void UpdateExchangeRate(decimal rate, ExchangeRateTypeEnum rateType, ExchangeRateSourceEnum source)
        {
            if (IsBaseCurrency && rate != 1)
            {
                throw new InvalidOperationException("سعر صرف العملة الأساسية يجب أن يكون 1");
            }

            CurrentExchangeRate = rate;
            LastExchangeRateUpdate = DateTime.UtcNow;
            LastModifiedOn = DateTime.UtcNow;
            
            // إضافة سجل تاريخي لسعر الصرف
            var historyEntry = new ExchangeRateHistory(
                ExchangeRateHistoryId.CreateUnique(),
                Id,
                rate,
                DateTime.UtcNow,
                rateType,
                source);
            
            _exchangeRateHistory.Add(historyEntry);
            
            AddDomainEvent(new CurrencyExchangeRateUpdatedEvent(Id, rate, DateTime.UtcNow, rateType, source));
        }

        /// <summary>
        /// إضافة قاعدة تقريب
        /// </summary>
        public void AddRoundingRule(
            CurrencyRoundingRuleId ruleId,
            CurrencyRoundingTypeEnum roundingType,
            decimal roundingUnit,
            decimal? minAmount,
            decimal? maxAmount,
            string roundingAccount)
        {
            var rule = new CurrencyRoundingRule(
                ruleId,
                Id,
                roundingType,
                roundingUnit,
                minAmount,
                maxAmount,
                roundingAccount);
            
            _roundingRules.Add(rule);
            LastModifiedOn = DateTime.UtcNow;
            
            AddDomainEvent(new CurrencyRoundingRuleAddedEvent(Id, ruleId, roundingType, roundingUnit));
        }

        /// <summary>
        /// إضافة قاعدة عرض
        /// </summary>
        public void AddDisplayRule(
            CurrencyDisplayRuleId ruleId,
            CurrencySymbolPositionEnum symbolPosition,
            bool useSpace,
            bool showTrailingZeros,
            string negativeFormat,
            string language)
        {
            var rule = new CurrencyDisplayRule(
                ruleId,
                Id,
                symbolPosition,
                useSpace,
                showTrailingZeros,
                negativeFormat,
                language);
            
            _displayRules.Add(rule);
            LastModifiedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// ربط حساب بالعملة
        /// </summary>
        public void LinkAccount(
            CurrencyAccountId accountId,
            CurrencyAccountTypeEnum accountType,
            string accountNumber,
            string accountName)
        {
            var account = new CurrencyAccount(
                accountId,
                Id,
                accountType,
                accountNumber,
                accountName);
            
            _currencyAccounts.Add(account);
            LastModifiedOn = DateTime.UtcNow;
            
            AddDomainEvent(new CurrencyAccountLinkedEvent(Id, accountId, accountType, accountNumber));
        }

        #endregion
    }
} 