using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects;
namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// CompensationQuantitySetupDetail Entity
/// </summary>
public class CompensationQuantitySetupDetail : Entity<CompensationQuantitySetupDetailId>
{

    private CompensationQuantitySetupDetail() { }

    public CompensationQuantitySetupDetail(CompensationQuantitySetupDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CompensationQuantitySetupDetail
    /// المعرف الفريد لـ CompensationQuantitySetupDetail
    /// </summary>
    public CompensationQuantitySetupDetailId Id { get; private set; }

    /// <summary>
    /// ItemCode of the CompensationQuantitySetupDetail
    /// ItemCode الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the CompensationQuantitySetupDetail
    /// ItemUnit الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// GuarantorCode of the CompensationQuantitySetupDetail
    /// GuarantorCode الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ItemType of the CompensationQuantitySetupDetail
    /// ItemType الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// FValue of the CompensationQuantitySetupDetail
    /// FValue الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? FValue { get; private set; }

    /// <summary>
    /// TValue of the CompensationQuantitySetupDetail
    /// TValue الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? TValue { get; private set; }

    /// <summary>
    /// PSize of the CompensationQuantitySetupDetail
    /// PSize الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ActivityNumber of the CompensationQuantitySetupDetail
    /// ActivityNumber الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// CostCenterCode of the CompensationQuantitySetupDetail
    /// CostCenterCode الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ActivityNumber of the CompensationQuantitySetupDetail
    /// ActivityNumber الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProjectNumber of the CompensationQuantitySetupDetail
    /// ProjectNumber الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the CompensationQuantitySetupDetail
    /// BranchNumber الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// WarehouseCode of the CompensationQuantitySetupDetail
    /// WarehouseCode الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// FCollectionPercent of the CompensationQuantitySetupDetail
    /// FCollectionPercent الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? FCollectionPercent { get; private set; }

    /// <summary>
    /// TCollectionPercent of the CompensationQuantitySetupDetail
    /// TCollectionPercent الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? TCollectionPercent { get; private set; }

    /// <summary>
    /// Quantity of the CompensationQuantitySetupDetail
    /// Quantity الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? Quantity { get; private set; }

    /// <summary>
    /// HighLimitPercent of the CompensationQuantitySetupDetail
    /// HighLimitPercent الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? HighLimitPercent { get; private set; }

    /// <summary>
    /// LowLimitPercent of the CompensationQuantitySetupDetail
    /// LowLimitPercent الخاص بـ CompensationQuantitySetupDetail
    /// </summary>
    public decimal? LowLimitPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CompensationQuantitySetupMaster CompensationQuantitySetupMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

