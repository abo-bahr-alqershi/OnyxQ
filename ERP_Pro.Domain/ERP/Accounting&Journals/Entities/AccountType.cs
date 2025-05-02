using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class AccountType : Entity
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> رقم نوع الحساب (أصل، التزام، ...الخ) </summary>
        public int AccountTypeNo { get; private set; }
        /// <summary> اسم نوع الحساب بالعربي </summary>
        public string AccountTypeName { get; private set; }
        /// <summary> اسم نوع الحساب بالإنجليزي </summary>
        public string? AccountTypeEName { get; private set; }
        /// <summary> علم لتحديد إذا كان الحساب يتأثر بالحركات </summary>
        public bool AffectedByTrans { get; private set; }
        /// <summary> أولوية ظهور نوع الحساب </summary>
        public int ReportPriority { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        /// <summary> عدد مرات التعديل </summary>
        public long UpdateCount { get; private set; }
        #endregion

        #region Navigation Properties
        private readonly List<Account> _accounts = new();
        public IReadOnlyCollection<Account> Accounts => _accounts.AsReadOnly();
        #endregion

        private AccountType() { } // For EF Core

        public static AccountType Create(
            int accountTypeNo,
            string accountTypeName,
            string? accountTypeEName,
            bool affectedByTrans,
            int reportPriority,
            int userId,
            string terminal)
        {
            var type = new AccountType
            {
                Id = Guid.NewGuid(),
                AccountTypeNo = accountTypeNo,
                AccountTypeName = accountTypeName,
                AccountTypeEName = accountTypeEName,
                AffectedByTrans = affectedByTrans,
                ReportPriority = reportPriority,
                AuditInfo = AuditInfo.Create(userId, terminal),
                UpdateCount = 0
            };

            type.ValidateState();
            type.AddDomainEvent(new AccountTypeCreatedEvent(type));
            return type;
        }

        public void Update(
            string accountTypeName,
            string? accountTypeEName,
            bool affectedByTrans,
            int reportPriority,
            int userId,
            string terminal)
        {
            var oldState = new { AccountTypeName, AccountTypeEName, AffectedByTrans, ReportPriority };

            AccountTypeName = accountTypeName;
            AccountTypeEName = accountTypeEName;
            AffectedByTrans = affectedByTrans;
            ReportPriority = reportPriority;
            UpdateCount++;
            AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);

            ValidateState();
            AddDomainEvent(new AccountTypeUpdatedEvent(this, oldState));
        }

        private void ValidateState()
        {
            if (AccountTypeNo <= 0)
                throw new DomainException("Account type number must be greater than zero");

            if (string.IsNullOrWhiteSpace(AccountTypeName))
                throw new DomainException("Account type name in Arabic is required");

            if (ReportPriority < 0)
                throw new DomainException("Report priority cannot be negative");
        }
    }
}