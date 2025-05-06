using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.ProductionManufacturing.ValueObjects;
namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// DisassembleKitItemsDetail Entity
/// </summary>
public class DisassembleKitItemsDetail : Entity<DisassembleKitItemsDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<Project> _project = new List<Project>();

    private DisassembleKitItemsDetail() { }

    public DisassembleKitItemsDetail(DisassembleKitItemsDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the DisassembleKitItemsDetail
    /// المعرف الفريد لـ DisassembleKitItemsDetail
    /// </summary>
    public DisassembleKitItemsDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the DisassembleKitItemsDetail
    /// DocNo الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the DisassembleKitItemsDetail
    /// DocSer الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// AssetDocumentNumber of the DisassembleKitItemsDetail
    /// AssetDocumentNumber الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? AssetDocumentNumber { get; private set; }

    /// <summary>
    /// AssetDocumentSerial of the DisassembleKitItemsDetail
    /// AssetDocumentSerial الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? AssetDocumentSerial { get; private set; }

    /// <summary>
    /// KitItemNumber of the DisassembleKitItemsDetail
    /// KitItemNumber الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public string KitItemNumber { get; private set; }

    /// <summary>
    /// PSize of the DisassembleKitItemsDetail
    /// PSize الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the DisassembleKitItemsDetail
    /// ItemQuantity الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the DisassembleKitItemsDetail
    /// PQuantity الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// StandardQuantity of the DisassembleKitItemsDetail
    /// StandardQuantity الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? StandardQuantity { get; private set; }

    /// <summary>
    /// AvailableQuantity of the DisassembleKitItemsDetail
    /// AvailableQuantity الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the DisassembleKitItemsDetail
    /// WarehouseCode الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the DisassembleKitItemsDetail
    /// CostCenterCode الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ItemCostShort of the DisassembleKitItemsDetail
    /// ItemCostShort الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? ItemCostShort { get; private set; }

    /// <summary>
    /// KitQuantity of the DisassembleKitItemsDetail
    /// KitQuantity الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? KitQuantity { get; private set; }

    /// <summary>
    /// SumQuantity of the DisassembleKitItemsDetail
    /// SumQuantity الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? SumQuantity { get; private set; }

    /// <summary>
    /// PsumQuantity of the DisassembleKitItemsDetail
    /// PsumQuantity الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? PsumQuantity { get; private set; }

    /// <summary>
    /// WeightedAverageBefore of the DisassembleKitItemsDetail
    /// WeightedAverageBefore الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? WeightedAverageBefore { get; private set; }

    /// <summary>
    /// WeightedAverageAfter of the DisassembleKitItemsDetail
    /// WeightedAverageAfter الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? WeightedAverageAfter { get; private set; }

    /// <summary>
    /// RecordNumber of the DisassembleKitItemsDetail
    /// RecordNumber الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the DisassembleKitItemsDetail
    /// DocSequence الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// PostCode of the DisassembleKitItemsDetail
    /// PostCode الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// ExpireDate of the DisassembleKitItemsDetail
    /// ExpireDate الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the DisassembleKitItemsDetail
    /// BatchNumber الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the DisassembleKitItemsDetail
    /// CompanyNumberShort الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the DisassembleKitItemsDetail
    /// BranchNumber الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the DisassembleKitItemsDetail
    /// BranchYear الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the DisassembleKitItemsDetail
    /// BranchUser الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// PeriodCostFromKitItem of the DisassembleKitItemsDetail
    /// PeriodCostFromKitItem الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? PeriodCostFromKitItem { get; private set; }

    /// <summary>
    /// DocSequenceM of the DisassembleKitItemsDetail
    /// DocSequenceM الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? DocSequenceM { get; private set; }

    /// <summary>
    /// RecordSequence of the DisassembleKitItemsDetail
    /// RecordSequence الخاص بـ DisassembleKitItemsDetail
    /// </summary>
    public decimal? RecordSequence { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

