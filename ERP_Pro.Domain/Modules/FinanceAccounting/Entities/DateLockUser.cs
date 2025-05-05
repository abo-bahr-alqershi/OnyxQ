using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل قفل التواريخ للمستخدم ويحتوي على جميع خصائص قفل التواريخ للمستخدم
/// </summary>
public class DateLockUser : Entity<DateLockUserId>
{

    private DateLockUser() { }

    public DateLockUser(DateLockUserId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لقفل التواريخ للمستخدم
    /// </summary>
    public DateLockUserId Id { get; private set; }

    /// <summary>
    /// علم تاريخ البداية الأولى
    /// </summary>
    public DateTime? UfdFlag { get; private set; }

    /// <summary>
    /// علم تاريخ النهاية الأولى
    /// </summary>
    public DateTime? UtdFlag { get; private set; }

    /// <summary>
    /// علم تاريخ البداية الأخيرة
    /// </summary>
    public DateTime? LfdFlag { get; private set; }

    /// <summary>
    /// علم تاريخ النهاية الأخيرة
    /// </summary>
    public DateTime? LtdFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع المستخدم (واحد إلى واحد)
    /// </summary>
    public User User { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

