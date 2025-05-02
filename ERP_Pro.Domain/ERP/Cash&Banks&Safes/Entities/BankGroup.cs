using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.Events;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.Entities
{
    public class BankGroup : AggregateRoot
    {
        #region Basic Info
        public int GroupNo { get; private set; }
        public string GroupNameAr { get; private set; }
        public string? GroupNameEn { get; private set; }
        public string AccountCode { get; private set; }
        public bool IsInactive { get; private set; }
        public DateTime? InactiveDate { get; private set; }
        public string? InactiveReason { get; private set; }
        public string? Notes { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        private BankGroup() { } // For EF Core

        public static BankGroup Create(
            int groupNo,
            string groupNameAr,
            string? groupNameEn,
            string accountCode,
            bool isInactive = false,
            DateTime? inactiveDate = null,
            string? inactiveReason = null,
            string? notes = null,
            CompanyInfo? companyInfo = null,
            int userId = 0,
            string terminal = "")
        {
            var group = new BankGroup
            {
                GroupNo = groupNo,
                GroupNameAr = groupNameAr,
                GroupNameEn = groupNameEn,
                AccountCode = accountCode,
                IsInactive = isInactive,
                InactiveDate = inactiveDate,
                InactiveReason = inactiveReason,
                Notes = notes,
                CompanyInfo = companyInfo ?? CompanyInfo.Create(),
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            group.ValidateState();
            group.AddDomainEvent(new BankGroupCreatedEvent(group));
            return group;
        }

        public void UpdateNames(string groupNameAr, string? groupNameEn)
        {
            var oldNameAr = GroupNameAr;
            var oldNameEn = GroupNameEn;

            GroupNameAr = groupNameAr;
            GroupNameEn = groupNameEn;

            ValidateState();
            AddDomainEvent(new BankGroupNamesUpdatedEvent(this, oldNameAr, oldNameEn));
        }

        public void UpdateStatus(bool isInactive, DateTime? inactiveDate = null, string? inactiveReason = null)
        {
            IsInactive = isInactive;
            InactiveDate = inactiveDate;
            InactiveReason = inactiveReason;

            ValidateState();
            AddDomainEvent(new BankGroupStatusUpdatedEvent(this));
        }

        public void UpdateNotes(string? notes)
        {
            Notes = notes;
            AddDomainEvent(new BankGroupNotesUpdatedEvent(this));
        }

        private void ValidateState()
        {
            if (GroupNo <= 0)
                throw new DomainException("رقم المجموعة يجب أن يكون أكبر من صفر");

            if (string.IsNullOrWhiteSpace(GroupNameAr))
                throw new DomainException("اسم المجموعة بالعربي مطلوب");

            if (string.IsNullOrWhiteSpace(AccountCode))
                throw new DomainException("رمز الحساب مطلوب");

            if (IsInactive)
            {
                if (!InactiveDate.HasValue)
                    throw new DomainException("تاريخ التعطيل مطلوب");

                if (string.IsNullOrWhiteSpace(InactiveReason))
                    throw new DomainException("سبب التعطيل مطلوب");
            }

            if (CompanyInfo == null)
                throw new DomainException("معلومات الشركة مطلوبة");

            if (AuditInfo == null)
                throw new DomainException("معلومات التدقيق مطلوبة");
        }
    }
} 