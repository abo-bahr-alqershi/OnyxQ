using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// WarehousePermission Entity
/// </summary>
public class WarehousePermission : Entity<WarehousePermissionId>
{

    private WarehousePermission() { }

    public WarehousePermission(WarehousePermissionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the WarehousePermission
    /// المعرف الفريد لـ WarehousePermission
    /// </summary>
    public WarehousePermissionId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the WarehousePermission
    /// AdditionalFlag الخاص بـ WarehousePermission
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the WarehousePermission
    /// ViewFlag الخاص بـ WarehousePermission
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    /// <summary>
    /// TransferWarehouseCodeFlag of the WarehousePermission
    /// TransferWarehouseCodeFlag الخاص بـ WarehousePermission
    /// </summary>
    public decimal? TransferWarehouseCodeFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

