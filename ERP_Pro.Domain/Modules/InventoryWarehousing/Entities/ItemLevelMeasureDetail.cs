using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemLevelMeasureDetail Entity
/// </summary>
public class ItemLevelMeasureDetail : Entity<ItemLevelMeasureDetailId>
{

    private ItemLevelMeasureDetail() { }

    public ItemLevelMeasureDetail(ItemLevelMeasureDetailId id, decimal? flagValue, decimal? docSer)
    {
        Id = id;
        FlagValue = flagValue;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the ItemLevelMeasureDetail
    /// المعرف الفريد لـ ItemLevelMeasureDetail
    /// </summary>
    public ItemLevelMeasureDetailId Id { get; private set; }

    /// <summary>
    /// FlagValue of the ItemLevelMeasureDetail
    /// FlagValue الخاص بـ ItemLevelMeasureDetail
    /// </summary>
    public decimal? FlagValue { get; private set; }

    /// <summary>
    /// DocNo of the ItemLevelMeasureDetail
    /// DocNo الخاص بـ ItemLevelMeasureDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the ItemLevelMeasureDetail
    /// DocSer الخاص بـ ItemLevelMeasureDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// UsedFlag of the ItemLevelMeasureDetail
    /// UsedFlag الخاص بـ ItemLevelMeasureDetail
    /// </summary>
    public decimal? UsedFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

