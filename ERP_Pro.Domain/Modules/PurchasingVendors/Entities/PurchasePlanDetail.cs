using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// PurchasePlanDetail Entity
/// </summary>
public class PurchasePlanDetail : Entity<PurchasePlanDetailId>
{
    private readonly List<PurchaseManager> _purchaseManager = new List<PurchaseManager>();
    private readonly List<PurchasePlanMaster> _purchasePlanMaster = new List<PurchasePlanMaster>();

    private PurchasePlanDetail() { }

    public PurchasePlanDetail(PurchasePlanDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PurchasePlanDetail
    /// المعرف الفريد لـ PurchasePlanDetail
    /// </summary>
    public PurchasePlanDetailId Id { get; private set; }

    /// <summary>
    /// PlanNumber of the PurchasePlanDetail
    /// PlanNumber الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// PlanType of the PurchasePlanDetail
    /// PlanType الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? PlanType { get; private set; }

    /// <summary>
    /// PlanDistributionType of the PurchasePlanDetail
    /// PlanDistributionType الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? PlanDistributionType { get; private set; }

    /// <summary>
    /// PlanPeriodType of the PurchasePlanDetail
    /// PlanPeriodType الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? PlanPeriodType { get; private set; }

    /// <summary>
    /// RepCode of the PurchasePlanDetail
    /// RepCode الخاص بـ PurchasePlanDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// VendorCode of the PurchasePlanDetail
    /// VendorCode الخاص بـ PurchasePlanDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorGroupCode of the PurchasePlanDetail
    /// VendorGroupCode الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? VendorGroupCode { get; private set; }

    /// <summary>
    /// VendorClass of the PurchasePlanDetail
    /// VendorClass الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? VendorClass { get; private set; }

    /// <summary>
    /// CountryNumber of the PurchasePlanDetail
    /// CountryNumber الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the PurchasePlanDetail
    /// ProvinceNumber الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the PurchasePlanDetail
    /// CityNumber الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// GuarantorCode of the PurchasePlanDetail
    /// GuarantorCode الخاص بـ PurchasePlanDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ItemType of the PurchasePlanDetail
    /// ItemType الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// ItemCode of the PurchasePlanDetail
    /// ItemCode الخاص بـ PurchasePlanDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the PurchasePlanDetail
    /// ItemUnit الخاص بـ PurchasePlanDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the PurchasePlanDetail
    /// PSize الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the PurchasePlanDetail
    /// WarehouseCode الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the PurchasePlanDetail
    /// CostCenterCode الخاص بـ PurchasePlanDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// Month of the PurchasePlanDetail
    /// Month الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? Month { get; private set; }

    /// <summary>
    /// FDate of the PurchasePlanDetail
    /// FDate الخاص بـ PurchasePlanDetail
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the PurchasePlanDetail
    /// TDate الخاص بـ PurchasePlanDetail
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// ItemQuantity of the PurchasePlanDetail
    /// ItemQuantity الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// LocalAmount of the PurchasePlanDetail
    /// LocalAmount الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? LocalAmount { get; private set; }

    /// <summary>
    /// HighLimit of the PurchasePlanDetail
    /// HighLimit الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? HighLimit { get; private set; }

    /// <summary>
    /// LowLimit of the PurchasePlanDetail
    /// LowLimit الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? LowLimit { get; private set; }

    /// <summary>
    /// RecordNumber of the PurchasePlanDetail
    /// RecordNumber الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// PlanDescription of the PurchasePlanDetail
    /// PlanDescription الخاص بـ PurchasePlanDetail
    /// </summary>
    public string PlanDescription { get; private set; }

    /// <summary>
    /// ExecutionPercent of the PurchasePlanDetail
    /// ExecutionPercent الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? ExecutionPercent { get; private set; }

    /// <summary>
    /// BranchNumber of the PurchasePlanDetail
    /// BranchNumber الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PurchasePlanDetail
    /// CompanyNumberShort الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchUser of the PurchasePlanDetail
    /// BranchUser الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the PurchasePlanDetail
    /// BranchYear الخاص بـ PurchasePlanDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// ActivityNumber of the PurchasePlanDetail
    /// ActivityNumber الخاص بـ PurchasePlanDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ProjectNumber of the PurchasePlanDetail
    /// ProjectNumber الخاص بـ PurchasePlanDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<PurchaseManager> PurchaseManager => _purchaseManager;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<PurchasePlanMaster> PurchasePlanMaster => _purchasePlanMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
