using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// AlternativeGroup Entity
/// </summary>
public class AlternativeGroup : Entity<AlternativeGroupId>
{
    private AlternativeGroup() { }

    /// <summary>
    /// The unique identifier for the AlternativeGroup
    /// المعرف الفريد لـ AlternativeGroup
    /// </summary>
    public AlternativeGroupId Id { get; private set; }

    /// <summary>
    /// GroupNumber of the AlternativeGroup
    /// GroupNumber الخاص بـ AlternativeGroup
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// GroupNameArabic of the AlternativeGroup
    /// GroupNameArabic الخاص بـ AlternativeGroup
    /// </summary>
    public string GroupNameArabic { get; private set; }

    /// <summary>
    /// GroupNameEnglish of the AlternativeGroup
    /// GroupNameEnglish الخاص بـ AlternativeGroup
    /// </summary>
    public string GroupNameEnglish { get; private set; }

    /// <summary>
    /// DfltOrdQty of the AlternativeGroup
    /// DfltOrdQty الخاص بـ AlternativeGroup
    /// </summary>
    public decimal? DfltOrdQty { get; private set; }

    /// <summary>
    /// RollLimitQuantity of the AlternativeGroup
    /// RollLimitQuantity الخاص بـ AlternativeGroup
    /// </summary>
    public decimal? RollLimitQuantity { get; private set; }

    /// <summary>
    /// MaxLimitQuantity of the AlternativeGroup
    /// MaxLimitQuantity الخاص بـ AlternativeGroup
    /// </summary>
    public decimal? MaxLimitQuantity { get; private set; }

    /// <summary>
    /// MinLimitQuantity of the AlternativeGroup
    /// MinLimitQuantity الخاص بـ AlternativeGroup
    /// </summary>
    public decimal? MinLimitQuantity { get; private set; }

    /// <summary>
    /// SynchronizeToWebFlag of the AlternativeGroup
    /// SynchronizeToWebFlag الخاص بـ AlternativeGroup
    /// </summary>
    public decimal? SynchronizeToWebFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: AlternativeGroup to ItemMaster
    /// </summary>
    public IReadOnlyCollection<ItemMaster> ItemMasters { get; private set; }
    #endregion
}
}
