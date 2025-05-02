using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.Events;
using ERP_Pro.Domain.ERP.Cash&Banks&Safes.ValueObjects;

namespace ERP_Pro.Domain.ERP.Cash&Banks&Safes.Entities
{
    public class BankReconciliation : AggregateRoot
    {
        #region Basic Info
        public long ReconciliationNo { get; private set; }
        public DateTime ReconciliationDate { get; private set; }
        public long BankNo { get; private set; }
        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }
        public decimal BankBalance { get; private set; }
        public decimal SystemBalance { get; private set; }
        public decimal Difference { get; private set; }
        public string? Notes { get; private set; }
        public bool IsPosted { get; private set; }
        public DateTime? PostedDate { get; private set; }
        #endregion

        #region Account Info
        public AccountReference AccountInfo { get; private set; }
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

        private readonly List<BankReconciliationItem> _items = new();
        public virtual IReadOnlyCollection<BankReconciliationItem> Items => _items.AsReadOnly();

        private BankReconciliation() { } // For EF Core

        public static BankReconciliation Create(
            long reconciliationNo,
            DateTime reconciliationDate,
            long bankNo,
            string accountCode,
            DateTime fromDate,
            DateTime toDate,
            decimal bankBalance,
            decimal systemBalance,
            string? notes = null,
            CompanyInfo? companyInfo = null,
            int userId = 0,
            string terminal = "",
            string? accountCodeDetail = null,
            string? accountCodeDetailSub = null,
            int? accountDetailType = null,
            string? costCenterCode = null,
            string? projectCode = null,
            string? activityCode = null)
        {
            var reconciliation = new BankReconciliation
            {
                ReconciliationNo = reconciliationNo,
                ReconciliationDate = reconciliationDate,
                BankNo = bankNo,
                AccountInfo = AccountReference.Create(
                    accountCode,
                    accountCodeDetail,
                    accountCodeDetailSub,
                    accountDetailType,
                    costCenterCode,
                    projectCode,
                    activityCode),
                FromDate = fromDate,
                ToDate = toDate,
                BankBalance = bankBalance,
                SystemBalance = systemBalance,
                Difference = bankBalance - systemBalance,
                Notes = notes,
                IsPosted = false,
                DocumentInfo = AccountingDocumentInfo.Create(),
                CompanyInfo = companyInfo ?? CompanyInfo.Create(),
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            reconciliation.ValidateState();
            reconciliation.AddDomainEvent(new BankReconciliationCreatedEvent(reconciliation));
            return reconciliation;
        }

        public void AddItem(BankReconciliationItem item)
        {
            if (IsPosted)
                throw new DomainException("لا يمكن إضافة بنود بعد الترحيل");

            _items.Add(item);
            RecalculateBalances();
            AddDomainEvent(new BankReconciliationItemAddedEvent(this, item));
        }

        public void RemoveItem(BankReconciliationItem item)
        {
            if (IsPosted)
                throw new DomainException("لا يمكن حذف بنود بعد الترحيل");

            _items.Remove(item);
            RecalculateBalances();
            AddDomainEvent(new BankReconciliationItemRemovedEvent(this, item));
        }

        public void UpdateBalances(decimal bankBalance, decimal systemBalance)
        {
            if (IsPosted)
                throw new DomainException("لا يمكن تعديل الأرصدة بعد الترحيل");

            var oldBankBalance = BankBalance;
            var oldSystemBalance = SystemBalance;

            BankBalance = bankBalance;
            SystemBalance = systemBalance;
            Difference = bankBalance - systemBalance;

            ValidateState();
            AddDomainEvent(new BankReconciliationBalancesUpdatedEvent(this, oldBankBalance, oldSystemBalance));
        }

        public void UpdateDocumentInfo(AccountingDocumentInfo documentInfo)
        {
            if (IsPosted)
                throw new DomainException("لا يمكن تعديل المستندات بعد الترحيل");

            if (documentInfo == null)
                throw new ArgumentNullException(nameof(documentInfo));

            DocumentInfo = documentInfo;
            AddDomainEvent(new BankReconciliationDocumentInfoUpdatedEvent(this));
        }

        public void Post(int userId)
        {
            if (IsPosted)
                throw new DomainException("المطابقة مرحلة مسبقاً");

            IsPosted = true;
            PostedDate = DateTime.UtcNow;
            DocumentInfo = DocumentInfo.SetPosted(userId);

            AddDomainEvent(new BankReconciliationPostedEvent(this));
        }

        public void Unpost()
        {
            if (!IsPosted)
                throw new DomainException("المطابقة غير مرحلة");

            IsPosted = false;
            PostedDate = null;
            DocumentInfo = DocumentInfo.SetUnposted();

            AddDomainEvent(new BankReconciliationUnpostedEvent(this));
        }

        private void RecalculateBalances()
        {
            decimal totalAdjustments = 0;
            foreach (var item in _items)
            {
                if (item.AdjustmentType == 1) // Addition
                    totalAdjustments += item.Amount;
                else if (item.AdjustmentType == 2) // Deduction
                    totalAdjustments -= item.Amount;
            }

            SystemBalance += totalAdjustments;
            Difference = BankBalance - SystemBalance;
        }

        private void ValidateState()
        {
            if (ReconciliationNo <= 0)
                throw new DomainException("رقم المطابقة يجب أن يكون أكبر من صفر");

            if (BankNo <= 0)
                throw new DomainException("رقم البنك يجب أن يكون أكبر من صفر");

            if (FromDate > ToDate)
                throw new DomainException("تاريخ البداية يجب أن يكون قبل تاريخ النهاية");

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

    public class BankReconciliationItem : Entity
    {
        public long ItemNo { get; private set; }
        public long ReconciliationNo { get; private set; }
        public int AdjustmentType { get; private set; } // 1: Addition, 2: Deduction
        public decimal Amount { get; private set; }
        public string? Description { get; private set; }
        public string? Notes { get; private set; }
        public AccountReference? AccountInfo { get; private set; }
        public CurrencyInfo? CurrencyInfo { get; private set; }

        private BankReconciliationItem() { } // For EF Core

        public static BankReconciliationItem Create(
            long itemNo,
            long reconciliationNo,
            int adjustmentType,
            decimal amount,
            string? description = null,
            string? notes = null,
            string? accountCode = null,
            string? currencyCode = null,
            decimal exchangeRate = 1m,
            string? accountCodeDetail = null,
            string? accountCodeDetailSub = null,
            int? accountDetailType = null,
            string? costCenterCode = null,
            string? projectCode = null,
            string? activityCode = null)
        {
            var item = new BankReconciliationItem
            {
                ItemNo = itemNo,
                ReconciliationNo = reconciliationNo,
                AdjustmentType = adjustmentType,
                Amount = amount,
                Description = description,
                Notes = notes,
                AccountInfo = accountCode != null ? AccountReference.Create(
                    accountCode,
                    accountCodeDetail,
                    accountCodeDetailSub,
                    accountDetailType,
                    costCenterCode,
                    projectCode,
                    activityCode) : null,
                CurrencyInfo = currencyCode != null ? CurrencyInfo.Create(
                    currencyCode,
                    exchangeRate) : null
            };

            item.ValidateState();
            return item;
        }

        private void ValidateState()
        {
            if (ItemNo <= 0)
                throw new DomainException("رقم البند يجب أن يكون أكبر من صفر");

            if (ReconciliationNo <= 0)
                throw new DomainException("رقم المطابقة يجب أن يكون أكبر من صفر");

            if (AdjustmentType != 1 && AdjustmentType != 2)
                throw new DomainException("نوع التسوية غير صحيح");

            if (Amount <= 0)
                throw new DomainException("قيمة التسوية يجب أن تكون أكبر من صفر");
        }
    }
} 