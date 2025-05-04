using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemLevel Entity
/// </summary>
public class ItemLevel : Entity<ItemLevelId>
{

    private ItemLevel() { }

    public ItemLevel(ItemLevelId id, decimal? itemLevelNumber)
    {
        Id = id;
        ItemLevelNumber = itemLevelNumber;
    }

    /// <summary>
    /// The unique identifier for the ItemLevel
    /// المعرف الفريد لـ ItemLevel
    /// </summary>
    public ItemLevelId Id { get; private set; }

    /// <summary>
    /// ItemLevelNumber of the ItemLevel
    /// ItemLevelNumber الخاص بـ ItemLevel
    /// </summary>
    public decimal? ItemLevelNumber { get; private set; }

    /// <summary>
    /// ItemLevelNameArabic of the ItemLevel
    /// ItemLevelNameArabic الخاص بـ ItemLevel
    /// </summary>
    public string ItemLevelNameArabic { get; private set; }

    /// <summary>
    /// ItemLevelNameEnglish of the ItemLevel
    /// ItemLevelNameEnglish الخاص بـ ItemLevel
    /// </summary>
    public string ItemLevelNameEnglish { get; private set; }

    /// <summary>
    /// FromPercent of the ItemLevel
    /// FromPercent الخاص بـ ItemLevel
    /// </summary>
    public decimal? FromPercent { get; private set; }

    /// <summary>
    /// LevelValue of the ItemLevel
    /// LevelValue الخاص بـ ItemLevel
    /// </summary>
    public decimal? LevelValue { get; private set; }

    /// <summary>
    /// ToPercent of the ItemLevel
    /// ToPercent الخاص بـ ItemLevel
    /// </summary>
    public decimal? ToPercent { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
