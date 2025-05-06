using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// ItemActivityPrivilege Entity
/// </summary>
public class ItemActivityPrivilege : Entity<ItemActivityPrivilegeId>
{

    private ItemActivityPrivilege() { }

    public ItemActivityPrivilege(ItemActivityPrivilegeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ItemActivityPrivilege
    /// المعرف الفريد لـ ItemActivityPrivilege
    /// </summary>
    public ItemActivityPrivilegeId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemActivity ItemActivity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User User { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

