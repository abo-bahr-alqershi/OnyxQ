using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemPriceHistory Entity
/// </summary>
public class ItemPriceHistory : Entity<ItemPriceHistoryId>
{
    private ItemPriceHistory() { }

    /// <summary>
    /// The unique identifier for the ItemPriceHistory
    /// المعرف الفريد لـ ItemPriceHistory
    /// </summary>
    public ItemPriceHistoryId Id { get; private set; }

    /// <summary>
    /// AuditNumber of the ItemPriceHistory
    /// AuditNumber الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? AuditNumber { get; private set; }

    /// <summary>
    /// AuditType of the ItemPriceHistory
    /// AuditType الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? AuditType { get; private set; }

    /// <summary>
    /// LevelNumber of the ItemPriceHistory
    /// LevelNumber الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// ItemCode of the ItemPriceHistory
    /// ItemCode الخاص بـ ItemPriceHistory
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemPriceHistory
    /// ItemUnit الخاص بـ ItemPriceHistory
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ItemPriceHistory
    /// PSize الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// WarehouseCode of the ItemPriceHistory
    /// WarehouseCode الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// FromQuantity of the ItemPriceHistory
    /// FromQuantity الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? FromQuantity { get; private set; }

    /// <summary>
    /// ToQuantity of the ItemPriceHistory
    /// ToQuantity الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? ToQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the ItemPriceHistory
    /// ItemPriceShort الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// PreviousItemPrice of the ItemPriceHistory
    /// PreviousItemPrice الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? PreviousItemPrice { get; private set; }

    /// <summary>
    /// AuditUserId of the ItemPriceHistory
    /// AuditUserId الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? AuditUserId { get; private set; }

    /// <summary>
    /// AuditDate of the ItemPriceHistory
    /// AuditDate الخاص بـ ItemPriceHistory
    /// </summary>
    public DateTime? AuditDate { get; private set; }

    /// <summary>
    /// DocNo of the ItemPriceHistory
    /// DocNo الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocDate of the ItemPriceHistory
    /// DocDate الخاص بـ ItemPriceHistory
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemPriceHistory
    /// BranchNumber الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the ItemPriceHistory
    /// ExpireDate الخاص بـ ItemPriceHistory
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemPriceHistory
    /// BatchNumber الخاص بـ ItemPriceHistory
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// MinItemPrice of the ItemPriceHistory
    /// MinItemPrice الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? MinItemPrice { get; private set; }

    /// <summary>
    /// MaxItemPrice of the ItemPriceHistory
    /// MaxItemPrice الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? MaxItemPrice { get; private set; }

    /// <summary>
    /// PreviousMaxItemPrice of the ItemPriceHistory
    /// PreviousMaxItemPrice الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? PreviousMaxItemPrice { get; private set; }

    /// <summary>
    /// PreviousMinItemPrice of the ItemPriceHistory
    /// PreviousMinItemPrice الخاص بـ ItemPriceHistory
    /// </summary>
    public decimal? PreviousMinItemPrice { get; private set; }
}
}
