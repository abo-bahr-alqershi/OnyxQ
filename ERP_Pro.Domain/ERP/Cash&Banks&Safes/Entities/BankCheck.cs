using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.Events;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.Entities
{
    public class BankCheck : AggregateRoot
    {
        #region Basic Info
        public long CheckNo { get; private set; }
        public DateTime CheckDate { get; private set; }
        public string CheckNumber { get; private set; }
        public decimal Amount { get; private set; }
        public decimal AmountLocal { get; private set; }
        public string BeneficiaryName { get; private set; }
        public int CheckType { get; private set; } // 1: Outgoing, 2: Incoming
        public int CheckStatus { get; private set; } // 1: New, 2: Printed, 3: Delivered, 4: Collected, 5: Returned, 6: Cancelled
        public DateTime? StatusDate { get; private set; }
        public string? StatusNotes { get; private set; }
        public long BankNo { get; private set; }
        public string? Notes { get; private set; }
        #endregion

        #region Currency Info
        public CurrencyInfo CurrencyInfo { get; private set; }
        #endregion

        #region Account Info
        public AccountReference AccountInfo { get; private set; }
        #endregion

        #region Tax Info
        public TaxInfo? TaxInfo { get; private set; }
        #endregion

        #region Document Info
        public AccountingDocumentInfo DocumentInfo { get; private set; }
        #endregion

        #region Endorsement Info
        public EndorsementInfo EndorsementInfo { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        private BankCheck() { } // For EF Core

        public static BankCheck Create(
            long checkNo,
            DateTime checkDate,
            string checkNumber,
            decimal amount,
            string? currencyCode,
            decimal exchangeRate,
            string beneficiaryName,
            int checkType,
            long bankNo,
            string? notes = null,
            string? accountCode = null,
            CompanyInfo? companyInfo = null,
            int userId = 0,
            string terminal = "",
            string? accountCodeDetail = null,
            string? accountCodeDetailSub = null,
            int? accountDetailType = null,
            string? costCenterCode = null,
            string? projectCode = null,
            string? activityCode = null,
            TaxInfo? taxInfo = null)
        {
            var currencyInfo = CurrencyInfo.Create(currencyCode, exchangeRate);
            var amountLocal = currencyInfo.ConvertToLocal(amount);
            
            var check = new BankCheck
            {
                CheckNo = checkNo,
                CheckDate = checkDate,
                CheckNumber = checkNumber,
                Amount = amount,
                AmountLocal = amountLocal,
                CurrencyInfo = currencyInfo,
                BeneficiaryName = beneficiaryName,
                CheckType = checkType,
                CheckStatus = 1, // New
                StatusDate = DateTime.UtcNow,
                BankNo = bankNo,
                Notes = notes,
                AccountInfo = accountCode != null 
                    ? AccountReference.Create(
                        accountCode,
                        accountCodeDetail,
                        accountCodeDetailSub,
                        accountDetailType,
                        costCenterCode,
                        projectCode,
                        activityCode)
                    : null,
                TaxInfo = taxInfo,
                DocumentInfo = AccountingDocumentInfo.Create(),
                EndorsementInfo = EndorsementInfo.Create(),
                CompanyInfo = companyInfo ?? CompanyInfo.Create(),
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            check.ValidateState();
            check.AddDomainEvent(new BankCheckCreatedEvent(check));
            return check;
        }

        public void UpdateStatus(int newStatus, string? notes = null)
        {
            var oldStatus = CheckStatus;
            CheckStatus = newStatus;
            StatusDate = DateTime.UtcNow;
            StatusNotes = notes;

            ValidateState();
            AddDomainEvent(new BankCheckStatusUpdatedEvent(this, oldStatus));
        }

        public void UpdateAmount(decimal amount, string? currencyCode, decimal exchangeRate)
        {
            var oldAmount = Amount;
            var oldCurrencyInfo = CurrencyInfo;

            CurrencyInfo = CurrencyInfo.Create(currencyCode, exchangeRate);
            Amount = amount;
            AmountLocal = CurrencyInfo.ConvertToLocal(amount);

            ValidateState();
            AddDomainEvent(new BankCheckAmountUpdatedEvent(this, oldAmount, oldCurrencyInfo.CurrencyCode, oldCurrencyInfo.ExchangeRate));
        }

        public void UpdateDocumentInfo(AccountingDocumentInfo documentInfo)
        {
            if (documentInfo == null)
                throw new ArgumentNullException(nameof(documentInfo));

            DocumentInfo = documentInfo;
            AddDomainEvent(new BankCheckDocumentInfoUpdatedEvent(this));
        }

        public void UpdateEndorsementInfo(EndorsementInfo endorsementInfo)
        {
            if (endorsementInfo == null)
                throw new ArgumentNullException(nameof(endorsementInfo));

            EndorsementInfo = endorsementInfo;
            AddDomainEvent(new BankCheckEndorsementUpdatedEvent(this));
        }

        public void Endorse(
            DateTime endorsementDate,
            string? accountCode = null,
            string? beneficiaryCode = null,
            string? vendorCode = null,
            string? notes = null)
        {
            EndorsementInfo = EndorsementInfo.WithEndorsement(
                endorsementDate, accountCode, beneficiaryCode, vendorCode, notes);
            
            AddDomainEvent(new BankCheckEndorsementUpdatedEvent(this));
        }

        public void UpdateTaxInfo(TaxInfo taxInfo)
        {
            if (taxInfo == null)
                throw new ArgumentNullException(nameof(taxInfo));

            TaxInfo = taxInfo;
            AddDomainEvent(new BankCheckTaxInfoUpdatedEvent(this));
        }

        private void ValidateState()
        {
            if (CheckNo <= 0)
                throw new DomainException("رقم الشيك يجب أن يكون أكبر من صفر");

            if (string.IsNullOrWhiteSpace(CheckNumber))
                throw new DomainException("رقم الشيك مطلوب");

            if (Amount <= 0)
                throw new DomainException("قيمة الشيك يجب أن تكون أكبر من صفر");

            if (CurrencyInfo == null)
                throw new DomainException("معلومات العملة مطلوبة");

            if (string.IsNullOrWhiteSpace(BeneficiaryName))
                throw new DomainException("اسم المستفيد مطلوب");

            if (CheckType != 1 && CheckType != 2)
                throw new DomainException("نوع الشيك غير صحيح");

            if (CheckStatus < 1 || CheckStatus > 6)
                throw new DomainException("حالة الشيك غير صحيحة");

            if (BankNo <= 0)
                throw new DomainException("رقم البنك يجب أن يكون أكبر من صفر");

            if (CompanyInfo == null)
                throw new DomainException("معلومات الشركة مطلوبة");

            if (AuditInfo == null)
                throw new DomainException("معلومات التدقيق مطلوبة");
        }
    }
} 