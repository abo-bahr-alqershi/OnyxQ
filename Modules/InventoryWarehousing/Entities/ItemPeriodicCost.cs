using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemPeriodicCost Entity
/// </summary>
public class ItemPeriodicCost : Entity<ItemPeriodicCostId>
{
    private ItemPeriodicCost() { }

    /// <summary>
    /// The unique identifier for the ItemPeriodicCost
    /// المعرف الفريد لـ ItemPeriodicCost
    /// </summary>
    public ItemPeriodicCostId Id { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the ItemPeriodicCost
    /// PeriodNumberShort الخاص بـ ItemPeriodicCost
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// ItemCode of the ItemPeriodicCost
    /// ItemCode الخاص بـ ItemPeriodicCost
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemPeriodicCost
    /// ItemUnit الخاص بـ ItemPeriodicCost
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ItemPeriodicCost
    /// PSize الخاص بـ ItemPeriodicCost
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the ItemPeriodicCost
    /// WarehouseCode الخاص بـ ItemPeriodicCost
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// StockRate of the ItemPeriodicCost
    /// StockRate الخاص بـ ItemPeriodicCost
    /// </summary>
    public decimal? StockRate { get; private set; }

    /// <summary>
    /// ItemCost of the ItemPeriodicCost
    /// ItemCost الخاص بـ ItemPeriodicCost
    /// </summary>
    public decimal? ItemCost { get; private set; }

    /// <summary>
    /// ItemLastIncomePrice of the ItemPeriodicCost
    /// ItemLastIncomePrice الخاص بـ ItemPeriodicCost
    /// </summary>
    public decimal? ItemLastIncomePrice { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ItemPeriodicCost
    /// CompanyNumberShort الخاص بـ ItemPeriodicCost
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemPeriodicCost
    /// BranchNumber الخاص بـ ItemPeriodicCost
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ItemPeriodicCost
    /// BranchYear الخاص بـ ItemPeriodicCost
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ItemPeriodicCost
    /// BranchUser الخاص بـ ItemPeriodicCost
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
