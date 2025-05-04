using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// UserAlertSystemPrivilege Entity
/// </summary>
public class UserAlertSystemPrivilege : Entity<UserAlertSystemPrivilegeId>
{
    private UserAlertSystemPrivilege() { }

    /// <summary>
    /// The unique identifier for the UserAlertSystemPrivilege
    /// المعرف الفريد لـ UserAlertSystemPrivilege
    /// </summary>
    public UserAlertSystemPrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the UserAlertSystemPrivilege
    /// UserId الخاص بـ UserAlertSystemPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// AlertNumber of the UserAlertSystemPrivilege
    /// AlertNumber الخاص بـ UserAlertSystemPrivilege
    /// </summary>
    public decimal? AlertNumber { get; private set; }

    /// <summary>
    /// PrivilegeFlag of the UserAlertSystemPrivilege
    /// PrivilegeFlag الخاص بـ UserAlertSystemPrivilege
    /// </summary>
    public decimal? PrivilegeFlag { get; private set; }
}
}
