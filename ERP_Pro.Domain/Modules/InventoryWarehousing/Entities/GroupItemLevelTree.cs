using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// GroupItemLevelTree Entity
/// </summary>
public class GroupItemLevelTree : Entity<GroupItemLevelTreeId>
{

    private GroupItemLevelTree() { }

    public GroupItemLevelTree(GroupItemLevelTreeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GroupItemLevelTree
    /// المعرف الفريد لـ GroupItemLevelTree
    /// </summary>
    public GroupItemLevelTreeId Id { get; private set; }

    /// <summary>
    /// GroupCode of the GroupItemLevelTree
    /// GroupCode الخاص بـ GroupItemLevelTree
    /// </summary>
    public string GroupCode { get; private set; }

    /// <summary>
    /// GroupCodeTree of the GroupItemLevelTree
    /// GroupCodeTree الخاص بـ GroupItemLevelTree
    /// </summary>
    public string GroupCodeTree { get; private set; }

    /// <summary>
    /// GroupNameFull of the GroupItemLevelTree
    /// GroupNameFull الخاص بـ GroupItemLevelTree
    /// </summary>
    public string GroupNameFull { get; private set; }

    /// <summary>
    /// GroupLevel of the GroupItemLevelTree
    /// GroupLevel الخاص بـ GroupItemLevelTree
    /// </summary>
    public decimal? GroupLevel { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
