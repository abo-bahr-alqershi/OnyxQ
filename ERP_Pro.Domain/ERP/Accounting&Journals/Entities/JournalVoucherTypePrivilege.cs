using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class JournalVoucherTypePrivilege : Entity
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> معلومات نوع السند </summary>
        public JournalVoucherTypeInfo VoucherTypeInfo { get; private set; }
        /// <summary> رقم المستخدم </summary>
        public int UserId { get; private set; }
        /// <summary> معلومات الصلاحيات </summary>
        public PrivilegeInfo Privileges { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        private JournalVoucherTypePrivilege() { } // For EF Core

        public static JournalVoucherTypePrivilege Create(
            JournalVoucherTypeInfo voucherTypeInfo,
            int userId,
            PrivilegeInfo privileges,
            int createdByUserId,
            string terminal)
        {
            var privilege = new JournalVoucherTypePrivilege
            {
                Id = Guid.NewGuid(),
                VoucherTypeInfo = voucherTypeInfo,
                UserId = userId,
                Privileges = privileges,
                AuditInfo = AuditInfo.Create(createdByUserId, terminal)
            };

            privilege.AddDomainEvent(new JournalVoucherTypePrivilegeCreatedEvent(privilege));
            return privilege;
        }

        public void UpdatePrivileges(PrivilegeInfo privileges)
        {
            var oldPrivileges = Privileges;
            Privileges = privileges;

            AddDomainEvent(new JournalVoucherTypePrivilegeUpdatedEvent(this, oldPrivileges));
        }

        private void ValidateState()
        {
            if (VoucherTypeInfo == null)
                throw new DomainException("Voucher type info is required");

            if (UserId <= 0)
                throw new DomainException("User ID must be greater than zero");

            if (Privileges == null)
                throw new DomainException("Privileges info is required");
        }
    }
}