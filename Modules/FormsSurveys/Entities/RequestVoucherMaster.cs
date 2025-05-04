using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// RequestVoucherMaster Entity
/// </summary>
public class RequestVoucherMaster : Entity<RequestVoucherMasterId>
{
    private RequestVoucherMaster() { }

    /// <summary>
    /// The unique identifier for the RequestVoucherMaster
    /// المعرف الفريد لـ RequestVoucherMaster
    /// </summary>
    public RequestVoucherMasterId Id { get; private set; }

    /// <summary>
    /// VoucherTypeFull of the RequestVoucherMaster
    /// VoucherTypeFull الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? VoucherTypeFull { get; private set; }

    /// <summary>
    /// VoucherPayTypeShort of the RequestVoucherMaster
    /// VoucherPayTypeShort الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? VoucherPayTypeShort { get; private set; }

    /// <summary>
    /// VoucherNumber of the RequestVoucherMaster
    /// VoucherNumber الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? VoucherNumber { get; private set; }

    /// <summary>
    /// CashNumber of the RequestVoucherMaster
    /// CashNumber الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the RequestVoucherMaster
    /// AccountCurrency الخاص بـ RequestVoucherMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// VendorSerialShort of the RequestVoucherMaster
    /// VendorSerialShort الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? VendorSerialShort { get; private set; }

    /// <summary>
    /// VoucherDate of the RequestVoucherMaster
    /// VoucherDate الخاص بـ RequestVoucherMaster
    /// </summary>
    public DateTime? VoucherDate { get; private set; }

    /// <summary>
    /// CashAmount of the RequestVoucherMaster
    /// CashAmount الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? CashAmount { get; private set; }

    /// <summary>
    /// CashAmountForeign of the RequestVoucherMaster
    /// CashAmountForeign الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? CashAmountForeign { get; private set; }

    /// <summary>
    /// ExchangeRate of the RequestVoucherMaster
    /// ExchangeRate الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the RequestVoucherMaster
    /// ReferenceNumber الخاص بـ RequestVoucherMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ReferenceName of the RequestVoucherMaster
    /// ReferenceName الخاص بـ RequestVoucherMaster
    /// </summary>
    public string ReferenceName { get; private set; }

    /// <summary>
    /// AccountDescription of the RequestVoucherMaster
    /// AccountDescription الخاص بـ RequestVoucherMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// StandByFlag of the RequestVoucherMaster
    /// StandByFlag الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// TransferFlag of the RequestVoucherMaster
    /// TransferFlag الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? TransferFlag { get; private set; }

    /// <summary>
    /// ChequeType of the RequestVoucherMaster
    /// ChequeType الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? ChequeType { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the RequestVoucherMaster
    /// ColumnNumberShort الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// CostCenterCode of the RequestVoucherMaster
    /// CostCenterCode الخاص بـ RequestVoucherMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the RequestVoucherMaster
    /// ProjectNumber الخاص بـ RequestVoucherMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// AttachmentNumber of the RequestVoucherMaster
    /// AttachmentNumber الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// CommissionPercent of the RequestVoucherMaster
    /// CommissionPercent الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// VoucherNumberPaymentYear of the RequestVoucherMaster
    /// VoucherNumberPaymentYear الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? VoucherNumberPaymentYear { get; private set; }

    /// <summary>
    /// VoucherDatePaymentYear of the RequestVoucherMaster
    /// VoucherDatePaymentYear الخاص بـ RequestVoucherMaster
    /// </summary>
    public DateTime? VoucherDatePaymentYear { get; private set; }

    /// <summary>
    /// MoveChequePaymentYear of the RequestVoucherMaster
    /// MoveChequePaymentYear الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? MoveChequePaymentYear { get; private set; }

    /// <summary>
    /// VendorTypeNumber of the RequestVoucherMaster
    /// VendorTypeNumber الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? VendorTypeNumber { get; private set; }

