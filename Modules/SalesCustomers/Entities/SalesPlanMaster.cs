using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesPlanMaster Entity
/// </summary>
public class SalesPlanMaster : Entity<SalesPlanMasterId>
{
    private SalesPlanMaster() { }

    /// <summary>
    /// The unique identifier for the SalesPlanMaster
    /// المعرف الفريد لـ SalesPlanMaster
    /// </summary>
    public SalesPlanMasterId Id { get; private set; }

    /// <summary>
    /// PlanSerial of the SalesPlanMaster
    /// PlanSerial الخاص بـ SalesPlanMaster
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    /// <summary>
    /// PlanType of the SalesPlanMaster
    /// PlanType الخاص بـ SalesPlanMaster
    /// </summary>
    public decimal? PlanType { get; private set; }

    /// <summary>
    /// PlanDistributionType of the SalesPlanMaster
    /// PlanDistributionType الخاص بـ SalesPlanMaster
    /// </summary>
    public decimal? PlanDistributionType { get; private set; }

    /// <summary>
    /// PlanPeriodType of the SalesPlanMaster
    /// PlanPeriodType الخاص بـ SalesPlanMaster
    /// </summary>
    public decimal? PlanPeriodType { get; private set; }

    /// <summary>
    /// ReferenceNumber of the SalesPlanMaster
    /// ReferenceNumber الخاص بـ SalesPlanMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// PlanDescription of the SalesPlanMaster
    /// PlanDescription الخاص بـ SalesPlanMaster
    /// </summary>
    public string PlanDescription { get; private set; }

    /// <summary>
    /// IncludeFreeQuantityFlag of the SalesPlanMaster
    /// IncludeFreeQuantityFlag الخاص بـ SalesPlanMaster
    /// </summary>
    public decimal? IncludeFreeQuantityFlag { get; private set; }

    /// <summary>
    /// PlanNumber of the SalesPlanMaster
    /// PlanNumber الخاص بـ SalesPlanMaster
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesPlanMaster
    /// BranchNumber الخاص بـ SalesPlanMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SalesPlanMaster
    /// BranchYear الخاص بـ SalesPlanMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SalesPlanMaster
    /// CompanyNumberShort الخاص بـ SalesPlanMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the SalesPlanMaster
    /// BranchUser الخاص بـ SalesPlanMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: SalesPlanMaster to SalesPlanDetail
    /// </summary>
    public IReadOnlyCollection<SalesPlanDetail> SalesPlanDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: SalesPlanMaster to SalesmanCommissionDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCommissionDetail> SalesmanCommissionDetails { get; private set; }
    #endregion
}
}
