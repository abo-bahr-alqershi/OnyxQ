using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class JournalVoucherType : Entity
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> رقم/نوع السند المحاسبي الرئيسي </summary>
        public int VoucherType { get; private set; }
        /// <summary> رقم فرعي لنوع السند </summary>
        public short VoucherTypeNo { get; private set; }
        /// <summary> كود الحساب الافتراضي لهذا السند </summary>
        public string? AccountCode { get; private set; }
        /// <summary> معلومات تفاصيل الحساب </summary>
        public AccountDetailInfo? AccountDetail { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        private JournalVoucherType() { } // For EF Core

        public static JournalVoucherType Create(
            int voucherType,
            short voucherTypeNo,
            string? accountCode = null,
            AccountDetailInfo? accountDetail = null,
            int userId = 0,
            string? terminal = null)
        {
            var type = new JournalVoucherType
            {
                Id = Guid.NewGuid(),
                VoucherType = voucherType,
                VoucherTypeNo = voucherTypeNo,
                AccountCode = accountCode,
                AccountDetail = accountDetail
            };

            if (userId > 0 && !string.IsNullOrEmpty(terminal))
            {
                type.AuditInfo = AuditInfo.Create(userId, terminal);
            }

            type.ValidateState();
            type.AddDomainEvent(new JournalVoucherTypeCreatedEvent(type));
            return type;
        }

        public void Update(
            string? accountCode,
            AccountDetailInfo? accountDetail,
            int userId,
            string terminal)
        {
            var oldState = new { AccountCode, AccountDetail };

            AccountCode = accountCode;
            AccountDetail = accountDetail;

            if (AuditInfo != null)
            {
                AuditInfo = AuditInfo.Update(AuditInfo, userId, terminal);
            }
            else
            {
                AuditInfo = AuditInfo.Create(userId, terminal);
            }

            ValidateState();
            AddDomainEvent(new JournalVoucherTypeUpdatedEvent(this, oldState));
        }

        private void ValidateState()
        {
            if (VoucherType <= 0)
                throw new DomainException("Voucher type must be greater than zero");

            if (VoucherTypeNo <= 0)
                throw new DomainException("Voucher type number must be greater than zero");
        }
    }
}