using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// OutgoingPlanDetail Entity
/// </summary>
public class OutgoingPlanDetail : Entity<OutgoingPlanDetailId>
{

    private OutgoingPlanDetail() { }

    public OutgoingPlanDetail(OutgoingPlanDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the OutgoingPlanDetail
    /// المعرف الفريد لـ OutgoingPlanDetail
    /// </summary>
    public OutgoingPlanDetailId Id { get; private set; }

    /// <summary>
    /// PlanNumber of the OutgoingPlanDetail
    /// PlanNumber الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// PlanType of the OutgoingPlanDetail
    /// PlanType الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? PlanType { get; private set; }

    /// <summary>
    /// PlanPeriodType of the OutgoingPlanDetail
    /// PlanPeriodType الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? PlanPeriodType { get; private set; }

    /// <summary>
    /// ItemCode of the OutgoingPlanDetail
    /// ItemCode الخاص بـ OutgoingPlanDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the OutgoingPlanDetail
    /// ItemUnit الخاص بـ OutgoingPlanDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the OutgoingPlanDetail
    /// PSize الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the OutgoingPlanDetail
    /// WarehouseCode الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the OutgoingPlanDetail
    /// CostCenterCode الخاص بـ OutgoingPlanDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the OutgoingPlanDetail
    /// ProjectNumber الخاص بـ OutgoingPlanDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the OutgoingPlanDetail
    /// ActivityNumber الخاص بـ OutgoingPlanDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// Month of the OutgoingPlanDetail
    /// Month الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? Month { get; private set; }

    /// <summary>
    /// FDate of the OutgoingPlanDetail
    /// FDate الخاص بـ OutgoingPlanDetail
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the OutgoingPlanDetail
    /// TDate الخاص بـ OutgoingPlanDetail
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// ItemQuantity of the OutgoingPlanDetail
    /// ItemQuantity الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// HighLimit of the OutgoingPlanDetail
    /// HighLimit الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? HighLimit { get; private set; }

    /// <summary>
    /// LowLimit of the OutgoingPlanDetail
    /// LowLimit الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? LowLimit { get; private set; }

    /// <summary>
    /// RecordNumber of the OutgoingPlanDetail
    /// RecordNumber الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// PlanDescription of the OutgoingPlanDetail
    /// PlanDescription الخاص بـ OutgoingPlanDetail
    /// </summary>
    public string PlanDescription { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OutgoingPlanDetail
    /// CompanyNumberShort الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the OutgoingPlanDetail
    /// BranchUser الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchNumber of the OutgoingPlanDetail
    /// BranchNumber الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OutgoingPlanDetail
    /// BranchYear الخاص بـ OutgoingPlanDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public OutgoingPlanMaster OutgoingPlanMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

