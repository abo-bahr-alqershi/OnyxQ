using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// ItemActivityPrivilege Entity
/// </summary>
public class ItemActivityPrivilege : Entity<ItemActivityPrivilegeId>
{
    private ItemActivityPrivilege() { }

    /// <summary>
    /// The unique identifier for the ItemActivityPrivilege
    /// المعرف الفريد لـ ItemActivityPrivilege
    /// </summary>
    public ItemActivityPrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the ItemActivityPrivilege
    /// UserId الخاص بـ ItemActivityPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// ActivityNumber of the ItemActivityPrivilege
    /// ActivityNumber الخاص بـ ItemActivityPrivilege
    /// </summary>
    public decimal? ActivityNumber { get; private set; }

    /// <summary>
    /// AdditionalFlag of the ItemActivityPrivilege
    /// AdditionalFlag الخاص بـ ItemActivityPrivilege
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the ItemActivityPrivilege
    /// ViewFlag الخاص بـ ItemActivityPrivilege
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ItemActivity
    /// </summary>
    public ItemActivity ItemActivity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
