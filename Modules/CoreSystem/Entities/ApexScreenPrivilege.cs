using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ApexScreenPrivilege Entity
/// </summary>
public class ApexScreenPrivilege : Entity<ApexScreenPrivilegeId>
{
    private ApexScreenPrivilege() { }

    /// <summary>
    /// The unique identifier for the ApexScreenPrivilege
    /// المعرف الفريد لـ ApexScreenPrivilege
    /// </summary>
    public ApexScreenPrivilegeId Id { get; private set; }

    /// <summary>
    /// ScreenNumber of the ApexScreenPrivilege
    /// ScreenNumber الخاص بـ ApexScreenPrivilege
    /// </summary>
    public decimal? ScreenNumber { get; private set; }

    /// <summary>
    /// UserId of the ApexScreenPrivilege
    /// UserId الخاص بـ ApexScreenPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// IncomeFlag of the ApexScreenPrivilege
    /// IncomeFlag الخاص بـ ApexScreenPrivilege
    /// </summary>
    public decimal? IncomeFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ApexScreen
    /// </summary>
    public ApexScreen ApexScreen { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
