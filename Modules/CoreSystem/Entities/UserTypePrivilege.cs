using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ArchivingDocuments.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// UserTypePrivilege Entity
/// </summary>
public class UserTypePrivilege : Entity<UserTypePrivilegeId>
{
    private UserTypePrivilege() { }

    /// <summary>
    /// The unique identifier for the UserTypePrivilege
    /// المعرف الفريد لـ UserTypePrivilege
    /// </summary>
    public UserTypePrivilegeId Id { get; private set; }

    /// <summary>
    /// UserId of the UserTypePrivilege
    /// UserId الخاص بـ UserTypePrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// FormNumber of the UserTypePrivilege
    /// FormNumber الخاص بـ UserTypePrivilege
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// ObjectNameShort of the UserTypePrivilege
    /// ObjectNameShort الخاص بـ UserTypePrivilege
    /// </summary>
    public string ObjectNameShort { get; private set; }

    /// <summary>
    /// TpName of the UserTypePrivilege
    /// TpName الخاص بـ UserTypePrivilege
    /// </summary>
    public string TpName { get; private set; }

    /// <summary>
    /// PrivilegeFlag of the UserTypePrivilege
    /// PrivilegeFlag الخاص بـ UserTypePrivilege
    /// </summary>
    public decimal? PrivilegeFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to SystemType
    /// </summary>
    public SystemType SystemType { get; private set; }
    /// <summary>
    /// ManyToOne relationship to FormDetail
    /// </summary>
    public FormDetail FormDetail { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
