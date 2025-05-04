using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// CompoundItem Entity
/// </summary>
public class CompoundItem : Entity<CompoundItemId>
{

    private CompoundItem() { }

    public CompoundItem(CompoundItemId id, string diCode)
    {
        Id = id;
        DiCode = diCode;
    }

    /// <summary>
    /// The unique identifier for the CompoundItem
    /// المعرف الفريد لـ CompoundItem
    /// </summary>
    public CompoundItemId Id { get; private set; }

    /// <summary>
    /// PSize of the CompoundItem
    /// PSize الخاص بـ CompoundItem
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// DiCode of the CompoundItem
    /// DiCode الخاص بـ CompoundItem
    /// </summary>
    public string DiCode { get; private set; }

    /// <summary>
    /// DiName of the CompoundItem
    /// DiName الخاص بـ CompoundItem
    /// </summary>
    public string DiName { get; private set; }

    /// <summary>
    /// Quantity of the CompoundItem
    /// Quantity الخاص بـ CompoundItem
    /// </summary>
    public decimal? Quantity { get; private set; }

    /// <summary>
    /// DitmUnt of the CompoundItem
    /// DitmUnt الخاص بـ CompoundItem
    /// </summary>
    public string DitmUnt { get; private set; }

    /// <summary>
    /// DpSize of the CompoundItem
    /// DpSize الخاص بـ CompoundItem
    /// </summary>
    public decimal? DpSize { get; private set; }

    /// <summary>
    /// OptionalFlag of the CompoundItem
    /// OptionalFlag الخاص بـ CompoundItem
    /// </summary>
    public decimal? OptionalFlag { get; private set; }

    /// <summary>
    /// ItemMinQuantity of the CompoundItem
    /// ItemMinQuantity الخاص بـ CompoundItem
    /// </summary>
    public decimal? ItemMinQuantity { get; private set; }

    /// <summary>
    /// ItemMaxQuantity of the CompoundItem
    /// ItemMaxQuantity الخاص بـ CompoundItem
    /// </summary>
    public decimal? ItemMaxQuantity { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemDetail ItemDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
