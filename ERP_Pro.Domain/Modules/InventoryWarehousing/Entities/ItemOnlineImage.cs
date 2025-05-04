using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemOnlineImage Entity
/// </summary>
public class ItemOnlineImage : Entity<ItemOnlineImageId>
{

    private ItemOnlineImage() { }

    public ItemOnlineImage(ItemOnlineImageId id, string itemCode, string itemUnit, decimal? recordNumber)
    {
        Id = id;
        ItemCode = itemCode;
        ItemUnit = itemUnit;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the ItemOnlineImage
    /// المعرف الفريد لـ ItemOnlineImage
    /// </summary>
    public ItemOnlineImageId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemOnlineImage
    /// ItemCode الخاص بـ ItemOnlineImage
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemOnlineImage
    /// ItemUnit الخاص بـ ItemOnlineImage
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ImageName of the ItemOnlineImage
    /// ImageName الخاص بـ ItemOnlineImage
    /// </summary>
    public string ImageName { get; private set; }

    /// <summary>
    /// OrderNumber of the ItemOnlineImage
    /// OrderNumber الخاص بـ ItemOnlineImage
    /// </summary>
    public decimal? OrderNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the ItemOnlineImage
    /// RecordNumber الخاص بـ ItemOnlineImage
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
