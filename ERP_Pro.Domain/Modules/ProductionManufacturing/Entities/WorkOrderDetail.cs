using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// WorkOrderDetail Entity
/// </summary>
public class WorkOrderDetail : Entity<WorkOrderDetailId>
{
    private readonly List<ItemDetail> _itemDetail = new List<ItemDetail>();
    private readonly List<WorkOrderMaster> _workOrderMaster = new List<WorkOrderMaster>();

    private WorkOrderDetail() { }

    public WorkOrderDetail(WorkOrderDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the WorkOrderDetail
    /// المعرف الفريد لـ WorkOrderDetail
    /// </summary>
    public WorkOrderDetailId Id { get; private set; }

    /// <summary>
    /// WorkOrderNumber of the WorkOrderDetail
    /// WorkOrderNumber الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// WorkOrderTypeNumber of the WorkOrderDetail
    /// WorkOrderTypeNumber الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? WorkOrderTypeNumber { get; private set; }

    /// <summary>
    /// WorkOrderMoveDate of the WorkOrderDetail
    /// WorkOrderMoveDate الخاص بـ WorkOrderDetail
    /// </summary>
    public DateTime? WorkOrderMoveDate { get; private set; }

    /// <summary>
    /// ItemQuantity of the WorkOrderDetail
    /// ItemQuantity الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the WorkOrderDetail
    /// ItemPriceShort الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// PSize of the WorkOrderDetail
    /// PSize الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// PQuantity of the WorkOrderDetail
    /// PQuantity الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// WarehouseCode of the WorkOrderDetail
    /// WarehouseCode الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ItemDescription of the WorkOrderDetail
    /// ItemDescription الخاص بـ WorkOrderDetail
    /// </summary>
    public string ItemDescription { get; private set; }

    /// <summary>
    /// FreeQuantity of the WorkOrderDetail
    /// FreeQuantity الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? FreeQuantity { get; private set; }

    /// <summary>
    /// RecordNumber of the WorkOrderDetail
    /// RecordNumber الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// Barcode of the WorkOrderDetail
    /// Barcode الخاص بـ WorkOrderDetail
    /// </summary>
    public string Barcode { get; private set; }

    /// <summary>
    /// WeightedUnit of the WorkOrderDetail
    /// WeightedUnit الخاص بـ WorkOrderDetail
    /// </summary>
    public string WeightedUnit { get; private set; }

    /// <summary>
    /// WeightedQuantity of the WorkOrderDetail
    /// WeightedQuantity الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? WeightedQuantity { get; private set; }

    /// <summary>
    /// ItemLength of the WorkOrderDetail
    /// ItemLength الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? ItemLength { get; private set; }

    /// <summary>
    /// ItemWidth of the WorkOrderDetail
    /// ItemWidth الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? ItemWidth { get; private set; }

    /// <summary>
    /// ItemHeightShort of the WorkOrderDetail
    /// ItemHeightShort الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? ItemHeightShort { get; private set; }

    /// <summary>
    /// ItemNumberShort of the WorkOrderDetail
    /// ItemNumberShort الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? ItemNumberShort { get; private set; }

    /// <summary>
    /// ArgumentNumber of the WorkOrderDetail
    /// ArgumentNumber الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? ArgumentNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the WorkOrderDetail
    /// CompanyNumberShort الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the WorkOrderDetail
    /// BranchNumber الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the WorkOrderDetail
    /// BranchYear الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the WorkOrderDetail
    /// BranchUser الخاص بـ WorkOrderDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemDetail> ItemDetail => _itemDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<WorkOrderMaster> WorkOrderMaster => _workOrderMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
