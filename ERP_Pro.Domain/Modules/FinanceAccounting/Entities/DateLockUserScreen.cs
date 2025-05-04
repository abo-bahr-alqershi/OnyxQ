using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل قفل التواريخ للمستخدم على الشاشة ويحتوي على جميع خصائص قفل التواريخ
/// </summary>
public class DateLockUserScreen : Entity<DateLockUserScreenId>
{

    private DateLockUserScreen() { }

    public DateLockUserScreen(DateLockUserScreenId id, decimal? formNumber)
    {
        Id = id;
        FormNumber = formNumber;
    }

    /// <summary>
    /// معرف فريد لقفل التواريخ للمستخدم
    /// </summary>
    public DateLockUserScreenId Id { get; private set; }

    /// <summary>
    /// رقم النموذج
    /// </summary>
    public decimal? FormNumber { get; private set; }

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
    /// علاقة مرجعية مع المستخدم (متعدد إلى واحد)
    /// </summary>
    public User User { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