    /// <summary>
    /// DocSequence of the RequestVoucherMaster
    /// DocSequence الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ActivityNumber of the RequestVoucherMaster
    /// ActivityNumber الخاص بـ RequestVoucherMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// DocBrnNo of the RequestVoucherMaster
    /// DocBrnNo الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// ProcessedFlagAlt of the RequestVoucherMaster
    /// ProcessedFlagAlt الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? ProcessedFlagAlt { get; private set; }

    /// <summary>
    /// ApprovedFlag of the RequestVoucherMaster
    /// ApprovedFlag الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the RequestVoucherMaster
    /// ApprovalUserId الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the RequestVoucherMaster
    /// ApprovalDate الخاص بـ RequestVoucherMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the RequestVoucherMaster
    /// ApprovalDescription الخاص بـ RequestVoucherMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// InactiveFlag of the RequestVoucherMaster
    /// InactiveFlag الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the RequestVoucherMaster
    /// InactiveReason الخاص بـ RequestVoucherMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the RequestVoucherMaster
    /// InactivatedByUserId الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the RequestVoucherMaster
    /// InactiveDate الخاص بـ RequestVoucherMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// BeneficiaryName of the RequestVoucherMaster
    /// BeneficiaryName الخاص بـ RequestVoucherMaster
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// ReceiverName of the RequestVoucherMaster
    /// ReceiverName الخاص بـ RequestVoucherMaster
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// RequestSide of the RequestVoucherMaster
    /// RequestSide الخاص بـ RequestVoucherMaster
    /// </summary>
    public string RequestSide { get; private set; }

    /// <summary>
    /// RequestReason of the RequestVoucherMaster
    /// RequestReason الخاص بـ RequestVoucherMaster
    /// </summary>
    public string RequestReason { get; private set; }

    /// <summary>
    /// DocType of the RequestVoucherMaster
    /// DocType الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// Field1 of the RequestVoucherMaster
    /// Field1 الخاص بـ RequestVoucherMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the RequestVoucherMaster
    /// Field2 الخاص بـ RequestVoucherMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the RequestVoucherMaster
    /// Field3 الخاص بـ RequestVoucherMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the RequestVoucherMaster
    /// Field4 الخاص بـ RequestVoucherMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the RequestVoucherMaster
    /// Field5 الخاص بـ RequestVoucherMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the RequestVoucherMaster
    /// Field6 الخاص بـ RequestVoucherMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the RequestVoucherMaster
    /// Field7 الخاص بـ RequestVoucherMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the RequestVoucherMaster
    /// Field8 الخاص بـ RequestVoucherMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the RequestVoucherMaster
    /// Field9 الخاص بـ RequestVoucherMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the RequestVoucherMaster
    /// Field10 الخاص بـ RequestVoucherMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the RequestVoucherMaster
    /// CompanyNumberShort الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the RequestVoucherMaster
    /// BranchNumber الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the RequestVoucherMaster
    /// BranchYear الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the RequestVoucherMaster
    /// BranchUser الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocNoYr of the RequestVoucherMaster
    /// DocNoYr الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? DocNoYr { get; private set; }

    /// <summary>
    /// DocSrlYr of the RequestVoucherMaster
    /// DocSrlYr الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? DocSrlYr { get; private set; }

    /// <summary>
    /// MovedYear of the RequestVoucherMaster
    /// MovedYear الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? MovedYear { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the RequestVoucherMaster
    /// ExternalPostFlag الخاص بـ RequestVoucherMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: RequestVoucherMaster to GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestVoucherMasterAccount> GeneralLedgerRequestVoucherMasterAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: RequestVoucherMaster to RequestVoucherDetail
    /// </summary>
    public IReadOnlyCollection<RequestVoucherDetail> RequestVoucherDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Collector
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GeneralLedgerRequestTypes
    /// </summary>
    public GeneralLedgerRequestTypes GeneralLedgerRequestTypes { get; private set; }
    #endregion
}
}
