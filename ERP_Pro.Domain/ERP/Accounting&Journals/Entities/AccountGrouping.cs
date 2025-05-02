using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class AccountGrouping : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> رقم المجموعة الفريد، يستخدم لتجميع الحسابات في تصنيفات معينة </summary>
        public int GroupNo { get; private set; }
        /// <summary> معلومات المجموعة (الاسم بالعربي والإنجليزي) </summary>
        public GroupInfo GroupInfo { get; private set; }
        /// <summary> معلومات التقرير </summary>
        public ReportInfo ReportInfo { get; private set; }
        /// <summary> حالة المجموعة </summary>
        public bool IsActive { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Navigation Properties
        private readonly List<Account> _accounts = new();
        public IReadOnlyCollection<Account> Accounts => _accounts.AsReadOnly();
        #endregion

        private AccountGrouping() { } // For EF Core

        public static AccountGrouping Create(
            int groupNo,
            GroupInfo groupInfo,
            ReportInfo reportInfo,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var group = new AccountGrouping
            {
                Id = Guid.NewGuid(),
                GroupNo = groupNo,
                GroupInfo = groupInfo,
                ReportInfo = reportInfo,
                IsActive = true,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            group.AddDomainEvent(new AccountGroupingCreatedEvent(group));
            return group;
        }

        public void UpdateGroupInfo(GroupInfo groupInfo)
        {
            var oldGroupInfo = GroupInfo;
            GroupInfo = groupInfo;

            AddDomainEvent(new AccountGroupingInfoUpdatedEvent(this, oldGroupInfo));
        }

        public void UpdateReportInfo(ReportInfo reportInfo)
        {
            var oldReportInfo = ReportInfo;
            ReportInfo = reportInfo;

            AddDomainEvent(new AccountGroupingReportInfoUpdatedEvent(this, oldReportInfo));
        }

        public void Activate()
        {
            if (IsActive)
                throw new DomainException("Account grouping is already active");

            IsActive = true;
            AddDomainEvent(new AccountGroupingActivatedEvent(this));
        }

        public void Deactivate()
        {
            if (!IsActive)
                throw new DomainException("Account grouping is already inactive");

            IsActive = false;
            AddDomainEvent(new AccountGroupingDeactivatedEvent(this));
        }

        private void ValidateState()
        {
            if (GroupNo <= 0)
                throw new DomainException("Group number must be greater than zero");

            if (GroupInfo == null)
                throw new DomainException("Group info is required");

            if (ReportInfo == null)
                throw new DomainException("Report info is required");

            if (CompanyInfo == null)
                throw new DomainException("Company info is required");
        }
    }
}