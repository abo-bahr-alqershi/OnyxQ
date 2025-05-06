using System;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان قاعدة تقريب العملة - يحدد كيفية تقريب مبالغ العملة
    /// </summary>
    public class CurrencyRoundingRule : Entity
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; private set; }

        /// <summary>
        /// نوع التقريب (رياضي، لأعلى، لأسفل)
        /// </summary>
        public CurrencyRoundingTypeEnum RoundingType { get; private set; }

        /// <summary>
        /// وحدة التقريب (0.01، 0.05، 0.1، 0.5، 1، 5، 10)
        /// </summary>
        public decimal RoundingUnit { get; private set; }

        /// <summary>
        /// الحد الأدنى للمبلغ الذي يتم تقريبه
        /// </summary>
        public decimal? MinAmount { get; private set; }

        /// <summary>
        /// الحد الأقصى للمبلغ الذي يتم تقريبه
        /// </summary>
        public decimal? MaxAmount { get; private set; }

        /// <summary>
        /// رقم حساب فروق التقريب
        /// </summary>
        public string RoundingAccountNumber { get; private set; }

        /// <summary>
        /// نوع المعاملة (المبيعات، المشتريات، المصروفات، الإيرادات، الكل)
        /// </summary>
        public string TransactionType { get; private set; }

        /// <summary>
        /// حالة القاعدة (نشطة، معطلة)
        /// </summary>
        public bool IsActive { get; private set; }

        /// <summary>
        /// العملة (علاقة)
        /// </summary>
        public Currency Currency { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private CurrencyRoundingRule() { }

        /// <summary>
        /// إنشاء كيان قاعدة تقريب جديد
        /// </summary>
        public static CurrencyRoundingRule Create(
            Guid currencyId,
            CurrencyRoundingTypeEnum roundingType,
            decimal roundingUnit,
            decimal? minAmount = null,
            decimal? maxAmount = null,
            string roundingAccountNumber = null,
            string transactionType = "All",
            bool isActive = true)
        {
            if (currencyId == Guid.Empty)
                throw new ArgumentException("معرف العملة مطلوب", nameof(currencyId));

            if (roundingUnit <= 0)
                throw new ArgumentException("وحدة التقريب يجب أن تكون موجبة", nameof(roundingUnit));

            if (minAmount.HasValue && maxAmount.HasValue && minAmount > maxAmount)
                throw new ArgumentException("الحد الأدنى يجب أن يكون أقل من أو يساوي الحد الأقصى", nameof(minAmount));

            return new CurrencyRoundingRule
            {
                Id = Guid.NewGuid(),
                CurrencyId = currencyId,
                RoundingType = roundingType,
                RoundingUnit = roundingUnit,
                MinAmount = minAmount,
                MaxAmount = maxAmount,
                RoundingAccountNumber = roundingAccountNumber,
                TransactionType = transactionType,
                IsActive = isActive
            };
        }

        /// <summary>
        /// تحديث قاعدة التقريب
        /// </summary>
        public void Update(
            CurrencyRoundingTypeEnum roundingType,
            decimal roundingUnit,
            decimal? minAmount = null,
            decimal? maxAmount = null,
            string roundingAccountNumber = null,
            string transactionType = null)
        {
            if (roundingUnit <= 0)
                throw new ArgumentException("وحدة التقريب يجب أن تكون موجبة", nameof(roundingUnit));

            if (minAmount.HasValue && maxAmount.HasValue && minAmount > maxAmount)
                throw new ArgumentException("الحد الأدنى يجب أن يكون أقل من أو يساوي الحد الأقصى", nameof(minAmount));

            RoundingType = roundingType;
            RoundingUnit = roundingUnit;
            MinAmount = minAmount;
            MaxAmount = maxAmount;
            
            if (roundingAccountNumber != null)
                RoundingAccountNumber = roundingAccountNumber;
                
            if (transactionType != null)
                TransactionType = transactionType;
        }

        /// <summary>
        /// تفعيل القاعدة
        /// </summary>
        public void Activate()
        {
            IsActive = true;
        }

        /// <summary>
        /// تعطيل القاعدة
        /// </summary>
        public void Deactivate()
        {
            IsActive = false;
        }

        /// <summary>
        /// التحقق مما إذا كان المبلغ ضمن نطاق هذه القاعدة
        /// </summary>
        public bool IsApplicableToAmount(decimal amount)
        {
            if (MinAmount.HasValue && amount < MinAmount.Value)
                return false;

            if (MaxAmount.HasValue && amount > MaxAmount.Value)
                return false;

            return true;
        }

        /// <summary>
        /// تطبيق التقريب على مبلغ
        /// </summary>
        public decimal ApplyRounding(decimal amount)
        {
            if (!IsApplicableToAmount(amount))
                return amount;

            switch (RoundingType)
            {
                case CurrencyRoundingTypeEnum.Mathematical:
                    // تقريب رياضي (لأقرب قيمة)
                    return Math.Round(amount / RoundingUnit) * RoundingUnit;

                case CurrencyRoundingTypeEnum.Up:
                    // تقريب لأعلى
                    return Math.Ceiling(amount / RoundingUnit) * RoundingUnit;

                case CurrencyRoundingTypeEnum.Down:
                    // تقريب لأسفل
                    return Math.Floor(amount / RoundingUnit) * RoundingUnit;

                default:
                    return amount;
            }
        }
    }
} 