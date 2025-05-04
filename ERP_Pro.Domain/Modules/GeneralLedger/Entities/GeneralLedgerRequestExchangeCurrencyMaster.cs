using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerRequestExchangeCurrencyMaster Entity
/// </summary>
public class GeneralLedgerRequestExchangeCurrencyMaster : Entity<GeneralLedgerRequestExchangeCurrencyMasterId>
{

    private GeneralLedgerRequestExchangeCurrencyMaster() { }

    public GeneralLedgerRequestExchangeCurrencyMaster(GeneralLedgerRequestExchangeCurrencyMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestExchangeCurrencyMaster
    /// المعرف الفريد لـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public GeneralLedgerRequestExchangeCurrencyMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerRequestExchangeCurrencyMaster
    /// DocNo الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the GeneralLedgerRequestExchangeCurrencyMaster
    /// DocSrl الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerRequestExchangeCurrencyMaster
    /// AccountDetailCode الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerRequestExchangeCurrencyMaster
    /// AccountCode الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// CurCode of the GeneralLedgerRequestExchangeCurrencyMaster
    /// CurCode الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// DocDate of the GeneralLedgerRequestExchangeCurrencyMaster
    /// DocDate الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocDsc of the GeneralLedgerRequestExchangeCurrencyMaster
    /// DocDsc الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerRequestExchangeCurrencyMaster
    /// ReferenceNumber الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocAmtL of the GeneralLedgerRequestExchangeCurrencyMaster
    /// DocAmtL الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? DocAmtL { get; private set; }

    /// <summary>
    /// DocAmtF of the GeneralLedgerRequestExchangeCurrencyMaster
    /// DocAmtF الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? DocAmtF { get; private set; }

    /// <summary>
    /// CurRate of the GeneralLedgerRequestExchangeCurrencyMaster
    /// CurRate الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerRequestExchangeCurrencyMaster
    /// AccountDetailType الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// TypeNumberShort of the GeneralLedgerRequestExchangeCurrencyMaster
    /// TypeNumberShort الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// Field1 of the GeneralLedgerRequestExchangeCurrencyMaster
    /// Field1 الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the GeneralLedgerRequestExchangeCurrencyMaster
    /// Field2 الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the GeneralLedgerRequestExchangeCurrencyMaster
    /// Field3 الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the GeneralLedgerRequestExchangeCurrencyMaster
    /// Field4 الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the GeneralLedgerRequestExchangeCurrencyMaster
    /// Field5 الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the GeneralLedgerRequestExchangeCurrencyMaster
    /// Field6 الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the GeneralLedgerRequestExchangeCurrencyMaster
    /// Field7 الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the GeneralLedgerRequestExchangeCurrencyMaster
    /// Field8 الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the GeneralLedgerRequestExchangeCurrencyMaster
    /// Field9 الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the GeneralLedgerRequestExchangeCurrencyMaster
    /// Field10 الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// ProcessedFlag of the GeneralLedgerRequestExchangeCurrencyMaster
    /// ProcessedFlag الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// ApprovedFlag of the GeneralLedgerRequestExchangeCurrencyMaster
    /// ApprovedFlag الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the GeneralLedgerRequestExchangeCurrencyMaster
    /// ApprovalUserId الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the GeneralLedgerRequestExchangeCurrencyMaster
    /// ApprovalDate الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the GeneralLedgerRequestExchangeCurrencyMaster
    /// ApprovalDescription الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// InactiveFlag of the GeneralLedgerRequestExchangeCurrencyMaster
    /// InactiveFlag الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the GeneralLedgerRequestExchangeCurrencyMaster
    /// InactivatedByUserId الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the GeneralLedgerRequestExchangeCurrencyMaster
    /// InactiveDate الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the GeneralLedgerRequestExchangeCurrencyMaster
    /// InactiveReason الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// StandbyFlag of the GeneralLedgerRequestExchangeCurrencyMaster
    /// StandbyFlag الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? StandbyFlag { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GeneralLedgerRequestExchangeCurrencyMaster
    /// ExternalPostFlag الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DocSq of the GeneralLedgerRequestExchangeCurrencyMaster
    /// DocSq الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? DocSq { get; private set; }

    /// <summary>
    /// StandByFlag of the GeneralLedgerRequestExchangeCurrencyMaster
    /// StandByFlag الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// AttachmentNumber of the GeneralLedgerRequestExchangeCurrencyMaster
    /// AttachmentNumber الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// DocBrnNo of the GeneralLedgerRequestExchangeCurrencyMaster
    /// DocBrnNo الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerRequestExchangeCurrencyMaster
    /// CompanyNumberShort الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerRequestExchangeCurrencyMaster
    /// BranchNumber الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerRequestExchangeCurrencyMaster
    /// BranchYear الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerRequestExchangeCurrencyMaster
    /// BranchUser الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocNoYr of the GeneralLedgerRequestExchangeCurrencyMaster
    /// DocNoYr الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? DocNoYr { get; private set; }

    /// <summary>
    /// DocSrlYr of the GeneralLedgerRequestExchangeCurrencyMaster
    /// DocSrlYr الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? DocSrlYr { get; private set; }

    /// <summary>
    /// MovedYear of the GeneralLedgerRequestExchangeCurrencyMaster
    /// MovedYear الخاص بـ GeneralLedgerRequestExchangeCurrencyMaster
    /// </summary>
    public decimal? MovedYear { get; private set; }

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
    public CostCenter CostCenter { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
