using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemQuantityLimit Entity
/// </summary>
public class ItemQuantityLimit : Entity<ItemQuantityLimitId>
{
    private ItemQuantityLimit() { }

    /// <summary>
    /// The unique identifier for the ItemQuantityLimit
    /// المعرف الفريد لـ ItemQuantityLimit
    /// </summary>
    public ItemQuantityLimitId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemQuantityLimit
    /// ItemCode الخاص بـ ItemQuantityLimit
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemQuantityLimit
    /// ItemUnit الخاص بـ ItemQuantityLimit
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ItemQuantityLimit
    /// PSize الخاص بـ ItemQuantityLimit
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the ItemQuantityLimit
    /// WarehouseCode الخاص بـ ItemQuantityLimit
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemQuantityLimit
    /// BranchNumber الخاص بـ ItemQuantityLimit
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// ItemMinQuantityShort of the ItemQuantityLimit
    /// ItemMinQuantityShort الخاص بـ ItemQuantityLimit
    /// </summary>
    public decimal? ItemMinQuantityShort { get; private set; }

    /// <summary>
    /// ItemMaxQuantityShort of the ItemQuantityLimit
    /// ItemMaxQuantityShort الخاص بـ ItemQuantityLimit
    /// </summary>
    public decimal? ItemMaxQuantityShort { get; private set; }

    /// <summary>
    /// ItemRoll of the ItemQuantityLimit
    /// ItemRoll الخاص بـ ItemQuantityLimit
    /// </summary>
    public decimal? ItemRoll { get; private set; }

    /// <summary>
    /// AssemblyOrderQuantity of the ItemQuantityLimit
    /// AssemblyOrderQuantity الخاص بـ ItemQuantityLimit
    /// </summary>
    public decimal? AssemblyOrderQuantity { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
