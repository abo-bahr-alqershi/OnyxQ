using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemWarehouseCode Entity
/// </summary>
public class ItemWarehouseCode : Entity<ItemWarehouseCodeId>
{

    private ItemWarehouseCode() { }

    public ItemWarehouseCode(ItemWarehouseCodeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ItemWarehouseCode
    /// المعرف الفريد لـ ItemWarehouseCode
    /// </summary>
    public ItemWarehouseCodeId Id { get; private set; }

    /// <summary>
    /// PSize of the ItemWarehouseCode
    /// PSize الخاص بـ ItemWarehouseCode
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the ItemWarehouseCode
    /// WarehouseGroupCode الخاص بـ ItemWarehouseCode
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// PrimaryCost of the ItemWarehouseCode
    /// PrimaryCost الخاص بـ ItemWarehouseCode
    /// </summary>
    public decimal? PrimaryCost { get; private set; }

    /// <summary>
    /// ItemCostWeightedAverageShort of the ItemWarehouseCode
    /// ItemCostWeightedAverageShort الخاص بـ ItemWarehouseCode
    /// </summary>
    public decimal? ItemCostWeightedAverageShort { get; private set; }

    /// <summary>
    /// AvailableQuantity of the ItemWarehouseCode
    /// AvailableQuantity الخاص بـ ItemWarehouseCode
    /// </summary>
    public decimal? AvailableQuantity { get; private set; }

    /// <summary>
    /// InactiveFlag of the ItemWarehouseCode
    /// InactiveFlag الخاص بـ ItemWarehouseCode
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// MinLimitCostPercent of the ItemWarehouseCode
    /// MinLimitCostPercent الخاص بـ ItemWarehouseCode
    /// </summary>
    public decimal? MinLimitCostPercent { get; private set; }

    /// <summary>
    /// MaxLimitCostPercent of the ItemWarehouseCode
    /// MaxLimitCostPercent الخاص بـ ItemWarehouseCode
    /// </summary>
    public decimal? MaxLimitCostPercent { get; private set; }

    /// <summary>
    /// LastReevaluationSerial of the ItemWarehouseCode
    /// LastReevaluationSerial الخاص بـ ItemWarehouseCode
    /// </summary>
    public decimal? LastReevaluationSerial { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
