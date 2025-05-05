using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemPrice Entity
/// </summary>
public class ItemPrice : Entity<ItemPriceId>
{

    private ItemPrice() { }

    public ItemPrice(ItemPriceId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ItemPrice
    /// المعرف الفريد لـ ItemPrice
    /// </summary>
    public ItemPriceId Id { get; private set; }

    /// <summary>
    /// PSize of the ItemPrice
    /// PSize الخاص بـ ItemPrice
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// FromQuantity of the ItemPrice
    /// FromQuantity الخاص بـ ItemPrice
    /// </summary>
    public decimal? FromQuantity { get; private set; }

    /// <summary>
    /// ToQuantity of the ItemPrice
    /// ToQuantity الخاص بـ ItemPrice
    /// </summary>
    public decimal? ToQuantity { get; private set; }

    /// <summary>
    /// ItemPriceShort of the ItemPrice
    /// ItemPriceShort الخاص بـ ItemPrice
    /// </summary>
    public decimal? ItemPriceShort { get; private set; }

    /// <summary>
    /// ImportExcelFlag of the ItemPrice
    /// ImportExcelFlag الخاص بـ ItemPrice
    /// </summary>
    public decimal? ImportExcelFlag { get; private set; }

    /// <summary>
    /// BranchNumber of the ItemPrice
    /// BranchNumber الخاص بـ ItemPrice
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DctrPrice of the ItemPrice
    /// DctrPrice الخاص بـ ItemPrice
    /// </summary>
    public decimal? DctrPrice { get; private set; }

    /// <summary>
    /// MinItemPrice of the ItemPrice
    /// MinItemPrice الخاص بـ ItemPrice
    /// </summary>
    public decimal? MinItemPrice { get; private set; }

    /// <summary>
    /// MaxItemPrice of the ItemPrice
    /// MaxItemPrice الخاص بـ ItemPrice
    /// </summary>
    public decimal? MaxItemPrice { get; private set; }

    /// <summary>
    /// ExpireDate of the ItemPrice
    /// ExpireDate الخاص بـ ItemPrice
    /// </summary>
    public DateTime? ExpireDate { get; private set; }

    /// <summary>
    /// BatchNumber of the ItemPrice
    /// BatchNumber الخاص بـ ItemPrice
    /// </summary>
    public string BatchNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public PricingLevel PricingLevel { get; private set; }
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

