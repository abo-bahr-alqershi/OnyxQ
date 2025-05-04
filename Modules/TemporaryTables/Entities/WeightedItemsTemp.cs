using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// WeightedItemsTemp Entity
/// </summary>
public class WeightedItemsTemp : Entity<WeightedItemsTempId>
{
    private WeightedItemsTemp() { }

    /// <summary>
    /// The unique identifier for the WeightedItemsTemp
    /// المعرف الفريد لـ WeightedItemsTemp
    /// </summary>
    public WeightedItemsTempId Id { get; private set; }

    /// <summary>
    /// SerNumber of the WeightedItemsTemp
    /// SerNumber الخاص بـ WeightedItemsTemp
    /// </summary>
    public decimal? SerNumber { get; private set; }

    /// <summary>
    /// ItemCode of the WeightedItemsTemp
    /// ItemCode الخاص بـ WeightedItemsTemp
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the WeightedItemsTemp
    /// ItemUnit الخاص بـ WeightedItemsTemp
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the WeightedItemsTemp
    /// PSize الخاص بـ WeightedItemsTemp
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// ItemNameFull of the WeightedItemsTemp
    /// ItemNameFull الخاص بـ WeightedItemsTemp
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// Price of the WeightedItemsTemp
    /// Price الخاص بـ WeightedItemsTemp
    /// </summary>
    public decimal? Price { get; private set; }

    /// <summary>
    /// GuarantorCode of the WeightedItemsTemp
    /// GuarantorCode الخاص بـ WeightedItemsTemp
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// BranchNumber of the WeightedItemsTemp
    /// BranchNumber الخاص بـ WeightedItemsTemp
    /// </summary>
    public decimal? BranchNumber { get; private set; }
}
}
