using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.Events;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.Entities
{
    public class CashAtBank : AggregateRoot
    {
        #region Basic Info
        public long BankNo { get; private set; }
        public string BankNameAr { get; private set; }
        public string? BankNameEn { get; private set; }
        public long BankSerial { get; private set; }
        public int? GroupNo { get; private set; }
        public string? BankAccount { get; private set; }
        public int? ConnectedBranchNo { get; private set; }
        public DateTime? LastConfirmationDate { get; private set; }
        #endregion

        #region Account Info
        public AccountReference AccountInfo { get; private set; }
        #endregion

        #region Contact Info
        public BankContactInfo ContactInfo { get; private set; }
        #endregion

        #region Document Info
        public BankDocumentInfo DocumentInfo { get; private set; }
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

        private CashAtBank() { } // For EF Core

        public static CashAtBank Create(
            long bankNo,
            string accountCode,
            string bankNameAr,
            string? bankNameEn,
            long bankSerial,
            int? groupNo,
            string? bankAccount,
            int? connectedBranchNo,
            BankContactInfo contactInfo,
            BankDocumentInfo documentInfo,
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
            var bank = new CashAtBank
            {
                BankNo = bankNo,
                AccountInfo = AccountReference.Create(
                    accountCode,
                    accountCodeDetail,
                    accountCodeDetailSub,
                    accountDetailType,
                    costCenterCode,
                    projectCode,
                    activityCode),
                BankNameAr = bankNameAr,
                BankNameEn = bankNameEn,
                BankSerial = bankSerial,
                GroupNo = groupNo,
                BankAccount = bankAccount,
                ConnectedBranchNo = connectedBranchNo,
                ContactInfo = contactInfo,
                DocumentInfo = documentInfo,
                Settings = settings,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            bank.ValidateState();
            bank.AddDomainEvent(new CashAtBankCreatedEvent(bank));
            return bank;
        }

        public void UpdateNames(string bankNameAr, string? bankNameEn)
        {
            var oldNameAr = BankNameAr;
            var oldNameEn = BankNameEn;

            BankNameAr = bankNameAr;
            BankNameEn = bankNameEn;

            ValidateState();
            AddDomainEvent(new CashAtBankNamesUpdatedEvent(this, oldNameAr, oldNameEn));
        }

        public void UpdateContactInfo(BankContactInfo contactInfo)
        {
            var oldContactInfo = ContactInfo;
            ContactInfo = contactInfo;

            ValidateState();
            AddDomainEvent(new CashAtBankContactInfoUpdatedEvent(this, oldContactInfo, contactInfo));
        }

        public void UpdateDocumentInfo(BankDocumentInfo documentInfo)
        {
            var oldDocumentInfo = DocumentInfo;
            DocumentInfo = documentInfo;

            ValidateState();
            AddDomainEvent(new CashAtBankDocumentInfoUpdatedEvent(this, oldDocumentInfo, documentInfo));
        }

        public void UpdateSettings(CashSettings settings)
        {
            var oldSettings = Settings;
            Settings = settings;

            ValidateState();
            AddDomainEvent(new CashAtBankSettingsUpdatedEvent(this, oldSettings, settings));
        }

        public void AddBalance(CashBalance balance)
        {
            if (balance == null)
                throw new ArgumentNullException(nameof(balance));

            _balances.Add(balance);
            AddDomainEvent(new CashAtBankBalanceAddedEvent(this, balance));
        }

        public void Confirm()
        {
            LastConfirmationDate = DateTime.UtcNow;
            AddDomainEvent(new CashAtBankConfirmedEvent(this));
        }

        private void ValidateState()
        {
            if (BankNo <= 0)
                throw new DomainException("رقم البنك يجب أن يكون أكبر من صفر");

            if (AccountInfo == null)
                throw new DomainException("معلومات الحساب مطلوبة");

            if (string.IsNullOrWhiteSpace(BankNameAr))
                throw new DomainException("اسم البنك بالعربي مطلوب");

            if (BankSerial <= 0)
                throw new DomainException("الرقم التسلسلي يجب أن يكون أكبر من صفر");

            if (ContactInfo == null)
                throw new DomainException("معلومات الاتصال مطلوبة");

            if (DocumentInfo == null)
                throw new DomainException("معلومات المستندات مطلوبة");

            if (Settings == null)
                throw new DomainException("إعدادات البنك مطلوبة");

            if (CompanyInfo == null)
                throw new DomainException("معلومات الشركة مطلوبة");

            if (AuditInfo == null)
                throw new DomainException("معلومات التدقيق مطلوبة");
        }
    }
} 