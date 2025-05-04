using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// PrivilegeInventoryType Entity
/// </summary>
public class PrivilegeInventoryType : Entity<PrivilegeInventoryTypeId>
{

    private PrivilegeInventoryType() { }

    public PrivilegeInventoryType(PrivilegeInventoryTypeId id, decimal? userId)
    {
        Id = id;
        UserId = userId;
    }

    /// <summary>
    /// The unique identifier for the PrivilegeInventoryType
    /// المعرف الفريد لـ PrivilegeInventoryType
    /// </summary>
    public PrivilegeInventoryTypeId Id { get; private set; }

    /// <summary>
    /// UserId of the PrivilegeInventoryType
    /// UserId الخاص بـ PrivilegeInventoryType
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// AdditionalFlag of the PrivilegeInventoryType
    /// AdditionalFlag الخاص بـ PrivilegeInventoryType
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the PrivilegeInventoryType
    /// ViewFlag الخاص بـ PrivilegeInventoryType
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public InventoryType InventoryType { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
