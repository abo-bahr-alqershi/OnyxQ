using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemLevelMeasure Entity
/// </summary>
public class ItemLevelMeasure : Entity<ItemLevelMeasureId>
{

    private ItemLevelMeasure() { }

    public ItemLevelMeasure(ItemLevelMeasureId id, decimal? itemLevelNumber, decimal? flagValue, string flagCode)
    {
        Id = id;
        ItemLevelNumber = itemLevelNumber;
        FlagValue = flagValue;
        FlagCode = flagCode;
    }

    /// <summary>
    /// The unique identifier for the ItemLevelMeasure
    /// المعرف الفريد لـ ItemLevelMeasure
    /// </summary>
    public ItemLevelMeasureId Id { get; private set; }

    /// <summary>
    /// ItemLevelNumber of the ItemLevelMeasure
    /// ItemLevelNumber الخاص بـ ItemLevelMeasure
    /// </summary>
    public decimal? ItemLevelNumber { get; private set; }

    /// <summary>
    /// FlagValue of the ItemLevelMeasure
    /// FlagValue الخاص بـ ItemLevelMeasure
    /// </summary>
    public decimal? FlagValue { get; private set; }

    /// <summary>
    /// FlagCode of the ItemLevelMeasure
    /// FlagCode الخاص بـ ItemLevelMeasure
    /// </summary>
    public string FlagCode { get; private set; }

    /// <summary>
    /// CompanyType of the ItemLevelMeasure
    /// CompanyType الخاص بـ ItemLevelMeasure
    /// </summary>
    public decimal? CompanyType { get; private set; }

    /// <summary>
    /// ArgumentType of the ItemLevelMeasure
    /// ArgumentType الخاص بـ ItemLevelMeasure
    /// </summary>
    public decimal? ArgumentType { get; private set; }

    /// <summary>
    /// FromAmountPercent of the ItemLevelMeasure
    /// FromAmountPercent الخاص بـ ItemLevelMeasure
    /// </summary>
    public decimal? FromAmountPercent { get; private set; }

    /// <summary>
    /// ToAmountPercent of the ItemLevelMeasure
    /// ToAmountPercent الخاص بـ ItemLevelMeasure
    /// </summary>
    public decimal? ToAmountPercent { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

