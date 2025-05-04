using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GroupItemLevel Entity
/// </summary>
public class GroupItemLevel : Entity<GroupItemLevelId>
{
    private GroupItemLevel() { }

    /// <summary>
    /// The unique identifier for the GroupItemLevel
    /// المعرف الفريد لـ GroupItemLevel
    /// </summary>
    public GroupItemLevelId Id { get; private set; }

    /// <summary>
    /// GroupCode of the GroupItemLevel
    /// GroupCode الخاص بـ GroupItemLevel
    /// </summary>
    public string GroupCode { get; private set; }

    /// <summary>
    /// GroupLastNameFull of the GroupItemLevel
    /// GroupLastNameFull الخاص بـ GroupItemLevel
    /// </summary>
    public string GroupLastNameFull { get; private set; }

    /// <summary>
    /// GroupFirstNameFull of the GroupItemLevel
    /// GroupFirstNameFull الخاص بـ GroupItemLevel
    /// </summary>
    public string GroupFirstNameFull { get; private set; }

    /// <summary>
    /// GroupCodeParent of the GroupItemLevel
    /// GroupCodeParent الخاص بـ GroupItemLevel
    /// </summary>
    public string GroupCodeParent { get; private set; }

    /// <summary>
    /// AffectedByTransactionFlag of the GroupItemLevel
    /// AffectedByTransactionFlag الخاص بـ GroupItemLevel
    /// </summary>
    public decimal? AffectedByTransactionFlag { get; private set; }

    /// <summary>
    /// GuarantorCode of the GroupItemLevel
    /// GuarantorCode الخاص بـ GroupItemLevel
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// ActivityNumber of the GroupItemLevel
    /// ActivityNumber الخاص بـ GroupItemLevel
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// DfltPrcPrcntFromPrimCost of the GroupItemLevel
    /// DfltPrcPrcntFromPrimCost الخاص بـ GroupItemLevel
    /// </summary>
    public decimal? DfltPrcPrcntFromPrimCost { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemActivity
    /// </summary>
    public ItemActivity ItemActivity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to GroupDetail
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    /// <summary>
    /// One-to-many relationship: GroupItemLevel to ItemMaster
    /// </summary>
    public IReadOnlyCollection<ItemMaster> ItemMasters { get; private set; }
    #endregion
}
}
