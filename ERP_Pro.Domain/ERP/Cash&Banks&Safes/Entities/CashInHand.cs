using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.Events;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.Entities
{
    public class CashInHand : AggregateRoot
    {
        #region Basic Info
        public long CashNo { get; private set; }
        public string CashNameAr { get; private set; }
        public string? CashNameEn { get; private set; }
        public long CashSerial { get; private set; }
        public int? CashType { get; private set; }
        public int? ConnectedBranchNo { get; private set; }
        public DateTime? LastConfirmationDate { get; private set; }
        public int? GroupNo { get; private set; }
        #endregion

        #region Account Info
        public AccountReference AccountInfo { get; private set; }
        #endregion

        #region Settings
        public CashSettings Settings { get; private set; }
        #endregion

        #region Balance Info
        private readonly List<CashBalance> _balances = new();
        public virtual IReadOnlyCollection<CashBalance> Balances => _balances.AsReadOnly();
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        private CashInHand() { } // For EF Core

        public static CashInHand Create(
            long cashNo,
            string cashNameAr,
            string? cashNameEn,
            string accountCode,
            long cashSerial,
            int? cashType,
            int? connectedBranchNo,
            int? groupNo,
            CashSettings settings,
            CompanyInfo companyInfo,
            int userId,
            string terminal,
            string? accountCodeDetail = null,
            string? accountCodeDetailSub = null,
            int? accountDetailType = null,
            string? costCenterCode = null,
            string? projectCode = null,
            string? activityCode = null)
        {
            var cash = new CashInHand
            {
                CashNo = cashNo,
                CashNameAr = cashNameAr,
                CashNameEn = cashNameEn,
                AccountInfo = AccountReference.Create(
                    accountCode,
                    accountCodeDetail,
                    accountCodeDetailSub,
                    accountDetailType,
                    costCenterCode,
                    projectCode,
                    activityCode),
                CashSerial = cashSerial,
                CashType = cashType,
                ConnectedBranchNo = connectedBranchNo,
                GroupNo = groupNo,
                Settings = settings,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            cash.ValidateState();
            cash.AddDomainEvent(new CashInHandCreatedEvent(cash));
            return cash;
        }

        public void UpdateNames(string cashNameAr, string? cashNameEn)
        {
            var oldNameAr = CashNameAr;
            var oldNameEn = CashNameEn;

            CashNameAr = cashNameAr;
            CashNameEn = cashNameEn;

            ValidateState();
            AddDomainEvent(new CashInHandNamesUpdatedEvent(this, oldNameAr, oldNameEn));
        }

        public void UpdateSettings(CashSettings newSettings)
        {
            var oldSettings = Settings;
            Settings = newSettings;

            ValidateState();
            AddDomainEvent(new CashInHandSettingsUpdatedEvent(this, oldSettings, newSettings));
        }

        public void AddBalance(CashBalance balance)
        {
            if (balance == null)
                throw new ArgumentNullException(nameof(balance));

            _balances.Add(balance);
            AddDomainEvent(new CashInHandBalanceAddedEvent(this, balance));
        }

        public void Confirm()
        {
            LastConfirmationDate = DateTime.UtcNow;
            AddDomainEvent(new CashInHandConfirmedEvent(this));
        }

        private void ValidateState()
        {
            if (CashNo <= 0)
                throw new DomainException("رقم الصندوق يجب أن يكون أكبر من صفر");

            if (string.IsNullOrWhiteSpace(CashNameAr))
                throw new DomainException("اسم الصندوق بالعربي مطلوب");

            if (AccountInfo == null)
                throw new DomainException("معلومات الحساب مطلوبة");

            if (CashSerial <= 0)
                throw new DomainException("الرقم التسلسلي يجب أن يكون أكبر من صفر");

            if (Settings == null)
                throw new DomainException("إعدادات الصندوق مطلوبة");

            if (CompanyInfo == null)
                throw new DomainException("معلومات الشركة مطلوبة");

            if (AuditInfo == null)
                throw new DomainException("معلومات التدقيق مطلوبة");
        }
    }
} 