using System;
using ERP_Pro.Domain.Common.Base;
using ERP_Pro.Domain.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.FinanceAccounting.Entities
{
    /// <summary>
    /// كيان حساب العملة - يربط العملة بالحسابات المحاسبية المناسبة
    /// </summary>
    public class CurrencyAccount : Entity
    {
        /// <summary>
        /// معرف العملة
        /// </summary>
        public Guid CurrencyId { get; private set; }

        /// <summary>
        /// نوع الحساب
        /// </summary>
        public CurrencyAccountTypeEnum AccountType { get; private set; }

        /// <summary>
        /// رقم الحساب
        /// </summary>
        public string AccountNumber { get; private set; }

        /// <summary>
        /// وصف الحساب
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// حالة الحساب
        /// </summary>
        public bool IsActive { get; private set; }

        /// <summary>
        /// العملة (علاقة)
        /// </summary>
        public Currency Currency { get; private set; }

        // المُنشئ الخاص - لا يُستخدم مباشرة
        private CurrencyAccount() { }

        /// <summary>
        /// إنشاء كيان حساب عملة جديد
        /// </summary>
        public static CurrencyAccount Create(
            Guid currencyId,
            CurrencyAccountTypeEnum accountType,
            string accountNumber,
            string description = null,
            bool isActive = true)
        {
            if (currencyId == Guid.Empty)
                throw new ArgumentException("معرف العملة مطلوب", nameof(currencyId));

            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("رقم الحساب مطلوب", nameof(accountNumber));

            return new CurrencyAccount
            {
                Id = Guid.NewGuid(),
                CurrencyId = currencyId,
                AccountType = accountType,
                AccountNumber = accountNumber,
                Description = description ?? GetDefaultDescription(accountType),
                IsActive = isActive
            };
        }

        /// <summary>
        /// تحديث حساب العملة
        /// </summary>
        public void Update(
            string accountNumber,
            string description = null)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("رقم الحساب مطلوب", nameof(accountNumber));

            AccountNumber = accountNumber;
            
            if (description != null)
                Description = description;
        }

        /// <summary>
        /// تفعيل الحساب
        /// </summary>
        public void Activate()
        {
            IsActive = true;
        }

        /// <summary>
        /// تعطيل الحساب
        /// </summary>
        public void Deactivate()
        {
            IsActive = false;
        }

        /// <summary>
        /// الحصول على الوصف الافتراضي بناءً على نوع الحساب
        /// </summary>
        private static string GetDefaultDescription(CurrencyAccountTypeEnum accountType)
        {
            switch (accountType)
            {
                case CurrencyAccountTypeEnum.ExchangeRateGains:
                    return "حساب أرباح فروق أسعار الصرف";
                case CurrencyAccountTypeEnum.ExchangeRateLosses:
                    return "حساب خسائر فروق أسعار الصرف";
                case CurrencyAccountTypeEnum.CurrencyRevaluation:
                    return "حساب إعادة تقييم العملة";
                case CurrencyAccountTypeEnum.RoundingDifferences:
                    return "حساب فروق التقريب";
                case CurrencyAccountTypeEnum.CurrencySettlement:
                    return "حساب تسوية العملة";
                default:
                    return "حساب مرتبط بالعملة";
            }
        }
    }
} 