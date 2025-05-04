using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BranchVoucher Entity
/// </summary>
public class BranchVoucher : Entity<BranchVoucherId>
{

    private BranchVoucher() { }

    public BranchVoucher(BranchVoucherId id, decimal? vendorSerialShort)
    {
        Id = id;
        VendorSerialShort = vendorSerialShort;
    }

    /// <summary>
    /// The unique identifier for the BranchVoucher
    /// المعرف الفريد لـ BranchVoucher
    /// </summary>
    public BranchVoucherId Id { get; private set; }

    /// <summary>
    /// VoucherTypeFull of the BranchVoucher
    /// VoucherTypeFull الخاص بـ BranchVoucher
    /// </summary>
    public decimal? VoucherTypeFull { get; private set; }

    /// <summary>
    /// VoucherPayTypeShort of the BranchVoucher
    /// VoucherPayTypeShort الخاص بـ BranchVoucher
    /// </summary>
    public decimal? VoucherPayTypeShort { get; private set; }

    /// <summary>
    /// VoucherNumber of the BranchVoucher
    /// VoucherNumber الخاص بـ BranchVoucher
    /// </summary>
    public decimal? VoucherNumber { get; private set; }

    /// <summary>
    /// CashNumber of the BranchVoucher
    /// CashNumber الخاص بـ BranchVoucher
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the BranchVoucher
    /// AccountCurrency الخاص بـ BranchVoucher
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// VendorSerialShort of the BranchVoucher
    /// VendorSerialShort الخاص بـ BranchVoucher
    /// </summary>
    public decimal? VendorSerialShort { get; private set; }

    /// <summary>
    /// VoucherDate of the BranchVoucher
    /// VoucherDate الخاص بـ BranchVoucher
    /// </summary>
    public DateTime? VoucherDate { get; private set; }

    /// <summary>
    /// CashAmount of the BranchVoucher
    /// CashAmount الخاص بـ BranchVoucher
    /// </summary>
    public decimal? CashAmount { get; private set; }

    /// <summary>
    /// CashAmountForeign of the BranchVoucher
    /// CashAmountForeign الخاص بـ BranchVoucher
    /// </summary>
    public decimal? CashAmountForeign { get; private set; }

    /// <summary>
    /// ExchangeRate of the BranchVoucher
    /// ExchangeRate الخاص بـ BranchVoucher
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// VoucherPostFlag of the BranchVoucher
    /// VoucherPostFlag الخاص بـ BranchVoucher
    /// </summary>
    public decimal? VoucherPostFlag { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BranchVoucher
    /// ReferenceNumber الخاص بـ BranchVoucher
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ReferenceName of the BranchVoucher
    /// ReferenceName الخاص بـ BranchVoucher
    /// </summary>
    public string ReferenceName { get; private set; }

    /// <summary>
    /// AccountDescription of the BranchVoucher
    /// AccountDescription الخاص بـ BranchVoucher
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ReceiverName of the BranchVoucher
    /// ReceiverName الخاص بـ BranchVoucher
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// StandByFlag of the BranchVoucher
    /// StandByFlag الخاص بـ BranchVoucher
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// TransferFlag of the BranchVoucher
    /// TransferFlag الخاص بـ BranchVoucher
    /// </summary>
    public decimal? TransferFlag { get; private set; }

    /// <summary>
    /// ChequeType of the BranchVoucher
    /// ChequeType الخاص بـ BranchVoucher
    /// </summary>
    public decimal? ChequeType { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the BranchVoucher
    /// ColumnNumberShort الخاص بـ BranchVoucher
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// CostCenterCode of the BranchVoucher
    /// CostCenterCode الخاص بـ BranchVoucher
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BranchVoucher
    /// ProjectNumber الخاص بـ BranchVoucher
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BranchVoucher
    /// ActivityNumber الخاص بـ BranchVoucher
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// AttachmentNumber of the BranchVoucher
    /// AttachmentNumber الخاص بـ BranchVoucher
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// CommissionPercent of the BranchVoucher
    /// CommissionPercent الخاص بـ BranchVoucher
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// VoucherNumberPaymentYear of the BranchVoucher
    /// VoucherNumberPaymentYear الخاص بـ BranchVoucher
    /// </summary>
    public decimal? VoucherNumberPaymentYear { get; private set; }

    /// <summary>
    /// VoucherDatePaymentYear of the BranchVoucher
    /// VoucherDatePaymentYear الخاص بـ BranchVoucher
    /// </summary>
    public DateTime? VoucherDatePaymentYear { get; private set; }

    /// <summary>
    /// MoveChequePaymentYear of the BranchVoucher
    /// MoveChequePaymentYear الخاص بـ BranchVoucher
    /// </summary>
    public decimal? MoveChequePaymentYear { get; private set; }

    /// <summary>
    /// MoveChequeCurrencyYear of the BranchVoucher
    /// MoveChequeCurrencyYear الخاص بـ BranchVoucher
    /// </summary>
    public decimal? MoveChequeCurrencyYear { get; private set; }

    /// <summary>
    /// VendorTypeNumber of the BranchVoucher
    /// VendorTypeNumber الخاص بـ BranchVoucher
    /// </summary>
    public decimal? VendorTypeNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the BranchVoucher
    /// ExternalPostFlag الخاص بـ BranchVoucher
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// AuditReference of the BranchVoucher
    /// AuditReference الخاص بـ BranchVoucher
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// AuditReferenceDescription of the BranchVoucher
    /// AuditReferenceDescription الخاص بـ BranchVoucher
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// AuditReferenceUserId of the BranchVoucher
    /// AuditReferenceUserId الخاص بـ BranchVoucher
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// AuditReferenceDate of the BranchVoucher
    /// AuditReferenceDate الخاص بـ BranchVoucher
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// Field1 of the BranchVoucher
    /// Field1 الخاص بـ BranchVoucher
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BranchVoucher
    /// Field2 الخاص بـ BranchVoucher
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BranchVoucher
    /// Field3 الخاص بـ BranchVoucher
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the BranchVoucher
    /// Field4 الخاص بـ BranchVoucher
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the BranchVoucher
    /// Field5 الخاص بـ BranchVoucher
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the BranchVoucher
    /// Field6 الخاص بـ BranchVoucher
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the BranchVoucher
    /// Field7 الخاص بـ BranchVoucher
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the BranchVoucher
    /// Field8 الخاص بـ BranchVoucher
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the BranchVoucher
    /// Field9 الخاص بـ BranchVoucher
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the BranchVoucher
    /// Field10 الخاص بـ BranchVoucher
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// PostUserId of the BranchVoucher
    /// PostUserId الخاص بـ BranchVoucher
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the BranchVoucher
    /// PostDate الخاص بـ BranchVoucher
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the BranchVoucher
    /// UnpostUserId الخاص بـ BranchVoucher
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the BranchVoucher
    /// UnpostDate الخاص بـ BranchVoucher
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// DocSequence of the BranchVoucher
    /// DocSequence الخاص بـ BranchVoucher
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocBrnNo of the BranchVoucher
    /// DocBrnNo الخاص بـ BranchVoucher
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BranchVoucher
    /// CompanyNumberShort الخاص بـ BranchVoucher
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchVoucher
    /// BranchNumber الخاص بـ BranchVoucher
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BranchVoucher
    /// BranchYear الخاص بـ BranchVoucher
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BranchVoucher
    /// BranchUser الخاص بـ BranchVoucher
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
