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

    /// <summary>
    /// The unique identifier for the TransferTypePermission
    /// المعرف الفريد لـ TransferTypePermission
    /// </summary>
    public TransferTypePermissionId Id { get; private set; }

    /// <summary>
    /// UserId of the TransferTypePermission
    /// UserId الخاص بـ TransferTypePermission
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// TransactionTypeFull of the TransferTypePermission
    /// TransactionTypeFull الخاص بـ TransferTypePermission
    /// </summary>
    public decimal? TransactionTypeFull { get; private set; }

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
    /// ManyToOne relationship to TransferType
    /// </summary>
    public TransferType TransferType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
