using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemBin Entity
/// </summary>
public class ItemBin : Entity<ItemBinId>
{

    private ItemBin() { }

    public ItemBin(ItemBinId id, string itemUnit, DateTime? expireDate, string batchNumber)
    {
        Id = id;
        ItemUnit = itemUnit;
        ExpireDate = expireDate;
        BatchNumber = batchNumber;
    }

    /// <summary>
    /// The unique identifier for the ItemBin
    /// المعرف الفريد لـ ItemBin
    /// </summary>
    public ItemBinId Id { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemBin
    /// ItemUnit الخاص بـ ItemBin
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the ItemBin
    /// PSize الخاص بـ ItemBin
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ExpireDate of the ItemBin
    /// ExpireDate الخاص بـ ItemBin
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemBin
    /// BatchNumber الخاص بـ ItemBin
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ItemBin
    /// ExternalPostFlag الخاص بـ ItemBin
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// DefltFlg of the ItemBin
    /// DefltFlg الخاص بـ ItemBin
    /// </summary>
    public decimal? DefltFlg { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public BinDetail BinDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

