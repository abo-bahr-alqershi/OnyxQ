using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// ItemWeightedAverageTemp Entity
/// </summary>
public class ItemWeightedAverageTemp : Entity<ItemWeightedAverageTempId>
{
    private ItemWeightedAverageTemp() { }

    /// <summary>
    /// The unique identifier for the ItemWeightedAverageTemp
    /// المعرف الفريد لـ ItemWeightedAverageTemp
    /// </summary>
    public ItemWeightedAverageTempId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemWeightedAverageTemp
    /// ItemCode الخاص بـ ItemWeightedAverageTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemCostWeightedAverageShort of the ItemWeightedAverageTemp
    /// ItemCostWeightedAverageShort الخاص بـ ItemWeightedAverageTemp
    /// </summary>
    public decimal? ItemCostWeightedAverageShort { get; private set; }

    /// <summary>
    /// WarehouseCode of the ItemWeightedAverageTemp
    /// WarehouseCode الخاص بـ ItemWeightedAverageTemp
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the ItemWeightedAverageTemp
    /// WarehouseGroupCode الخاص بـ ItemWeightedAverageTemp
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }
}
}
