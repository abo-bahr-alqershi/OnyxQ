using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.PurchasingVendors.Entities;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// RequestTypePermission Entity
/// </summary>
public class RequestTypePermission : Entity<RequestTypePermissionId>
{

    private RequestTypePermission() { }

    public RequestTypePermission(RequestTypePermissionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the RequestTypePermission
    /// المعرف الفريد لـ RequestTypePermission
    /// </summary>
    public RequestTypePermissionId Id { get; private set; }

    /// <summary>
    /// AdditionalFlag of the RequestTypePermission
    /// AdditionalFlag الخاص بـ RequestTypePermission
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    /// <summary>
    /// ViewFlag of the RequestTypePermission
    /// ViewFlag الخاص بـ RequestTypePermission
    /// </summary>
    public decimal? ViewFlag { get; private set; }

    /// <summary>
    /// FillFlag of the RequestTypePermission
    /// FillFlag الخاص بـ RequestTypePermission
    /// </summary>
    public decimal? FillFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public RequestType RequestType { get; private set; }
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

