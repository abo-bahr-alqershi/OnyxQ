using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// KitItem Entity
/// </summary>
public class KitItem : Entity<KitItemId>
{
    private KitItem() { }

    /// <summary>
    /// The unique identifier for the KitItem
    /// المعرف الفريد لـ KitItem
    /// </summary>
    public KitItemId Id { get; private set; }

    /// <summary>
    /// KitItemNumber of the KitItem
    /// KitItemNumber الخاص بـ KitItem
    /// </summary>
    public string KitItemNumber { get; private set; }

    /// <summary>
    /// ItemCode of the KitItem
    /// ItemCode الخاص بـ KitItem
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the KitItem
    /// ItemUnit الخاص بـ KitItem
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the KitItem
    /// PSize الخاص بـ KitItem
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemQuantity of the KitItem
    /// ItemQuantity الخاص بـ KitItem
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// PQuantity of the KitItem
    /// PQuantity الخاص بـ KitItem
    /// </summary>
    public decimal? PQuantity { get; private set; }

    /// <summary>
    /// PeriodCostFromKitItem of the KitItem
    /// PeriodCostFromKitItem الخاص بـ KitItem
    /// </summary>
    public decimal? PeriodCostFromKitItem { get; private set; }

    /// <summary>
    /// ItemMinQuantity of the KitItem
    /// ItemMinQuantity الخاص بـ KitItem
    /// </summary>
    public decimal? ItemMinQuantity { get; private set; }

    /// <summary>
    /// ItemMaxQuantity of the KitItem
    /// ItemMaxQuantity الخاص بـ KitItem
    /// </summary>
    public decimal? ItemMaxQuantity { get; private set; }

    /// <summary>
    /// CheckAvailableQuantityInRms of the KitItem
    /// CheckAvailableQuantityInRms الخاص بـ KitItem
    /// </summary>
    public decimal? CheckAvailableQuantityInRms { get; private set; }

    /// <summary>
    /// Note of the KitItem
    /// Note الخاص بـ KitItem
    /// </summary>
    public string Note { get; private set; }

    /// <summary>
    /// UseRmsSalesType of the KitItem
    /// UseRmsSalesType الخاص بـ KitItem
    /// </summary>
    public string UseRmsSalesType { get; private set; }

    /// <summary>
    /// ExceedItemQuantity of the KitItem
    /// ExceedItemQuantity الخاص بـ KitItem
    /// </summary>
    public decimal? ExceedItemQuantity { get; private set; }

    /// <summary>
    /// AllowDeleteItem of the KitItem
    /// AllowDeleteItem الخاص بـ KitItem
    /// </summary>
    public decimal? AllowDeleteItem { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemDetail
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    #endregion
}
}
