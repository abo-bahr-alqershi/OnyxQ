using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemOnline Entity
/// </summary>
public class ItemOnline : Entity<ItemOnlineId>
{
    private ItemOnline() { }

    /// <summary>
    /// The unique identifier for the ItemOnline
    /// المعرف الفريد لـ ItemOnline
    /// </summary>
    public ItemOnlineId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemOnline
    /// ItemCode الخاص بـ ItemOnline
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemOnline
    /// ItemUnit الخاص بـ ItemOnline
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemPriceShort of the ItemOnline
    /// ItemPriceShort الخاص بـ ItemOnline
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// ItemPricePrevious of the ItemOnline
    /// ItemPricePrevious الخاص بـ ItemOnline
    /// </summary>
    public decimal? ItemPricePrevious { get; private set; }

    /// <summary>
    /// DisPer of the ItemOnline
    /// DisPer الخاص بـ ItemOnline
    /// </summary>
    public decimal? DisPer { get; private set; }

    /// <summary>
    /// PSize of the ItemOnline
    /// PSize الخاص بـ ItemOnline
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// OrderNumber of the ItemOnline
    /// OrderNumber الخاص بـ ItemOnline
    /// </summary>
    public decimal? OrderNumber { get; private set; }

    /// <summary>
    /// ExpireDate of the ItemOnline
    /// ExpireDate الخاص بـ ItemOnline
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemOnline
    /// BatchNumber الخاص بـ ItemOnline
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// ShowSystemType of the ItemOnline
    /// ShowSystemType الخاص بـ ItemOnline
    /// </summary>
    public decimal? ShowSystemType { get; private set; }
}
}
