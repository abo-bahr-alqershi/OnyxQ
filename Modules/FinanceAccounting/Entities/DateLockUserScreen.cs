using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// DateLockUserScreen Entity
/// </summary>
public class DateLockUserScreen : Entity<DateLockUserScreenId>
{
    private DateLockUserScreen() { }

    /// <summary>
    /// The unique identifier for the DateLockUserScreen
    /// المعرف الفريد لـ DateLockUserScreen
    /// </summary>
    public DateLockUserScreenId Id { get; private set; }

    /// <summary>
    /// UserId of the DateLockUserScreen
    /// UserId الخاص بـ DateLockUserScreen
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// FormNumber of the DateLockUserScreen
    /// FormNumber الخاص بـ DateLockUserScreen
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// UfdFlag of the DateLockUserScreen
    /// UfdFlag الخاص بـ DateLockUserScreen
    /// </summary>
    public DateTime? UfdFlag { get; private set; }

    /// <summary>
    /// UtdFlag of the DateLockUserScreen
    /// UtdFlag الخاص بـ DateLockUserScreen
    /// </summary>
    public DateTime? UtdFlag { get; private set; }

    /// <summary>
    /// LfdFlag of the DateLockUserScreen
    /// LfdFlag الخاص بـ DateLockUserScreen
    /// </summary>
    public DateTime? LfdFlag { get; private set; }

    /// <summary>
    /// LtdFlag of the DateLockUserScreen
    /// LtdFlag الخاص بـ DateLockUserScreen
    /// </summary>
    public DateTime? LtdFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
