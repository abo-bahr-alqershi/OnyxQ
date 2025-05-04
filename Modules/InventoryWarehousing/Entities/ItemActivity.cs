using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemActivity Entity
/// </summary>
public class ItemActivity : Entity<ItemActivityId>
{
    private ItemActivity() { }

    /// <summary>
    /// The unique identifier for the ItemActivity
    /// المعرف الفريد لـ ItemActivity
    /// </summary>
    public ItemActivityId Id { get; private set; }

    /// <summary>
    /// ActivityNumber of the ItemActivity
    /// ActivityNumber الخاص بـ ItemActivity
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// ActivityNameArabic of the ItemActivity
    /// ActivityNameArabic الخاص بـ ItemActivity
    /// </summary>
    public string ActivityNameArabic { get; private set; }

    /// <summary>
    /// ActivityNameEnglish of the ItemActivity
    /// ActivityNameEnglish الخاص بـ ItemActivity
    /// </summary>
    public string ActivityNameEnglish { get; private set; }

    /// <summary>
    /// CostCenterCode of the ItemActivity
    /// CostCenterCode الخاص بـ ItemActivity
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ActivityNumber of the ItemActivity
    /// ActivityNumber الخاص بـ ItemActivity
    /// </summary>
    public string ActivityNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: ItemActivity to ItemActivityPrivilege
    /// </summary>
    public IReadOnlyCollection<ItemActivityPrivilege> ItemActivityPrivileges { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemActivity to CustomerItemActivity
    /// </summary>
    public IReadOnlyCollection<CustomerItemActivity> CustomerItemActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemActivity to SalesmanItemActivity
    /// </summary>
    public IReadOnlyCollection<SalesmanItemActivity> SalesmanItemActivities { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemActivity to GroupItemLevel
    /// </summary>
    public IReadOnlyCollection<GroupItemLevel> GroupItemLevels { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemActivity to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    /// <summary>
    /// One-to-many relationship: ItemActivity to Salesman
    /// </summary>
    public IReadOnlyCollection<Salesman> Salesmans { get; private set; }
    #endregion
}
}
