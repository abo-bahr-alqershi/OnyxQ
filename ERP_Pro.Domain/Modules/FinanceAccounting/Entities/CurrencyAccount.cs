using System;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Modules.FinanceAccounting.ValueObjects;
using ERP_Pro.Shared.Enums.Domain;

namespace ERP_Pro.Domain.Modules.FinanceAccounting.Entities
{
    /// <summary>
    /// حسابات العملة
    /// </summary>
    public class CurrencyAccount : Entity<CurrencyAccountId>
    {
        // Private constructor for EF Core
        private CurrencyAccount() { }

        /// <summary>
        /// إنشاء حساب عملة جديد
        /// </summary>
        public CurrencyAccount(
            CurrencyAccountId id,
            CurrencyId currencyId,
            CurrencyAccountTypeEnum accountType,
            string accountNumber,
            string accountName)
        {
            Id = id;
            CurrencyId = currencyId;
            AccountType = accountType;
            AccountNumber = accountNumber;
            AccountName = accountName;
            CreatedOn = DateTime.UtcNow;
            LastModifiedOn = DateTime.UtcNow;
        }

        /// <summary>
        /// معرف العملة
        /// </summary>
        public CurrencyId CurrencyId { get; private set; }

        /// <summary>
        /// نوع الحساب
        /// </summary>
        public CurrencyAccountTypeEnum AccountType { get; private set; }

        /// <summary>
        /// رقم الحساب
        /// </summary>
        public string AccountNumber { get; private set; }

        /// <summary>
        /// اسم الحساب
        /// </summary>
        public string AccountName { get; private set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// المستخدم الذي أنشأ الحساب
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
        /// تحديث بيانات حساب العملة
        /// </summary>
        public void Update(string accountNumber, string accountName)
        {
            AccountNumber = accountNumber;
            AccountName = accountName;
            LastModifiedOn = DateTime.UtcNow;
        }
    }
} 