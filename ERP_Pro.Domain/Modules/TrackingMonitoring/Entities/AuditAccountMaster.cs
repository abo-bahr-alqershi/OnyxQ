using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;
namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// AuditAccountMaster Entity
/// </summary>
public class AuditAccountMaster : AggregateRoot<AuditAccountMasterId>
{

    private AuditAccountMaster() { }

    public AuditAccountMaster(AuditAccountMasterId id, decimal? auditNumber, decimal? auditType)
    {
        Id = id;
        AuditNumber = auditNumber;
        AuditType = auditType;
    }

    /// <summary>
    /// The unique identifier for the AuditAccountMaster
    /// المعرف الفريد لـ AuditAccountMaster
    /// </summary>
    public AuditAccountMasterId Id { get; private set; }

    /// <summary>
    /// AuditNumber of the AuditAccountMaster
    /// AuditNumber الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? AuditNumber { get; private set; }

    /// <summary>
    /// AuditType of the AuditAccountMaster
    /// AuditType الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? AuditType { get; private set; }

    /// <summary>
    /// DocType of the AuditAccountMaster
    /// DocType الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the AuditAccountMaster
    /// JournalVoucherTypeFull الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the AuditAccountMaster
    /// DocNo الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AuditAccountMaster
    /// DocSer الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the AuditAccountMaster
    /// DocDate الخاص بـ AuditAccountMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCode of the AuditAccountMaster
    /// AccountCode الخاص بـ AuditAccountMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AuditAccountMaster
    /// AccountDetailCode الخاص بـ AuditAccountMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AuditAccountMaster
    /// AccountDetailType الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the AuditAccountMaster
    /// AccountCurrency الخاص بـ AuditAccountMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// ExchangeRate of the AuditAccountMaster
    /// ExchangeRate الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// Amount of the AuditAccountMaster
    /// Amount الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// AmountForeign of the AuditAccountMaster
    /// AmountForeign الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// CCode of the AuditAccountMaster
    /// CCode الخاص بـ AuditAccountMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the AuditAccountMaster
    /// VendorCode الخاص بـ AuditAccountMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AuditAccountMaster
    /// CostCenterCode الخاص بـ AuditAccountMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the AuditAccountMaster
    /// ColumnNumberShort الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// AccountDescription of the AuditAccountMaster
    /// AccountDescription الخاص بـ AuditAccountMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AuditAccountMaster
    /// ReferenceNumber الخاص بـ AuditAccountMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// ReferenceName of the AuditAccountMaster
    /// ReferenceName الخاص بـ AuditAccountMaster
    /// </summary>
    public string ReferenceName { get; private set; }

    /// <summary>
    /// CashNumber of the AuditAccountMaster
    /// CashNumber الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// ChequeType of the AuditAccountMaster
    /// ChequeType الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? ChequeType { get; private set; }

    /// <summary>
    /// ReceiverName of the AuditAccountMaster
    /// ReceiverName الخاص بـ AuditAccountMaster
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// BeneficiaryName of the AuditAccountMaster
    /// BeneficiaryName الخاص بـ AuditAccountMaster
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// StandByFlag of the AuditAccountMaster
    /// StandByFlag الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// AttachmentNumber of the AuditAccountMaster
    /// AttachmentNumber الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// ReasonDelete of the AuditAccountMaster
    /// ReasonDelete الخاص بـ AuditAccountMaster
    /// </summary>
    public string ReasonDelete { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the AuditAccountMaster
    /// ExternalPostFlag الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// UserId of the AuditAccountMaster
    /// UserId الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// AuditDate of the AuditAccountMaster
    /// AuditDate الخاص بـ AuditAccountMaster
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// PostUserId of the AuditAccountMaster
    /// PostUserId الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the AuditAccountMaster
    /// PostDate الخاص بـ AuditAccountMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the AuditAccountMaster
    /// UnpostUserId الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the AuditAccountMaster
    /// UnpostDate الخاص بـ AuditAccountMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// TerminalName of the AuditAccountMaster
    /// TerminalName الخاص بـ AuditAccountMaster
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AuditAccountMaster
    /// CompanyNumberShort الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AuditAccountMaster
    /// BranchNumber الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AuditAccountMaster
    /// BranchYear الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AuditAccountMaster
    /// BranchUser الخاص بـ AuditAccountMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

