using System;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// قاعدة تقريب العملة
    /// </summary>
    public class CurrencyRoundingRule : Entity<CurrencyRoundingRuleId>
    {
        // Private constructor for EF Core
        private CurrencyRoundingRule() { }

        /// <summary>
        /// إنشاء قاعدة تقريب جديدة
        /// </summary>
        public CurrencyRoundingRule(
            CurrencyRoundingRuleId id,
            CurrencyId currencyId,
            CurrencyRoundingTypeEnum roundingType,
            decimal roundingUnit,
            decimal? minAmount,
            decimal? maxAmount,
            string roundingAccount)
        {
            Id = id;
            CurrencyId = currencyId;
            RoundingType = roundingType;
            RoundingUnit = roundingUnit;
            MinAmount = minAmount;
            MaxAmount = maxAmount;
            RoundingAccount = roundingAccount;
            CreatedOn = DateTime.UtcNow;
            LastModifiedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public CurrencyId CurrencyId { get; private set; }

        /// <summary>
        /// نوع التقريب
        /// </summary>
        public CurrencyRoundingTypeEnum RoundingType { get; private set; }

        /// <summary>
        /// وحدة التقريب
        /// </summary>
        public decimal RoundingUnit { get; private set; }

        /// <summary>
        /// الحد الأدنى للمبلغ الذي تنطبق عليه القاعدة
        /// </summary>
        public decimal? MinAmount { get; private set; }

        /// <summary>
        /// الحد الأقصى للمبلغ الذي تنطبق عليه القاعدة
        /// </summary>
        public decimal? MaxAmount { get; private set; }

        /// <summary>
        /// رقم حساب فروق التقريب
        /// </summary>
        public string RoundingAccount { get; private set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// المستخدم الذي أنشأ القاعدة
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
        /// تحديث القاعدة
        /// </summary>
        public void Update(
            CurrencyRoundingTypeEnum roundingType,
            decimal roundingUnit,
            decimal? minAmount,
            decimal? maxAmount,
            string roundingAccount)
        {
            RoundingType = roundingType;
            RoundingUnit = roundingUnit;
            MinAmount = minAmount;
            MaxAmount = maxAmount;
            RoundingAccount = roundingAccount;
            LastModifiedOn = DateTime.UtcNow;
        }
    }
} 