using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;
namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// ShowDocumentPrivilege Entity
/// </summary>
public class ShowDocumentPrivilege : Entity<ShowDocumentPrivilegeId>
{

    private ShowDocumentPrivilege() { }

    public ShowDocumentPrivilege(ShowDocumentPrivilegeId id, decimal? userId, decimal? tUserId)
    {
        Id = id;
        UserId = userId;
        TUserId = tUserId;
    }

    /// <summary>
    /// The unique identifier for the ShowDocumentPrivilege
    /// المعرف الفريد لـ ShowDocumentPrivilege
    /// </summary>
    public ShowDocumentPrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the ShowDocumentPrivilege
    /// UserId الخاص بـ ShowDocumentPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// TUserId of the ShowDocumentPrivilege
    /// TUserId الخاص بـ ShowDocumentPrivilege
    /// </summary>
    public decimal? TUserId { get; private set; }

    /// <summary>
    /// PrivateFlag of the ShowDocumentPrivilege
    /// PrivateFlag الخاص بـ ShowDocumentPrivilege
    /// </summary>
    public decimal? PrivateFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

