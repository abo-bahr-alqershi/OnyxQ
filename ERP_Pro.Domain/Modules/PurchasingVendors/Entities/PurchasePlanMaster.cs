using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchasePlanMaster Entity
/// </summary>
public class PurchasePlanMaster : Entity<PurchasePlanMasterId>
{

    private PurchasePlanMaster() { }

    public PurchasePlanMaster(PurchasePlanMasterId id, decimal? planSerial)
    {
        Id = id;
        PlanSerial = planSerial;
    }

    /// <summary>
    /// The unique identifier for the PurchasePlanMaster
    /// المعرف الفريد لـ PurchasePlanMaster
    /// </summary>
    public PurchasePlanMasterId Id { get; private set; }

    /// <summary>
    /// PlanSerial of the PurchasePlanMaster
    /// PlanSerial الخاص بـ PurchasePlanMaster
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    /// <summary>
    /// PlanType of the PurchasePlanMaster
    /// PlanType الخاص بـ PurchasePlanMaster
    /// </summary>
    public decimal? PlanType { get; private set; }

    /// <summary>
    /// PlanDistributionType of the PurchasePlanMaster
    /// PlanDistributionType الخاص بـ PurchasePlanMaster
    /// </summary>
    public decimal? PlanDistributionType { get; private set; }

    /// <summary>
    /// PlanPeriodType of the PurchasePlanMaster
    /// PlanPeriodType الخاص بـ PurchasePlanMaster
    /// </summary>
    public decimal? PlanPeriodType { get; private set; }

    /// <summary>
    /// ReferenceNumber of the PurchasePlanMaster
    /// ReferenceNumber الخاص بـ PurchasePlanMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// PlanDescription of the PurchasePlanMaster
    /// PlanDescription الخاص بـ PurchasePlanMaster
    /// </summary>
    public string PlanDescription { get; private set; }

    /// <summary>
    /// PlanNumber of the PurchasePlanMaster
    /// PlanNumber الخاص بـ PurchasePlanMaster
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchasePlanMaster
    /// BranchNumber الخاص بـ PurchasePlanMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PurchasePlanMaster
    /// BranchYear الخاص بـ PurchasePlanMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchasePlanMaster
    /// CompanyNumberShort الخاص بـ PurchasePlanMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the PurchasePlanMaster
    /// BranchUser الخاص بـ PurchasePlanMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

