using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Entities
{
/// <summary>
/// UserCopyAudit Entity
/// </summary>
public class UserCopyAudit : Entity<UserCopyAuditId>
{
    private UserCopyAudit() { }

    /// <summary>
    /// The unique identifier for the UserCopyAudit
    /// المعرف الفريد لـ UserCopyAudit
    /// </summary>
    public UserCopyAuditId Id { get; private set; }

    /// <summary>
    /// FUserId of the UserCopyAudit
    /// FUserId الخاص بـ UserCopyAudit
    /// </summary>
    public decimal? FUserId { get; private set; }

    /// <summary>
    /// TUserId of the UserCopyAudit
    /// TUserId الخاص بـ UserCopyAudit
    /// </summary>
    public decimal? TUserId { get; private set; }
}
}
