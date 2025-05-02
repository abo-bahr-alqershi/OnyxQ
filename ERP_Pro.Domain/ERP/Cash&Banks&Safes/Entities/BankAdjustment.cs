using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.Events;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.Entities
{
    public class BankAdjustment : AggregateRoot
    {
        #region Basic Info
        public long AdjustmentNo { get; private set; }
        public DateTime AdjustmentDate { get; private set; }
        public long BankNo { get; private set; }
        public int AdjustmentType { get; private set; } // 1: Addition, 2: Deduction
        public decimal Amount { get; private set; }
        public decimal AmountLocal { get; private set; }
        public string? Description { get; private set; }
        public string? Notes { get; private set; }
        public bool IsPosted { get; private set; }
        public DateTime? PostedDate { get; private set; }
        #endregion

        #region Account Info
        public AccountReference AccountInfo { get; private set; }
        #endregion

        #region Currency Info
        public CurrencyInfo CurrencyInfo { get; private set; }
        #endregion

        #region Tax Info
        public TaxInfo? TaxInfo { get; private set; }
        #endregion

        #region Document Info
        public AccountingDocumentInfo DocumentInfo { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        private BankAdjustment() { } // For EF Core

        public static BankAdjustment Create(
            long adjustmentNo,
            DateTime adjustmentDate,
            long bankNo,
            int adjustmentType,
            decimal amount,
            string accountCode,
            string? currencyCode,
            decimal exchangeRate,
            string? description = null,
            string? notes = null,
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

            var adjustment = new BankAdjustment
            {
                AdjustmentNo = adjustmentNo,
                AdjustmentDate = adjustmentDate,
                BankNo = bankNo,
                AdjustmentType = adjustmentType,
                Amount = amount,
                AmountLocal = amountLocal,
                CurrencyInfo = currencyInfo,
                AccountInfo = AccountReference.Create(
                    accountCode,
                    accountCodeDetail,
                    accountCodeDetailSub,
                    accountDetailType,
                    costCenterCode,
                    projectCode,
                    activityCode),
                TaxInfo = taxInfo,
                Description = description,
                Notes = notes,
                IsPosted = false,
                DocumentInfo = AccountingDocumentInfo.Create(),
                CompanyInfo = companyInfo ?? CompanyInfo.Create(),
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            adjustment.ValidateState();
            adjustment.AddDomainEvent(new BankAdjustmentCreatedEvent(adjustment));
            return adjustment;
        }

        public void UpdateAmount(decimal amount, string? currencyCode, decimal exchangeRate)
        {
            if (IsPosted)
                throw new DomainException("لا يمكن تعديل التسوية بعد الترحيل");

            var oldAmount = Amount;
            var oldCurrencyInfo = CurrencyInfo;

            CurrencyInfo = CurrencyInfo.Create(currencyCode, exchangeRate);
            Amount = amount;
            AmountLocal = CurrencyInfo.ConvertToLocal(amount);

            ValidateState();
            AddDomainEvent(new BankAdjustmentAmountUpdatedEvent(this, oldAmount, oldCurrencyInfo.CurrencyCode, oldCurrencyInfo.ExchangeRate));
        }

        public void UpdateDocumentInfo(AccountingDocumentInfo documentInfo)
        {
            if (IsPosted)
                throw new DomainException("لا يمكن تعديل التسوية بعد الترحيل");

            if (documentInfo == null)
                throw new ArgumentNullException(nameof(documentInfo));

            DocumentInfo = documentInfo;
            AddDomainEvent(new BankAdjustmentDocumentInfoUpdatedEvent(this));
        }

        public void Post(int userId)
        {
            if (IsPosted)
                throw new DomainException("التسوية مرحلة مسبقاً");

            IsPosted = true;
            PostedDate = DateTime.UtcNow;
            DocumentInfo = DocumentInfo.SetPosted(userId);

            AddDomainEvent(new BankAdjustmentPostedEvent(this));
        }

        public void Unpost()
        {
            if (!IsPosted)
                throw new DomainException("التسوية غير مرحلة");

            IsPosted = false;
            PostedDate = null;
            DocumentInfo = DocumentInfo.SetUnposted();

            AddDomainEvent(new BankAdjustmentUnpostedEvent(this));
        }

        public void UpdateTaxInfo(TaxInfo taxInfo)
        {
            if (IsPosted)
                throw new DomainException("لا يمكن تعديل التسوية بعد الترحيل");

            if (taxInfo == null)
                throw new ArgumentNullException(nameof(taxInfo));

            TaxInfo = taxInfo;
            AddDomainEvent(new BankAdjustmentTaxInfoUpdatedEvent(this));
        }

        private void ValidateState()
        {
            if (AdjustmentNo <= 0)
                throw new DomainException("رقم التسوية يجب أن يكون أكبر من صفر");

            if (BankNo <= 0)
                throw new DomainException("رقم البنك يجب أن يكون أكبر من صفر");

            if (AdjustmentType != 1 && AdjustmentType != 2)
                throw new DomainException("نوع التسوية غير صحيح");

            if (Amount <= 0)
                throw new DomainException("قيمة التسوية يجب أن تكون أكبر من صفر");

            if (CurrencyInfo == null)
                throw new DomainException("معلومات العملة مطلوبة");

            if (AccountInfo == null)
                throw new DomainException("معلومات الحساب مطلوبة");

            if (DocumentInfo == null)
                throw new DomainException("معلومات المستند مطلوبة");

            if (CompanyInfo == null)
                throw new DomainException("معلومات الشركة مطلوبة");

            if (AuditInfo == null)
                throw new DomainException("معلومات التدقيق مطلوبة");
        }
    }
} 