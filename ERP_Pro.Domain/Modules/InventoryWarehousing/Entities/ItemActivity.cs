using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemActivity Entity
/// </summary>
public class ItemActivity : Entity<ItemActivityId>
{

    private ItemActivity() { }

    public ItemActivity(ItemActivityId id, decimal? activityNumber)
    {
        Id = id;
        ActivityNumber = activityNumber;
    }

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

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
