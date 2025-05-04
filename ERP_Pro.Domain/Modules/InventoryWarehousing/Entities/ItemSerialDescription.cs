using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemSerialDescription Entity
/// </summary>
public class ItemSerialDescription : Entity<ItemSerialDescriptionId>
{

    private ItemSerialDescription() { }

    public ItemSerialDescription(ItemSerialDescriptionId id, decimal? descNo)
    {
        Id = id;
        DescNo = descNo;
    }

    /// <summary>
    /// The unique identifier for the ItemSerialDescription
    /// المعرف الفريد لـ ItemSerialDescription
    /// </summary>
    public ItemSerialDescriptionId Id { get; private set; }

    /// <summary>
    /// DescNo of the ItemSerialDescription
    /// DescNo الخاص بـ ItemSerialDescription
    /// </summary>
    public decimal? DescNo { get; private set; }

    /// <summary>
    /// DescAName of the ItemSerialDescription
    /// DescAName الخاص بـ ItemSerialDescription
    /// </summary>
    public string DescAName { get; private set; }

    /// <summary>
    /// DescEName of the ItemSerialDescription
    /// DescEName الخاص بـ ItemSerialDescription
    /// </summary>
    public string DescEName { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
