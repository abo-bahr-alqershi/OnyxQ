using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// TransferTypePermission Entity
/// </summary>
public class TransferTypePermission : Entity<TransferTypePermissionId>
{

    private TransferTypePermission() { }

    public TransferTypePermission(TransferTypePermissionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the TransferTypePermission
    /// المعرف الفريد لـ TransferTypePermission
    /// </summary>
    public TransferTypePermissionId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the TransferTypePermission
    /// AdditionalFlag الخاص بـ TransferTypePermission
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the TransferTypePermission
    /// ViewFlag الخاص بـ TransferTypePermission
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public TransferType TransferType { get; private set; }
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
