using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FixedAssets.Entities
{
/// <summary>
/// Reevaluate Entity
/// </summary>
public class Reevaluate : Entity<ReevaluateId>
{

    private Reevaluate() { }

    public Reevaluate(ReevaluateId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the Reevaluate
    /// المعرف الفريد لـ Reevaluate
    /// </summary>
    public ReevaluateId Id { get; private set; }

    /// <summary>
    /// GuarantorCode of the Reevaluate
    /// GuarantorCode الخاص بـ Reevaluate
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ItemCode of the Reevaluate
    /// ItemCode الخاص بـ Reevaluate
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the Reevaluate
    /// ItemUnit الخاص بـ Reevaluate
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemNameFull of the Reevaluate
    /// ItemNameFull الخاص بـ Reevaluate
    /// </summary>
    public string ItemNameFull { get; private set; }

    /// <summary>
    /// Unit of the Reevaluate
    /// Unit الخاص بـ Reevaluate
    /// </summary>
    public string Unit { get; private set; }

    /// <summary>
    /// ItemCostWeightedAverageShort of the Reevaluate
    /// ItemCostWeightedAverageShort الخاص بـ Reevaluate
    /// </summary>
    public decimal? ItemCostWeightedAverageShort { get; private set; }

    /// <summary>
    /// WarehouseCode of the Reevaluate
    /// WarehouseCode الخاص بـ Reevaluate
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// WarehouseGroupCode of the Reevaluate
    /// WarehouseGroupCode الخاص بـ Reevaluate
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// KitItemRank of the Reevaluate
    /// KitItemRank الخاص بـ Reevaluate
    /// </summary>
    public decimal? KitItemRank { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
