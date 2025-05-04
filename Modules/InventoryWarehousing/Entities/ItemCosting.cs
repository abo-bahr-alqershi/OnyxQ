using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemCosting Entity
/// </summary>
public class ItemCosting : Entity<ItemCostingId>
{
    private ItemCosting() { }

    /// <summary>
    /// The unique identifier for the ItemCosting
    /// المعرف الفريد لـ ItemCosting
    /// </summary>
    public ItemCostingId Id { get; private set; }

    /// <summary>
    /// DocDate of the ItemCosting
    /// DocDate الخاص بـ ItemCosting
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// ItemCode of the ItemCosting
    /// ItemCode الخاص بـ ItemCosting
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemCosting
    /// ItemUnit الخاص بـ ItemCosting
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ItemCosting
    /// PSize الخاص بـ ItemCosting
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the ItemCosting
    /// WarehouseCode الخاص بـ ItemCosting
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// NewCost of the ItemCosting
    /// NewCost الخاص بـ ItemCosting
    /// </summary>
    public decimal? NewCost { get; private set; }

    /// <summary>
    /// OldCost of the ItemCosting
    /// OldCost الخاص بـ ItemCosting
    /// </summary>
    public decimal? OldCost { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ItemCosting
    /// CompanyNumberShort الخاص بـ ItemCosting
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemCosting
    /// BranchNumber الخاص بـ ItemCosting
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ItemCosting
    /// BranchYear الخاص بـ ItemCosting
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ItemCosting
    /// BranchUser الخاص بـ ItemCosting
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// OneToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    #endregion
}
}
