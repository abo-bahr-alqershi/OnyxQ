using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCommissionCalculationDetail Entity
/// </summary>
public class SalesmanCommissionCalculationDetail : Entity<SalesmanCommissionCalculationDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<SalesmanCommissionCalculationMaster> _salesmanCommissionCalculationMaster = new List<SalesmanCommissionCalculationMaster>();

    private SalesmanCommissionCalculationDetail() { }

    public SalesmanCommissionCalculationDetail(SalesmanCommissionCalculationDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesmanCommissionCalculationDetail
    /// المعرف الفريد لـ SalesmanCommissionCalculationDetail
    /// </summary>
    public SalesmanCommissionCalculationDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the SalesmanCommissionCalculationDetail
    /// DocNo الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSeq of the SalesmanCommissionCalculationDetail
    /// DocSeq الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// RepCode of the SalesmanCommissionCalculationDetail
    /// RepCode الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ItemUnit of the SalesmanCommissionCalculationDetail
    /// ItemUnit الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the SalesmanCommissionCalculationDetail
    /// PSize الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// CommissionAmount of the SalesmanCommissionCalculationDetail
    /// CommissionAmount الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the SalesmanCommissionCalculationDetail
    /// CommissionDescriptionShort الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the SalesmanCommissionCalculationDetail
    /// CompanyNumberShort الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the SalesmanCommissionCalculationDetail
    /// BranchNumber الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the SalesmanCommissionCalculationDetail
    /// BranchYear الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the SalesmanCommissionCalculationDetail
    /// BranchUser الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CommissionPercent of the SalesmanCommissionCalculationDetail
    /// CommissionPercent الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// NetSalesAmount of the SalesmanCommissionCalculationDetail
    /// NetSalesAmount الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? NetSalesAmount { get; private set; }

    /// <summary>
    /// NetSalesQuantity of the SalesmanCommissionCalculationDetail
    /// NetSalesQuantity الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? NetSalesQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the SalesmanCommissionCalculationDetail
    /// RecordNumber الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// GuarantorCode of the SalesmanCommissionCalculationDetail
    /// GuarantorCode الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// GroupNumber of the SalesmanCommissionCalculationDetail
    /// GroupNumber الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// ColumnAmount of the SalesmanCommissionCalculationDetail
    /// ColumnAmount الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? ColumnAmount { get; private set; }

    /// <summary>
    /// ItemType of the SalesmanCommissionCalculationDetail
    /// ItemType الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? ItemType { get; private set; }

    /// <summary>
    /// CGroupCode of the SalesmanCommissionCalculationDetail
    /// CGroupCode الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CClass of the SalesmanCommissionCalculationDetail
    /// CClass الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// RegionCode of the SalesmanCommissionCalculationDetail
    /// RegionCode الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public string RegionCode { get; private set; }

    /// <summary>
    /// ColumnCommissionAmount of the SalesmanCommissionCalculationDetail
    /// ColumnCommissionAmount الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? ColumnCommissionAmount { get; private set; }

    /// <summary>
    /// CountryNumber of the SalesmanCommissionCalculationDetail
    /// CountryNumber الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the SalesmanCommissionCalculationDetail
    /// ProvinceNumber الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the SalesmanCommissionCalculationDetail
    /// CityNumber الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// BillDocumentType of the SalesmanCommissionCalculationDetail
    /// BillDocumentType الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    /// <summary>
    /// LevelNumber of the SalesmanCommissionCalculationDetail
    /// LevelNumber الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// PlanAmount of the SalesmanCommissionCalculationDetail
    /// PlanAmount الخاص بـ SalesmanCommissionCalculationDetail
    /// </summary>
    public decimal? PlanAmount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<SalesmanCommissionCalculationMaster> SalesmanCommissionCalculationMaster => _salesmanCommissionCalculationMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

