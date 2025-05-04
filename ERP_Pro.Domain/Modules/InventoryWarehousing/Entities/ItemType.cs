using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemType Entity
/// </summary>
public class ItemType : Entity<ItemTypeId>
{

    private ItemType() { }

    public ItemType(ItemTypeId id, decimal? typeOfItem)
    {
        Id = id;
        TypeOfItem = typeOfItem;
    }

    /// <summary>
    /// The unique identifier for the ItemType
    /// المعرف الفريد لـ ItemType
    /// </summary>
    public ItemTypeId Id { get; private set; }

    /// <summary>
    /// TypeOfItem of the ItemType
    /// TypeOfItem الخاص بـ ItemType
    /// </summary>
    public decimal? TypeOfItem { get; private set; }

    /// <summary>
    /// ItemTypeNameArabic of the ItemType
    /// ItemTypeNameArabic الخاص بـ ItemType
    /// </summary>
    public string ItemTypeNameArabic { get; private set; }

    /// <summary>
    /// ItemTypeNameEnglish of the ItemType
    /// ItemTypeNameEnglish الخاص بـ ItemType
    /// </summary>
    public string ItemTypeNameEnglish { get; private set; }

    /// <summary>
    /// ItemTypeCode of the ItemType
    /// ItemTypeCode الخاص بـ ItemType
    /// </summary>
    public string ItemTypeCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
