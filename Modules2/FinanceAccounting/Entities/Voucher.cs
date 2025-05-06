using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// Voucher Entity
/// </summary>
public class Voucher : Entity<VoucherId>
{

    private Voucher() { }

    public Voucher(VoucherId id, decimal? vendorSerialShort)
    {
        Id = id;
        VendorSerialShort = vendorSerialShort;
    }

    /// <summary>
    /// The unique identifier for the Voucher
    /// المعرف الفريد لـ Voucher
    /// </summary>
    public VoucherId Id { get; private set; }

    /// <summary>
    /// VoucherTypeFull of the Voucher
    /// VoucherTypeFull الخاص بـ Voucher
    /// </summary>
    public decimal? VoucherTypeFull { get; private set; }

    /// <summary>
    /// VoucherPayTypeShort of the Voucher
    /// VoucherPayTypeShort الخاص بـ Voucher
    /// </summary>
    public decimal? VoucherPayTypeShort { get; private set; }

    /// <summary>
    /// VoucherNumber of the Voucher
    /// VoucherNumber الخاص بـ Voucher
    /// </summary>
    public decimal? VoucherNumber { get; private set; }

    /// <summary>
    /// CashNumber of the Voucher
    /// CashNumber الخاص بـ Voucher
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the Voucher
    /// AccountCurrency الخاص بـ Voucher
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// VendorSerialShort of the Voucher
    /// VendorSerialShort الخاص بـ Voucher
    /// </summary>
    public decimal? VendorSerialShort { get; private set; }

    /// <summary>
    /// VoucherDate of the Voucher
    /// VoucherDate الخاص بـ Voucher
    /// </summary>
    public DateTime? VoucherDate { get; private set; }

    /// <summary>
    /// CashAmount of the Voucher
    /// CashAmount الخاص بـ Voucher
    /// </summary>
    public decimal? CashAmount { get; private set; }

    /// <summary>
    /// CashAmountForeign of the Voucher
    /// CashAmountForeign الخاص بـ Voucher
    /// </summary>
    public decimal? CashAmountForeign { get; private set; }

    /// <summary>
    /// ExchangeRate of the Voucher
    /// ExchangeRate الخاص بـ Voucher
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// VoucherPostFlag of the Voucher
    /// VoucherPostFlag الخاص بـ Voucher
    /// </summary>
    public decimal? VoucherPostFlag { get; private set; }

    /// <summary>
    /// ReferenceNumber of the Voucher
    /// ReferenceNumber الخاص بـ Voucher
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ReferenceName of the Voucher
    /// ReferenceName الخاص بـ Voucher
    /// </summary>
    public string ReferenceName { get; private set; }

    /// <summary>
    /// AccountDescription of the Voucher
    /// AccountDescription الخاص بـ Voucher
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ReceiverName of the Voucher
    /// ReceiverName الخاص بـ Voucher
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// StandByFlag of the Voucher
    /// StandByFlag الخاص بـ Voucher
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// TransferFlag of the Voucher
    /// TransferFlag الخاص بـ Voucher
    /// </summary>
    public decimal? TransferFlag { get; private set; }

    /// <summary>
    /// ChequeType of the Voucher
    /// ChequeType الخاص بـ Voucher
    /// </summary>
    public decimal? ChequeType { get; private set; }

    /// <summary>
    /// AttachmentNumber of the Voucher
    /// AttachmentNumber الخاص بـ Voucher
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// CommissionPercent of the Voucher
    /// CommissionPercent الخاص بـ Voucher
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// VoucherNumberPaymentYear of the Voucher
    /// VoucherNumberPaymentYear الخاص بـ Voucher
    /// </summary>
    public decimal? VoucherNumberPaymentYear { get; private set; }

    /// <summary>
    /// VoucherDatePaymentYear of the Voucher
    /// VoucherDatePaymentYear الخاص بـ Voucher
    /// </summary>
    public DateTime? VoucherDatePaymentYear { get; private set; }

    /// <summary>
    /// MoveChequePaymentYear of the Voucher
    /// MoveChequePaymentYear الخاص بـ Voucher
    /// </summary>
    public decimal? MoveChequePaymentYear { get; private set; }

    /// <summary>
    /// MoveChequeCurrencyYear of the Voucher
    /// MoveChequeCurrencyYear الخاص بـ Voucher
    /// </summary>
    public decimal? MoveChequeCurrencyYear { get; private set; }

    /// <summary>
    /// VendorTypeNumber of the Voucher
    /// VendorTypeNumber الخاص بـ Voucher
    /// </summary>
    public decimal? VendorTypeNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the Voucher
    /// ExternalPostFlag الخاص بـ Voucher
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// AuditReference of the Voucher
    /// AuditReference الخاص بـ Voucher
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the Voucher
    /// AuditReferenceDescription الخاص بـ Voucher
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the Voucher
    /// AuditReferenceUserId الخاص بـ Voucher
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the Voucher
    /// AuditReferenceDate الخاص بـ Voucher
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// Field1 of the Voucher
    /// Field1 الخاص بـ Voucher
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Voucher
    /// Field2 الخاص بـ Voucher
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Voucher
    /// Field3 الخاص بـ Voucher
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Voucher
    /// Field4 الخاص بـ Voucher
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Voucher
    /// Field5 الخاص بـ Voucher
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Voucher
    /// Field6 الخاص بـ Voucher
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Voucher
    /// Field7 الخاص بـ Voucher
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Voucher
    /// Field8 الخاص بـ Voucher
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Voucher
    /// Field9 الخاص بـ Voucher
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Voucher
    /// Field10 الخاص بـ Voucher
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// PostUserId of the Voucher
    /// PostUserId الخاص بـ Voucher
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the Voucher
    /// PostDate الخاص بـ Voucher
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the Voucher
    /// UnpostUserId الخاص بـ Voucher
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the Voucher
    /// UnpostDate الخاص بـ Voucher
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// DocSequence of the Voucher
    /// DocSequence الخاص بـ Voucher
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocBrnNo of the Voucher
    /// DocBrnNo الخاص بـ Voucher
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the Voucher
    /// CompanyNumberShort الخاص بـ Voucher
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the Voucher
    /// BranchNumber الخاص بـ Voucher
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the Voucher
    /// BranchYear الخاص بـ Voucher
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the Voucher
    /// BranchUser الخاص بـ Voucher
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocSerExtrnl of the Voucher
    /// DocSerExtrnl الخاص بـ Voucher
    /// </summary>
    public string DocSerExtrnl { get; private set; }

    /// <summary>
    /// RepCode of the Voucher
    /// RepCode الخاص بـ Voucher
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the Voucher
    /// AccountDetailCode الخاص بـ Voucher
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the Voucher
    /// AccountDetailType الخاص بـ Voucher
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

