using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.FixedAssets.Entities
{
/// <summary>
/// DateOptionPrivilege Entity
/// </summary>
public class DateOptionPrivilege : Entity<DateOptionPrivilegeId>
{
    private DateOptionPrivilege() { }

    /// <summary>
    /// The unique identifier for the DateOptionPrivilege
    /// المعرف الفريد لـ DateOptionPrivilege
    /// </summary>
    public DateOptionPrivilegeId Id { get; private set; }

    /// <summary>
    /// OptionNumber of the DateOptionPrivilege
    /// OptionNumber الخاص بـ DateOptionPrivilege
    /// </summary>
    public decimal? OptionNumber { get; private set; }

    /// <summary>
    /// UserId of the DateOptionPrivilege
    /// UserId الخاص بـ DateOptionPrivilege
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// OptionFlag of the DateOptionPrivilege
    /// OptionFlag الخاص بـ DateOptionPrivilege
    /// </summary>
    public decimal? OptionFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to DateOption
    /// </summary>
    public DateOption DateOption { get; private set; }
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
