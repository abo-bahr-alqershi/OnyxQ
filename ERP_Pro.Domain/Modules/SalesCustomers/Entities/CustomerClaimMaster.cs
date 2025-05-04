using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerClaimMaster Entity
/// </summary>
public class CustomerClaimMaster : Entity<CustomerClaimMasterId>
{

    private CustomerClaimMaster() { }

    public CustomerClaimMaster(CustomerClaimMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the CustomerClaimMaster
    /// المعرف الفريد لـ CustomerClaimMaster
    /// </summary>
    public CustomerClaimMasterId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the CustomerClaimMaster
    /// BranchNumber الخاص بـ CustomerClaimMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DocNo of the CustomerClaimMaster
    /// DocNo الخاص بـ CustomerClaimMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the CustomerClaimMaster
    /// DocSer الخاص بـ CustomerClaimMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the CustomerClaimMaster
    /// DocDate الخاص بـ CustomerClaimMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCurrency of the CustomerClaimMaster
    /// AccountCurrency الخاص بـ CustomerClaimMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// FDate of the CustomerClaimMaster
    /// FDate الخاص بـ CustomerClaimMaster
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the CustomerClaimMaster
    /// TDate الخاص بـ CustomerClaimMaster
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the CustomerClaimMaster
    /// ReferenceNumber الخاص بـ CustomerClaimMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocDsc of the CustomerClaimMaster
    /// DocDsc الخاص بـ CustomerClaimMaster
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the CustomerClaimMaster
    /// ProcessedFlagFull الخاص بـ CustomerClaimMaster
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// DocAmt of the CustomerClaimMaster
    /// DocAmt الخاص بـ CustomerClaimMaster
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// ApprovedFlag of the CustomerClaimMaster
    /// ApprovedFlag الخاص بـ CustomerClaimMaster
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// ApprovalUserId of the CustomerClaimMaster
    /// ApprovalUserId الخاص بـ CustomerClaimMaster
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// ApprovalDate of the CustomerClaimMaster
    /// ApprovalDate الخاص بـ CustomerClaimMaster
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// ApprovalDescription of the CustomerClaimMaster
    /// ApprovalDescription الخاص بـ CustomerClaimMaster
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// BranchUser of the CustomerClaimMaster
    /// BranchUser الخاص بـ CustomerClaimMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the CustomerClaimMaster
    /// BranchYear الخاص بـ CustomerClaimMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CustomerClaimMaster
    /// CompanyNumberShort الخاص بـ CustomerClaimMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// CCode of the CustomerClaimMaster
    /// CCode الخاص بـ CustomerClaimMaster
    /// </summary>
    public string CCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
