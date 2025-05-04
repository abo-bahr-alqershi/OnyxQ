using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// RequestType Entity
/// </summary>
public class RequestType : Entity<RequestTypeId>
{
    private RequestType() { }

    /// <summary>
    /// The unique identifier for the RequestType
    /// المعرف الفريد لـ RequestType
    /// </summary>
    public RequestTypeId Id { get; private set; }

    /// <summary>
    /// RequestType of the RequestType
    /// RequestType الخاص بـ RequestType
    /// </summary>
    public decimal? RequestType { get; private set; }

    /// <summary>
    /// RequestName of the RequestType
    /// RequestName الخاص بـ RequestType
    /// </summary>
    public string RequestName { get; private set; }

    /// <summary>
    /// RequestNameEnglish of the RequestType
    /// RequestNameEnglish الخاص بـ RequestType
    /// </summary>
    public string RequestNameEnglish { get; private set; }

    /// <summary>
    /// RequestSerialReference of the RequestType
    /// RequestSerialReference الخاص بـ RequestType
    /// </summary>
    public decimal? RequestSerialReference { get; private set; }

    /// <summary>
    /// OutgoingTransfer of the RequestType
    /// OutgoingTransfer الخاص بـ RequestType
    /// </summary>
    public decimal? OutgoingTransfer { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: RequestType to RequestTypePermission
    /// </summary>
    public IReadOnlyCollection<RequestTypePermission> RequestTypePermissions { get; private set; }
    /// <summary>
    /// One-to-many relationship: RequestType to User
    /// </summary>
    public IReadOnlyCollection<User> Users { get; private set; }
    #endregion
}
}
