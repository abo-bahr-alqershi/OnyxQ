using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// BranchDocument Entity
/// </summary>
public class BranchDocument : Entity<BranchDocumentId>
{
    private BranchDocument() { }

    /// <summary>
    /// The unique identifier for the BranchDocument
    /// المعرف الفريد لـ BranchDocument
    /// </summary>
    public BranchDocumentId Id { get; private set; }

    /// <summary>
    /// CodeNumber of the BranchDocument
    /// CodeNumber الخاص بـ BranchDocument
    /// </summary>
    public decimal? CodeNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the BranchDocument
    /// BranchNumber الخاص بـ BranchDocument
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DocNo of the BranchDocument
    /// DocNo الخاص بـ BranchDocument
    /// </summary>
    public string DocNo { get; private set; }

    /// <summary>
    /// IssueDate of the BranchDocument
    /// IssueDate الخاص بـ BranchDocument
    /// </summary>
    public DateTime? IssueDate { get; private set; }

    /// <summary>
    /// EndDate of the BranchDocument
    /// EndDate الخاص بـ BranchDocument
    /// </summary>
    public DateTime? EndDate { get; private set; }

    /// <summary>
    /// DurAlrm of the BranchDocument
    /// DurAlrm الخاص بـ BranchDocument
    /// </summary>
    public decimal? DurAlrm { get; private set; }

    /// <summary>
    /// RenewalDate of the BranchDocument
    /// RenewalDate الخاص بـ BranchDocument
    /// </summary>
    public string RenewalDate { get; private set; }

    /// <summary>
    /// IssuePlace of the BranchDocument
    /// IssuePlace الخاص بـ BranchDocument
    /// </summary>
    public string IssuePlace { get; private set; }

    /// <summary>
    /// Field1 of the BranchDocument
    /// Field1 الخاص بـ BranchDocument
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the BranchDocument
    /// Field2 الخاص بـ BranchDocument
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the BranchDocument
    /// Field3 الخاص بـ BranchDocument
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the BranchDocument
    /// Field4 الخاص بـ BranchDocument
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the BranchDocument
    /// Field5 الخاص بـ BranchDocument
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the BranchDocument
    /// Field6 الخاص بـ BranchDocument
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the BranchDocument
    /// Field7 الخاص بـ BranchDocument
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the BranchDocument
    /// Field8 الخاص بـ BranchDocument
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the BranchDocument
    /// Field9 الخاص بـ BranchDocument
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the BranchDocument
    /// Field10 الخاص بـ BranchDocument
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// InactiveFlag of the BranchDocument
    /// InactiveFlag الخاص بـ BranchDocument
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the BranchDocument
    /// InactivatedByUserId الخاص بـ BranchDocument
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the BranchDocument
    /// InactiveDate الخاص بـ BranchDocument
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the BranchDocument
    /// InactiveReason الخاص بـ BranchDocument
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Branch
    /// </summary>
    public Branch Branch { get; private set; }
    #endregion
}
}
