using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GroupItemLevel Entity
/// </summary>
public class GroupItemLevel : Entity<GroupItemLevelId>
{

    private GroupItemLevel() { }

    public GroupItemLevel(GroupItemLevelId id, string groupCode)
    {
        Id = id;
        GroupCode = groupCode;
    }

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
    /// DfltPrcPrcntFromPrimCost of the GroupItemLevel
    /// DfltPrcPrcntFromPrimCost الخاص بـ GroupItemLevel
    /// </summary>
    public decimal? DfltPrcPrcntFromPrimCost { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemActivity ItemActivity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GroupDetail GroupDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

