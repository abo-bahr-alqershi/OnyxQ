using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerRequestMaster Entity
/// </summary>
public class GeneralLedgerRequestMaster : AggregateRoot<GeneralLedgerRequestMasterId>
{

    private GeneralLedgerRequestMaster() { }

    public GeneralLedgerRequestMaster(GeneralLedgerRequestMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestMaster
    /// المعرف الفريد لـ GeneralLedgerRequestMaster
    /// </summary>
    public GeneralLedgerRequestMasterId Id { get; private set; }

    /// <summary>
    /// DocType of the GeneralLedgerRequestMaster
    /// DocType الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the GeneralLedgerRequestMaster
    /// JournalVoucherTypeFull الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerRequestMaster
    /// DocNo الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the GeneralLedgerRequestMaster
    /// DocSer الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the GeneralLedgerRequestMaster
    /// DocDate الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// CashNumber of the GeneralLedgerRequestMaster
    /// CashNumber الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// DocRate of the GeneralLedgerRequestMaster
    /// DocRate الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? DocRate { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerRequestMaster
    /// AccountCode الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the GeneralLedgerRequestMaster
    /// AccountCurrency الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CostCenterCode of the GeneralLedgerRequestMaster
    /// CostCenterCode الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GeneralLedgerRequestMaster
    /// ProjectNumber الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ChequeType of the GeneralLedgerRequestMaster
    /// ChequeType الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? ChequeType { get; private set; }

    /// <summary>
    /// DocAmt of the GeneralLedgerRequestMaster
    /// DocAmt الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// DocAmtF of the GeneralLedgerRequestMaster
    /// DocAmtF الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? DocAmtF { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerRequestMaster
    /// ReferenceNumber الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AttachmentNumber of the GeneralLedgerRequestMaster
    /// AttachmentNumber الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// BeneficiaryName of the GeneralLedgerRequestMaster
    /// BeneficiaryName الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// ReceiverName of the GeneralLedgerRequestMaster
    /// ReceiverName الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// DocDesc of the GeneralLedgerRequestMaster
    /// DocDesc الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// RequestSide of the GeneralLedgerRequestMaster
    /// RequestSide الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string RequestSide { get; private set; }

    /// <summary>
    /// RequestReason of the GeneralLedgerRequestMaster
    /// RequestReason الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string RequestReason { get; private set; }

    /// <summary>
    /// ProcessedFlagAlt of the GeneralLedgerRequestMaster
    /// ProcessedFlagAlt الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? ProcessedFlagAlt { get; private set; }

    /// <summary>
    /// ApprovedFlag of the GeneralLedgerRequestMaster
    /// ApprovedFlag الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the GeneralLedgerRequestMaster
    /// ApprovalUserId الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the GeneralLedgerRequestMaster
    /// ApprovalDate الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the GeneralLedgerRequestMaster
    /// ApprovalDescription الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// InactiveFlag of the GeneralLedgerRequestMaster
    /// InactiveFlag الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the GeneralLedgerRequestMaster
    /// InactiveReason الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the GeneralLedgerRequestMaster
    /// InactivatedByUserId الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the GeneralLedgerRequestMaster
    /// InactiveDate الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GeneralLedgerRequestMaster
    /// ExternalPostFlag الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// VendorTypeNumber of the GeneralLedgerRequestMaster
    /// VendorTypeNumber الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? VendorTypeNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerRequestMaster
    /// CompanyNumberShort الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerRequestMaster
    /// BranchNumber الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerRequestMaster
    /// BranchYear الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerRequestMaster
    /// BranchUser الخاص بـ GeneralLedgerRequestMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

