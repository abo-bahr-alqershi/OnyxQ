using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.FinanceAccounting.Events;
using ERP_Pro.Domain.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان العملة - يمثل عملة يتم استخدامها في النظام
    /// </summary>
    public class Currency : Entity
    {
        /// <summary>
        /// رمز العملة (مثل USD، EUR، SAR)
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// الرمز الدولي الرسمي
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
        /// الرمز المختصر (مثل $، €، ﷼)
        /// </summary>
        public string Symbol { get; private set; }

        /// <summary>
        /// الدولة أو المنطقة التي تستخدم هذه العملة
        /// </summary>
        public string Country { get; private set; }

        /// <summary>
        /// عدد الخانات العشرية المستخدمة
        /// </summary>
        public int DecimalPlaces { get; private set; }

        /// <summary>
        /// اسم الوحدة الفرعية للعملة (سنت، هللة، إلخ)
        /// </summary>
        public string FractionName { get; private set; }

        /// <summary>
        /// قيمة الوحدة الفرعية مقارنة بالوحدة الرئيسية (عادة 1/100)
        /// </summary>
        public decimal FractionValue { get; private set; }

        /// <summary>
        /// الرمز المستخدم كفاصل للآلاف (فراغ، نقطة، فاصلة)
        /// </summary>
        public string ThousandsSeparator { get; private set; }

        /// <summary>
        /// الرمز المستخدم كفاصل للكسور العشرية (نقطة، فاصلة)
        /// </summary>
        public string DecimalSeparator { get; private set; }

        /// <summary>
        /// موقع عرض رمز العملة (قبل المبلغ، بعد المبلغ)
        /// </summary>
        public ERP_Pro.Shared.Enums.Domain.CurrencySymbolPositionEnum SymbolPosition { get; private set; }

        /// <summary>
        /// هل تضاف فراغ بين الرمز والقيمة
        /// </summary>
        public bool UseSpaceWithSymbol { get; private set; }

        /// <summary>
        /// هل يتم إظهار الأصفار العشرية دائماً
        /// </summary>
        public bool ShowTrailingZeros { get; private set; }

        /// <summary>
        /// نوع التقريب المستخدم
        /// </summary>
        public ERP_Pro.Shared.Enums.Domain.CurrencyRoundingTypeEnum RoundingType { get; private set; }

        /// <summary>
        /// الوحدة التي يتم التقريب إليها
        /// </summary>
        public decimal RoundingUnit { get; private set; }

        /// <summary>
        /// قالب تحويل المبالغ للكلمات بالعربية
        /// </summary>
        public string ArWordsTemplate { get; private set; }

        /// <summary>
        /// قالب تحويل المبالغ للكلمات بالإنجليزية
        /// </summary>
        public string EnWordsTemplate { get; private set; }

        /// <summary>
        /// هل هي العملة الأساسية
        /// </summary>
        public bool IsBase { get; private set; }

        /// <summary>
        /// حالة العملة
        /// </summary>
        public ERP_Pro.Shared.Enums.Domain.CurrencyStatusEnum Status { get; private set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; private set; }

        // العلاقات
        private readonly List<CurrencyAccount> _accounts = new List<CurrencyAccount>();
        public IReadOnlyCollection<CurrencyAccount> Accounts => _accounts.AsReadOnly();

        private readonly List<CurrencyRoundingRule> _roundingRules = new List<CurrencyRoundingRule>();
        public IReadOnlyCollection<CurrencyRoundingRule> RoundingRules => _roundingRules.AsReadOnly();

        private readonly List<ExchangeRateHistory> _exchangeRateHistory = new List<ExchangeRateHistory>();
        public IReadOnlyCollection<ExchangeRateHistory> ExchangeRateHistory => _exchangeRateHistory.AsReadOnly();

        private readonly List<CurrencyRiskLimit> _riskLimits = new List<CurrencyRiskLimit>();
        public IReadOnlyCollection<CurrencyRiskLimit> RiskLimits => _riskLimits.AsReadOnly();

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private Currency() { }

        /// <summary>
        /// إنشاء كيان عملة جديد
        /// </summary>
        public static Currency Create(
            string code,
            string isoCode,
            string nameAr,
            string nameEn,
            string symbol,
            string country,
            int decimalPlaces,
            bool isBase = false)
        {
            if (string.IsNullOrWhiteSpace(code))
                throw new ArgumentException("رمز العملة مطلوب", nameof(code));

            if (string.IsNullOrWhiteSpace(nameAr))
                throw new ArgumentException("اسم العملة بالعربية مطلوب", nameof(nameAr));

            return new Currency
            {
                Id = Guid.NewGuid(),
                Code = code.ToUpperInvariant(),
                IsoCode = isoCode?.ToUpperInvariant() ?? code.ToUpperInvariant(),
                NameAr = nameAr,
                NameEn = nameEn ?? nameAr,
                Symbol = symbol,
                Country = country,
                DecimalPlaces = decimalPlaces,
                FractionName = "",
                FractionValue = 0.01m,
                ThousandsSeparator = ",",
                DecimalSeparator = ".",
                SymbolPosition = ERP_Pro.Shared.Enums.Domain.CurrencySymbolPositionEnum.BeforeAmount,
                UseSpaceWithSymbol = false,
                ShowTrailingZeros = true,
                RoundingType = ERP_Pro.Shared.Enums.Domain.CurrencyRoundingTypeEnum.Mathematical,
                RoundingUnit = 0.01m,
                ArWordsTemplate = "[$n] $c",
                EnWordsTemplate = "$n $c",
                IsBase = isBase,
                Status = ERP_Pro.Shared.Enums.Domain.CurrencyStatusEnum.Active
            };
        }

        /// <summary>
        /// تحديث المعلومات الأساسية للعملة
        /// </summary>
        public void UpdateBasicInfo(
            string nameAr,
            string nameEn,
            string symbol,
            string country,
            string isoCode)
        {
            if (string.IsNullOrWhiteSpace(nameAr))
                throw new ArgumentException("اسم العملة بالعربية مطلوب", nameof(nameAr));

            NameAr = nameAr;
            NameEn = nameEn ?? nameAr;
            Symbol = symbol;
            Country = country;
            IsoCode = isoCode?.ToUpperInvariant() ?? Code;

            AddDomainEvent(new CurrencyUpdatedEvent(Id));
        }

        /// <summary>
        /// تحديث خصائص العملة
        /// </summary>
        public void UpdateProperties(
            int decimalPlaces,
            string fractionName,
            decimal fractionValue,
            string thousandsSeparator,
            string decimalSeparator,
            ERP_Pro.Shared.Enums.Domain.CurrencySymbolPositionEnum symbolPosition,
            bool useSpaceWithSymbol,
            bool showTrailingZeros)
        {
            DecimalPlaces = decimalPlaces;
            FractionName = fractionName;
            FractionValue = fractionValue;
            ThousandsSeparator = thousandsSeparator;
            DecimalSeparator = decimalSeparator;
            SymbolPosition = symbolPosition;
            UseSpaceWithSymbol = useSpaceWithSymbol;
            ShowTrailingZeros = showTrailingZeros;

            AddDomainEvent(new CurrencyUpdatedEvent(Id));
        }

        /// <summary>
        /// تحديث قواعد التقريب
        /// </summary>
        public void UpdateRoundingRules(
            ERP_Pro.Shared.Enums.Domain.CurrencyRoundingTypeEnum roundingType,
            decimal roundingUnit)
        {
            RoundingType = roundingType;
            RoundingUnit = roundingUnit;

            AddDomainEvent(new CurrencyUpdatedEvent(Id));
        }

        /// <summary>
        /// تحديث قوالب تحويل المبالغ إلى كلمات
        /// </summary>
        public void UpdateWordsTemplates(
            string arWordsTemplate,
            string enWordsTemplate)
        {
            ArWordsTemplate = arWordsTemplate;
            EnWordsTemplate = enWordsTemplate;

            AddDomainEvent(new CurrencyUpdatedEvent(Id));
        }

        /// <summary>
        /// تحديث الملاحظات
        /// </summary>
        public void UpdateNotes(string notes)
        {
            Notes = notes;
        }

        /// <summary>
        /// تعيين كعملة أساسية
        /// </summary>
        public void SetAsBaseCurrency()
        {
            if (!IsBase)
            {
                IsBase = true;
                AddDomainEvent(new CurrencySetAsBaseEvent(Id));
            }
        }

        /// <summary>
        /// إلغاء تعيين كعملة أساسية
        /// </summary>
        public void UnsetAsBaseCurrency()
        {
            if (IsBase)
            {
                IsBase = false;
                AddDomainEvent(new CurrencyUnsetAsBaseEvent(Id));
            }
        }

        /// <summary>
        /// تنشيط العملة
        /// </summary>
        public void Activate()
        {
            if (Status != ERP_Pro.Shared.Enums.Domain.CurrencyStatusEnum.Active)
            {
                Status = ERP_Pro.Shared.Enums.Domain.CurrencyStatusEnum.Active;
                AddDomainEvent(new CurrencyStatusChangedEvent(Id, ERP_Pro.Shared.Enums.Domain.CurrencyStatusEnum.Active));
            }
        }

        /// <summary>
        /// تعطيل العملة
        /// </summary>
        public void Deactivate()
        {
            if (Status != ERP_Pro.Shared.Enums.Domain.CurrencyStatusEnum.Inactive)
            {
                if (IsBase)
                    throw new InvalidOperationException("لا يمكن تعطيل العملة الأساسية");

                Status = ERP_Pro.Shared.Enums.Domain.CurrencyStatusEnum.Inactive;
                AddDomainEvent(new CurrencyStatusChangedEvent(Id, ERP_Pro.Shared.Enums.Domain.CurrencyStatusEnum.Inactive));
            }
        }

        /// <summary>
        /// إضافة قاعدة تقريب
        /// </summary>
        public void AddRoundingRule(CurrencyRoundingRule rule)
        {
            if (rule == null)
                throw new ArgumentNullException(nameof(rule));

            _roundingRules.Add(rule);
        }

        /// <summary>
        /// إضافة سجل لسعر الصرف
        /// </summary>
        public void AddExchangeRateRecord(ExchangeRateHistory record)
        {
            if (record == null)
                throw new ArgumentNullException(nameof(record));

            _exchangeRateHistory.Add(record);
        }

        /// <summary>
        /// إضافة حساب للعملة
        /// </summary>
        public void AddAccount(CurrencyAccount account)
        {
            if (account == null)
                throw new ArgumentNullException(nameof(account));

            _accounts.Add(account);
        }

        /// <summary>
        /// إضافة حد مخاطر للعملة
        /// </summary>
        public void AddRiskLimit(CurrencyRiskLimit riskLimit)
        {
            if (riskLimit == null)
                throw new ArgumentNullException(nameof(riskLimit));

            _riskLimits.Add(riskLimit);
        }
    }
} 