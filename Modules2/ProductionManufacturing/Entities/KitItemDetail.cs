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
/// KitItemDetail Entity
/// </summary>
public class KitItemDetail : Entity<KitItemDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<Project> _project = new List<Project>();

    private KitItemDetail() { }

    public KitItemDetail(KitItemDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the KitItemDetail
    /// المعرف الفريد لـ KitItemDetail
    /// </summary>
    public KitItemDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the KitItemDetail
    /// DocNo الخاص بـ KitItemDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the KitItemDetail
    /// DocSer الخاص بـ KitItemDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// KitItemNumber of the KitItemDetail
    /// KitItemNumber الخاص بـ KitItemDetail
    /// </summary>
    public string KitItemNumber { get; private set; }

    /// <summary>
    /// PSize of the KitItemDetail
    /// PSize الخاص بـ KitItemDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the KitItemDetail
    /// ItemQuantity الخاص بـ KitItemDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the KitItemDetail
    /// PQuantity الخاص بـ KitItemDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// StandardQuantity of the KitItemDetail
    /// StandardQuantity الخاص بـ KitItemDetail
    /// </summary>
    public decimal? StandardQuantity { get; private set; }

    /// <summary>
    /// AvailableQuantity of the KitItemDetail
    /// AvailableQuantity الخاص بـ KitItemDetail
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the KitItemDetail
    /// WarehouseCode الخاص بـ KitItemDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the KitItemDetail
    /// CostCenterCode الخاص بـ KitItemDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ItemCostShort of the KitItemDetail
    /// ItemCostShort الخاص بـ KitItemDetail
    /// </summary>
    public decimal? ItemCostShort { get; private set; }

    /// <summary>
    /// KitQuantity of the KitItemDetail
    /// KitQuantity الخاص بـ KitItemDetail
    /// </summary>
    public decimal? KitQuantity { get; private set; }

    /// <summary>
    /// SumQuantity of the KitItemDetail
    /// SumQuantity الخاص بـ KitItemDetail
    /// </summary>
    public decimal? SumQuantity { get; private set; }

    /// <summary>
    /// PsumQuantity of the KitItemDetail
    /// PsumQuantity الخاص بـ KitItemDetail
    /// </summary>
    public decimal? PsumQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the KitItemDetail
    /// RecordNumber الخاص بـ KitItemDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSequence of the KitItemDetail
    /// DocSequence الخاص بـ KitItemDetail
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// PostCode of the KitItemDetail
    /// PostCode الخاص بـ KitItemDetail
    /// </summary>
    public string PostCode { get; private set; }

    /// <summary>
    /// ExpireDate of the KitItemDetail
    /// ExpireDate الخاص بـ KitItemDetail
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the KitItemDetail
    /// BatchNumber الخاص بـ KitItemDetail
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// RecordSequence of the KitItemDetail
    /// RecordSequence الخاص بـ KitItemDetail
    /// </summary>
    public decimal? RecordSequence { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the KitItemDetail
    /// CompanyNumberShort الخاص بـ KitItemDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the KitItemDetail
    /// BranchNumber الخاص بـ KitItemDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the KitItemDetail
    /// BranchYear الخاص بـ KitItemDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the KitItemDetail
    /// BranchUser الخاص بـ KitItemDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ItemPriceShort of the KitItemDetail
    /// ItemPriceShort الخاص بـ KitItemDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// DocSequenceM of the KitItemDetail
    /// DocSequenceM الخاص بـ KitItemDetail
    /// </summary>
    public decimal? DocSequenceM { get; private set; }

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

