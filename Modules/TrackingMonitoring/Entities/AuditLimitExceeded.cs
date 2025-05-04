using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// AuditLimitExceeded Entity
/// </summary>
public class AuditLimitExceeded : Entity<AuditLimitExceededId>
{
    private AuditLimitExceeded() { }

    /// <summary>
    /// The unique identifier for the AuditLimitExceeded
    /// المعرف الفريد لـ AuditLimitExceeded
    /// </summary>
    public AuditLimitExceededId Id { get; private set; }

    /// <summary>
    /// AuditNumber of the AuditLimitExceeded
    /// AuditNumber الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? AuditNumber { get; private set; }

    /// <summary>
    /// AuditType of the AuditLimitExceeded
    /// AuditType الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? AuditType { get; private set; }

    /// <summary>
    /// DocType of the AuditLimitExceeded
    /// DocType الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the AuditLimitExceeded
    /// JournalVoucherTypeFull الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the AuditLimitExceeded
    /// DocNo الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AuditLimitExceeded
    /// DocSer الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// AccountCode of the AuditLimitExceeded
    /// AccountCode الخاص بـ AuditLimitExceeded
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AuditLimitExceeded
    /// AccountDetailCode الخاص بـ AuditLimitExceeded
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AuditLimitExceeded
    /// AccountDetailType الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the AuditLimitExceeded
    /// AccountCurrency الخاص بـ AuditLimitExceeded
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// Amount of the AuditLimitExceeded
    /// Amount الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// AmountForeign of the AuditLimitExceeded
    /// AmountForeign الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// CostCenterCode of the AuditLimitExceeded
    /// CostCenterCode الخاص بـ AuditLimitExceeded
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AuditLimitExceeded
    /// ProjectNumber الخاص بـ AuditLimitExceeded
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AuditLimitExceeded
    /// ActivityNumber الخاص بـ AuditLimitExceeded
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// CCode of the AuditLimitExceeded
    /// CCode الخاص بـ AuditLimitExceeded
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the AuditLimitExceeded
    /// VendorCode الخاص بـ AuditLimitExceeded
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// AccountDescription of the AuditLimitExceeded
    /// AccountDescription الخاص بـ AuditLimitExceeded
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AuditLimitExceeded
    /// ReferenceNumber الخاص بـ AuditLimitExceeded
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CashNumber of the AuditLimitExceeded
    /// CashNumber الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// ChequeNumber of the AuditLimitExceeded
    /// ChequeNumber الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ValueDate of the AuditLimitExceeded
    /// ValueDate الخاص بـ AuditLimitExceeded
    /// </summary>
    public DateTime? ValueDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the AuditLimitExceeded
    /// ExternalPostFlag الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// TerminalName of the AuditLimitExceeded
    /// TerminalName الخاص بـ AuditLimitExceeded
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// RecordNumber of the AuditLimitExceeded
    /// RecordNumber الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// AccountCodeLimit of the AuditLimitExceeded
    /// AccountCodeLimit الخاص بـ AuditLimitExceeded
    /// </summary>
    public string AccountCodeLimit { get; private set; }

    /// <summary>
    /// CostCenterCodeLimit of the AuditLimitExceeded
    /// CostCenterCodeLimit الخاص بـ AuditLimitExceeded
    /// </summary>
    public string CostCenterCodeLimit { get; private set; }

    /// <summary>
    /// AccountCurrencyLimit of the AuditLimitExceeded
    /// AccountCurrencyLimit الخاص بـ AuditLimitExceeded
    /// </summary>
    public string AccountCurrencyLimit { get; private set; }

    /// <summary>
    /// AmountLimit of the AuditLimitExceeded
    /// AmountLimit الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? AmountLimit { get; private set; }

    /// <summary>
    /// ExceedLimit of the AuditLimitExceeded
    /// ExceedLimit الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? ExceedLimit { get; private set; }

    /// <summary>
    /// AuditUserId of the AuditLimitExceeded
    /// AuditUserId الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? AuditUserId { get; private set; }

    /// <summary>
    /// AuditDate of the AuditLimitExceeded
    /// AuditDate الخاص بـ AuditLimitExceeded
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// BranchNumber of the AuditLimitExceeded
    /// BranchNumber الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AuditLimitExceeded
    /// BranchYear الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AuditLimitExceeded
    /// CompanyNumberShort الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the AuditLimitExceeded
    /// BranchUser الخاص بـ AuditLimitExceeded
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
