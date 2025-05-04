using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemBin Entity
/// </summary>
public class ItemBin : Entity<ItemBinId>
{
    private ItemBin() { }

    /// <summary>
    /// The unique identifier for the ItemBin
    /// المعرف الفريد لـ ItemBin
    /// </summary>
    public ItemBinId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemBin
    /// ItemCode الخاص بـ ItemBin
    /// </summary>
    public string ItemCode { get; private set; }

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
    /// WarehouseCode of the ItemBin
    /// WarehouseCode الخاص بـ ItemBin
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// BankCode of the ItemBin
    /// BankCode الخاص بـ ItemBin
    /// </summary>
    public string BankCode { get; private set; }

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
    /// ManyToOne relationship to ItemMaster
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to BinDetail
    /// </summary>
    public BinDetail BinDetail { get; private set; }
    #endregion
}
}
