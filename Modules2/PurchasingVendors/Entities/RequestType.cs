using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// RequestType Entity
/// </summary>
public class RequestType : Entity<RequestTypeId>
{

    private RequestType() { }

    public RequestType(RequestTypeId id, decimal? requestType)
    {
        Id = id;
        RequestType = requestType;
    }

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

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

