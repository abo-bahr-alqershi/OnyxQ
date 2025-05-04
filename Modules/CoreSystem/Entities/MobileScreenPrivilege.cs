using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// MobileScreenPrivilege Entity
/// </summary>
public class MobileScreenPrivilege : Entity<MobileScreenPrivilegeId>
{
    private MobileScreenPrivilege() { }

    /// <summary>
    /// The unique identifier for the MobileScreenPrivilege
    /// المعرف الفريد لـ MobileScreenPrivilege
    /// </summary>
    public MobileScreenPrivilegeId Id { get; private set; }

    /// <summary>
    /// ScreenNumber of the MobileScreenPrivilege
    /// ScreenNumber الخاص بـ MobileScreenPrivilege
    /// </summary>
    public decimal? ScreenNumber { get; private set; }

    /// <summary>
    /// UserId of the MobileScreenPrivilege
    /// UserId الخاص بـ MobileScreenPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// PrivilegeFlag of the MobileScreenPrivilege
    /// PrivilegeFlag الخاص بـ MobileScreenPrivilege
    /// </summary>
    public decimal? PrivilegeFlag { get; private set; }

    /// <summary>
    /// AdditionalFlag of the MobileScreenPrivilege
    /// AdditionalFlag الخاص بـ MobileScreenPrivilege
    /// </summary>
    public decimal? AdditionalFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to MobileScreen
    /// </summary>
    public MobileScreen MobileScreen { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
