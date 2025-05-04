using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// WarehousePermission Entity
/// </summary>
public class WarehousePermission : Entity<WarehousePermissionId>
{
    private WarehousePermission() { }

    /// <summary>
    /// The unique identifier for the WarehousePermission
    /// المعرف الفريد لـ WarehousePermission
    /// </summary>
    public WarehousePermissionId Id { get; private set; }

    /// <summary>
    /// UserId of the WarehousePermission
    /// UserId الخاص بـ WarehousePermission
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// WarehouseCode of the WarehousePermission
    /// WarehouseCode الخاص بـ WarehousePermission
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

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
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Warehouse
    /// </summary>
    public Warehouse Warehouse { get; private set; }
    #endregion
}
}
