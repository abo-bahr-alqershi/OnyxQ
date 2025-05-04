using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// ChequeTrace Entity
/// </summary>
public class ChequeTrace : Entity<ChequeTraceId>
{
    private ChequeTrace() { }

    /// <summary>
    /// The unique identifier for the ChequeTrace
    /// المعرف الفريد لـ ChequeTrace
    /// </summary>
    public ChequeTraceId Id { get; private set; }

    /// <summary>
    /// AuditType of the ChequeTrace
    /// AuditType الخاص بـ ChequeTrace
    /// </summary>
    public decimal? AuditType { get; private set; }

    /// <summary>
    /// VoucherTypeFull of the ChequeTrace
    /// VoucherTypeFull الخاص بـ ChequeTrace
    /// </summary>
    public decimal? VoucherTypeFull { get; private set; }

    /// <summary>
    /// VoucherPayTypeShort of the ChequeTrace
    /// VoucherPayTypeShort الخاص بـ ChequeTrace
    /// </summary>
    public decimal? VoucherPayTypeShort { get; private set; }

    /// <summary>
    /// VoucherNumber of the ChequeTrace
    /// VoucherNumber الخاص بـ ChequeTrace
    /// </summary>
    public decimal? VoucherNumber { get; private set; }

    /// <summary>
    /// CashNumber of the ChequeTrace
    /// CashNumber الخاص بـ ChequeTrace
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// VendorSerialShort of the ChequeTrace
    /// VendorSerialShort الخاص بـ ChequeTrace
    /// </summary>
    public decimal? VendorSerialShort { get; private set; }

    /// <summary>
    /// AccountCode of the ChequeTrace
    /// AccountCode الخاص بـ ChequeTrace
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the ChequeTrace
    /// AccountDetailCode الخاص بـ ChequeTrace
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the ChequeTrace
    /// AccountDetailType الخاص بـ ChequeTrace
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the ChequeTrace
    /// AccountCurrency الخاص بـ ChequeTrace
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountDescription of the ChequeTrace
    /// AccountDescription الخاص بـ ChequeTrace
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ReturnReason of the ChequeTrace
    /// ReturnReason الخاص بـ ChequeTrace
    /// </summary>
    public string ReturnReason { get; private set; }

    /// <summary>
    /// AccountAmount of the ChequeTrace
    /// AccountAmount الخاص بـ ChequeTrace
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// AccountAmountForeign of the ChequeTrace
    /// AccountAmountForeign الخاص بـ ChequeTrace
    /// </summary>
    public decimal? AccountAmountForeign { get; private set; }

    /// <summary>
    /// CostCenterCode of the ChequeTrace
    /// CostCenterCode الخاص بـ ChequeTrace
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// CCode of the ChequeTrace
    /// CCode الخاص بـ ChequeTrace
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the ChequeTrace
    /// VendorCode الخاص بـ ChequeTrace
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ChequeType of the ChequeTrace
    /// ChequeType الخاص بـ ChequeTrace
    /// </summary>
    public decimal? ChequeType { get; private set; }

    /// <summary>
    /// CashBankNumber of the ChequeTrace
    /// CashBankNumber الخاص بـ ChequeTrace
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// ChequeNumber of the ChequeTrace
    /// ChequeNumber الخاص بـ ChequeTrace
    /// </summary>
    public string ChequeNumber { get; private set; }

    /// <summary>
    /// ValueDate of the ChequeTrace
    /// ValueDate الخاص بـ ChequeTrace
    /// </summary>
    public DateTime? ValueDate { get; private set; }

    /// <summary>
    /// ChequePostFlag of the ChequeTrace
    /// ChequePostFlag الخاص بـ ChequeTrace
    /// </summary>
    public decimal? ChequePostFlag { get; private set; }

    /// <summary>
    /// ChequeValuedFlag of the ChequeTrace
    /// ChequeValuedFlag الخاص بـ ChequeTrace
    /// </summary>
    public decimal? ChequeValuedFlag { get; private set; }

    /// <summary>
    /// NoteNumber of the ChequeTrace
    /// NoteNumber الخاص بـ ChequeTrace
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// BankNumber of the ChequeTrace
    /// BankNumber الخاص بـ ChequeTrace
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the ChequeTrace
    /// ReferenceNumber الخاص بـ ChequeTrace
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the ChequeTrace
    /// RecordNumber الخاص بـ ChequeTrace
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// Endrsmnt of the ChequeTrace
    /// Endrsmnt الخاص بـ ChequeTrace
    /// </summary>
    public decimal? Endrsmnt { get; private set; }

    /// <summary>
    /// AccountCodeEnd of the ChequeTrace
    /// AccountCodeEnd الخاص بـ ChequeTrace
    /// </summary>
    public string AccountCodeEnd { get; private set; }

    /// <summary>
    /// AccountDetailEndCode of the ChequeTrace
    /// AccountDetailEndCode الخاص بـ ChequeTrace
    /// </summary>
    public string AccountDetailEndCode { get; private set; }

    /// <summary>
    /// AccountDetailTypeEnd of the ChequeTrace
    /// AccountDetailTypeEnd الخاص بـ ChequeTrace
    /// </summary>
    public decimal? AccountDetailTypeEnd { get; private set; }

    /// <summary>
    /// CCodeEnd of the ChequeTrace
    /// CCodeEnd الخاص بـ ChequeTrace
    /// </summary>
    public string CCodeEnd { get; private set; }

    /// <summary>
    /// VendorCodeEnd of the ChequeTrace
    /// VendorCodeEnd الخاص بـ ChequeTrace
    /// </summary>
    public string VendorCodeEnd { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ChequeTrace
    /// ExternalPostFlag الخاص بـ ChequeTrace
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DocSequence of the ChequeTrace
    /// DocSequence الخاص بـ ChequeTrace
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// DocTypeRef of the ChequeTrace
    /// DocTypeRef الخاص بـ ChequeTrace
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocJvTypeRef of the ChequeTrace
    /// DocJvTypeRef الخاص بـ ChequeTrace
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the ChequeTrace
    /// DocNoRef الخاص بـ ChequeTrace
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the ChequeTrace
    /// DocSerRef الخاص بـ ChequeTrace
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// PostUserId of the ChequeTrace
    /// PostUserId الخاص بـ ChequeTrace
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the ChequeTrace
    /// PostDate الخاص بـ ChequeTrace
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the ChequeTrace
    /// UnpostUserId الخاص بـ ChequeTrace
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the ChequeTrace
    /// UnpostDate الخاص بـ ChequeTrace
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// AuditUserId of the ChequeTrace
    /// AuditUserId الخاص بـ ChequeTrace
    /// </summary>
    public decimal? AuditUserId { get; private set; }

    /// <summary>
    /// AuditDate of the ChequeTrace
    /// AuditDate الخاص بـ ChequeTrace
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ChequeTrace
    /// CompanyNumberShort الخاص بـ ChequeTrace
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ChequeTrace
    /// BranchNumber الخاص بـ ChequeTrace
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ChequeTrace
    /// BranchYear الخاص بـ ChequeTrace
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ChequeTrace
    /// BranchUser الخاص بـ ChequeTrace
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// EndrsmntDate of the ChequeTrace
    /// EndrsmntDate الخاص بـ ChequeTrace
    /// </summary>
    public DateTime? EndrsmntDate { get; private set; }
}
}
