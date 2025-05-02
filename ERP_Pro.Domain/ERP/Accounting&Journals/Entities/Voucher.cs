using System;
using System.Collections.Generic;
using System.Linq;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Entities
{
    public class Voucher : AggregateRoot
    {
        #region Basic Info
        public Guid Id { get; private set; }
        /// <summary> رقم السند </summary>
        public long Number { get; private set; }
        /// <summary> تاريخ السند </summary>
        public DateTime Date { get; private set; }
        /// <summary> وصف السند </summary>
        public string Description { get; private set; }
        /// <summary> رقم المرجع </summary>
        public string? ReferenceNumber { get; private set; }
        /// <summary> نوع السند </summary>
        public VoucherType Type { get; private set; }
        /// <summary> حالة السند </summary>
        public VoucherStatus Status { get; private set; }
        /// <summary> اسم المستلم/المدفوع له </summary>
        public string? PayeeName { get; private set; }
        /// <summary> رقم الشيك </summary>
        public string? ChequeNumber { get; private set; }
        /// <summary> تاريخ الشيك </summary>
        public DateTime? ChequeDate { get; private set; }
        /// <summary> البنك المسحوب عليه </summary>
        public string? BankName { get; private set; }
        #endregion

        #region Totals
        /// <summary> إجمالي المبالغ المدينة </summary>
        public decimal TotalDebit { get; private set; }
        /// <summary> إجمالي المبالغ الدائنة </summary>
        public decimal TotalCredit { get; private set; }
        #endregion

        #region Company Info
        public CompanyInfo CompanyInfo { get; private set; }
        #endregion

        #region Audit Info
        public AuditInfo AuditInfo { get; private set; }
        #endregion

        #region Details
        private readonly List<VoucherDetail> _details = new();
        public IReadOnlyCollection<VoucherDetail> Details => _details.AsReadOnly();
        #endregion

        private Voucher() { } // For EF Core

        public static Voucher Create(
            long number,
            DateTime date,
            string description,
            string? referenceNumber,
            VoucherType type,
            string? payeeName,
            string? chequeNumber,
            DateTime? chequeDate,
            string? bankName,
            CompanyInfo companyInfo,
            int userId,
            string terminal)
        {
            var voucher = new Voucher
            {
                Id = Guid.NewGuid(),
                Number = number,
                Date = date,
                Description = description,
                ReferenceNumber = referenceNumber,
                Type = type,
                Status = VoucherStatus.Draft,
                PayeeName = payeeName,
                ChequeNumber = chequeNumber,
                ChequeDate = chequeDate,
                BankName = bankName,
                TotalDebit = 0,
                TotalCredit = 0,
                CompanyInfo = companyInfo,
                AuditInfo = AuditInfo.Create(userId, terminal)
            };

            voucher.AddDomainEvent(new VoucherCreatedEvent(voucher));
            return voucher;
        }

        public void AddDetail(
            string accountCode,
            string? accountDetailCode,
            string? currencyCode,
            decimal? exchangeRate,
            decimal debit,
            decimal credit,
            string? costCenterCode,
            string? projectCode,
            string? description)
        {
            var detail = VoucherDetail.Create(
                accountCode,
                accountDetailCode,
                currencyCode,
                exchangeRate,
                debit,
                credit,
                costCenterCode,
                projectCode,
                description);

            _details.Add(detail);
            RecalculateTotals();

            AddDomainEvent(new VoucherDetailAddedEvent(this, detail));
        }

        public void RemoveDetail(Guid detailId)
        {
            var detail = _details.FirstOrDefault(d => d.Id == detailId);
            if (detail == null)
                throw new DomainException("Voucher detail not found");

            _details.Remove(detail);
            RecalculateTotals();

            AddDomainEvent(new VoucherDetailRemovedEvent(this, detail));
        }

        public void UpdateDetail(
            Guid detailId,
            string accountCode,
            string? accountDetailCode,
            string? currencyCode,
            decimal? exchangeRate,
            decimal debit,
            decimal credit,
            string? costCenterCode,
            string? projectCode,
            string? description)
        {
            var detail = _details.FirstOrDefault(d => d.Id == detailId);
            if (detail == null)
                throw new DomainException("Voucher detail not found");

            var oldDetail = detail;
            detail.Update(
                accountCode,
                accountDetailCode,
                currencyCode,
                exchangeRate,
                debit,
                credit,
                costCenterCode,
                projectCode,
                description);

            RecalculateTotals();

            AddDomainEvent(new VoucherDetailUpdatedEvent(this, oldDetail, detail));
        }

        public void Post()
        {
            if (Status != VoucherStatus.Draft)
                throw new DomainException("Voucher can only be posted when in draft status");

            ValidateForPosting();
            Status = VoucherStatus.Posted;

            AddDomainEvent(new VoucherPostedEvent(this));
        }

        public void Unpost()
        {
            if (Status != VoucherStatus.Posted)
                throw new DomainException("Voucher can only be unposted when in posted status");

            Status = VoucherStatus.Draft;

            AddDomainEvent(new VoucherUnpostedEvent(this));
        }

        private void RecalculateTotals()
        {
            TotalDebit = _details.Sum(d => d.Debit);
            TotalCredit = _details.Sum(d => d.Credit);
        }

        private void ValidateForPosting()
        {
            if (!_details.Any())
                throw new DomainException("Voucher must have at least one detail to be posted");

            if (Math.Abs(TotalDebit - TotalCredit) > 0.01m)
                throw new DomainException("Voucher is not balanced");

            foreach (var detail in _details)
            {
                if (detail.AccountCode == null)
                    throw new DomainException("All voucher details must have an account code");

                if (detail.Debit < 0 || detail.Credit < 0)
                    throw new DomainException("Voucher details cannot have negative amounts");

                if (detail.Debit > 0 && detail.Credit > 0)
                    throw new DomainException("Voucher details cannot have both debit and credit amounts");

                if (detail.Debit == 0 && detail.Credit == 0)
                    throw new DomainException("Voucher details must have either a debit or credit amount");
            }

            if (Type == VoucherType.Payment || Type == VoucherType.Receipt)
            {
                if (string.IsNullOrWhiteSpace(PayeeName))
                    throw new DomainException("Payee name is required for payment and receipt vouchers");
            }

            if (!string.IsNullOrWhiteSpace(ChequeNumber))
            {
                if (!ChequeDate.HasValue)
                    throw new DomainException("Cheque date is required when cheque number is specified");

                if (string.IsNullOrWhiteSpace(BankName))
                    throw new DomainException("Bank name is required when cheque number is specified");
            }
        }
    }

    public enum VoucherType
    {
        /// <summary> سند قبض </summary>
        Receipt = 1,
        /// <summary> سند صرف </summary>
        Payment = 2,
        /// <summary> سند قيد </summary>
        Journal = 3
    }

    public enum VoucherStatus
    {
        /// <summary> مسودة </summary>
        Draft = 1,
        /// <summary> مرحل </summary>
        Posted = 2
    }
} 