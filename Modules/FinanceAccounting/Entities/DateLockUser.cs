using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// DateLockUser Entity
/// </summary>
public class DateLockUser : Entity<DateLockUserId>
{
    private DateLockUser() { }

    /// <summary>
    /// The unique identifier for the DateLockUser
    /// المعرف الفريد لـ DateLockUser
    /// </summary>
    public DateLockUserId Id { get; private set; }

    /// <summary>
    /// UserId of the DateLockUser
    /// UserId الخاص بـ DateLockUser
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// UfdFlag of the DateLockUser
    /// UfdFlag الخاص بـ DateLockUser
    /// </summary>
    public DateTime? UfdFlag { get; private set; }

    /// <summary>
    /// UtdFlag of the DateLockUser
    /// UtdFlag الخاص بـ DateLockUser
    /// </summary>
    public DateTime? UtdFlag { get; private set; }

    /// <summary>
    /// LfdFlag of the DateLockUser
    /// LfdFlag الخاص بـ DateLockUser
    /// </summary>
    public DateTime? LfdFlag { get; private set; }

    /// <summary>
    /// LtdFlag of the DateLockUser
    /// LtdFlag الخاص بـ DateLockUser
    /// </summary>
    public DateTime? LtdFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// OneToOne relationship to User
    /// </summary>
    public User User { get; private set; }
    #endregion
}
}
