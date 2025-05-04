using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchaseOrderFollowUp Entity
/// </summary>
public class PurchaseOrderFollowUp : Entity<PurchaseOrderFollowUpId>
{

    private PurchaseOrderFollowUp() { }

    public PurchaseOrderFollowUp(PurchaseOrderFollowUpId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PurchaseOrderFollowUp
    /// المعرف الفريد لـ PurchaseOrderFollowUp
    /// </summary>
    public PurchaseOrderFollowUpId Id { get; private set; }

    /// <summary>
    /// PurchaseOrderNumber of the PurchaseOrderFollowUp
    /// PurchaseOrderNumber الخاص بـ PurchaseOrderFollowUp
    /// </summary>
    public decimal? PurchaseOrderNumber { get; private set; }

    /// <summary>
    /// FupdateFlag of the PurchaseOrderFollowUp
    /// FupdateFlag الخاص بـ PurchaseOrderFollowUp
    /// </summary>
    public DateTime? FupdateFlag { get; private set; }

    /// <summary>
    /// FupDescription of the PurchaseOrderFollowUp
    /// FupDescription الخاص بـ PurchaseOrderFollowUp
    /// </summary>
    public string FupDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchaseOrderFollowUp
    /// CompanyNumberShort الخاص بـ PurchaseOrderFollowUp
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchaseOrderFollowUp
    /// BranchNumber الخاص بـ PurchaseOrderFollowUp
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchaseOrderFollowUp
    /// BranchYear الخاص بـ PurchaseOrderFollowUp
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PurchaseOrderFollowUp
    /// BranchUser الخاص بـ PurchaseOrderFollowUp
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public PurchaseOrder PurchaseOrder { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
