using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceClaimMaster Entity
/// </summary>
public class InsuranceClaimMaster : Entity<InsuranceClaimMasterId>
{

    private InsuranceClaimMaster() { }

    public InsuranceClaimMaster(InsuranceClaimMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the InsuranceClaimMaster
    /// المعرف الفريد لـ InsuranceClaimMaster
    /// </summary>
    public InsuranceClaimMasterId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the InsuranceClaimMaster
    /// BranchNumber الخاص بـ InsuranceClaimMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DocNo of the InsuranceClaimMaster
    /// DocNo الخاص بـ InsuranceClaimMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the InsuranceClaimMaster
    /// DocSer الخاص بـ InsuranceClaimMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the InsuranceClaimMaster
    /// DocDate الخاص بـ InsuranceClaimMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumber of the InsuranceClaimMaster
    /// InsuranceCompanyNumber الخاص بـ InsuranceClaimMaster
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the InsuranceClaimMaster
    /// AccountCurrency الخاص بـ InsuranceClaimMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// FDate of the InsuranceClaimMaster
    /// FDate الخاص بـ InsuranceClaimMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the InsuranceClaimMaster
    /// TDate الخاص بـ InsuranceClaimMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the InsuranceClaimMaster
    /// ReferenceNumber الخاص بـ InsuranceClaimMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the InsuranceClaimMaster
    /// DocDsc الخاص بـ InsuranceClaimMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the InsuranceClaimMaster
    /// ProcessedFlagFull الخاص بـ InsuranceClaimMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// DocAmt of the InsuranceClaimMaster
    /// DocAmt الخاص بـ InsuranceClaimMaster
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// ApprovedFlag of the InsuranceClaimMaster
    /// ApprovedFlag الخاص بـ InsuranceClaimMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the InsuranceClaimMaster
    /// ApprovalUserId الخاص بـ InsuranceClaimMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the InsuranceClaimMaster
    /// ApprovalDate الخاص بـ InsuranceClaimMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the InsuranceClaimMaster
    /// ApprovalDescription الخاص بـ InsuranceClaimMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// BranchUser of the InsuranceClaimMaster
    /// BranchUser الخاص بـ InsuranceClaimMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the InsuranceClaimMaster
    /// BranchYear الخاص بـ InsuranceClaimMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the InsuranceClaimMaster
    /// CompanyNumberShort الخاص بـ InsuranceClaimMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
