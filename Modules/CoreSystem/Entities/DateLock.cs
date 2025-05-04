using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// DateLock Entity
/// </summary>
public class DateLock : Entity<DateLockId>
{
    private DateLock() { }

    /// <summary>
    /// The unique identifier for the DateLock
    /// المعرف الفريد لـ DateLock
    /// </summary>
    public DateLockId Id { get; private set; }

    /// <summary>
    /// UfdFlag of the DateLock
    /// UfdFlag الخاص بـ DateLock
    /// </summary>
    public DateTime? UfdFlag { get; private set; }

    /// <summary>
    /// UtdFlag of the DateLock
    /// UtdFlag الخاص بـ DateLock
    /// </summary>
    public DateTime? UtdFlag { get; private set; }

    /// <summary>
    /// LfdFlag of the DateLock
    /// LfdFlag الخاص بـ DateLock
    /// </summary>
    public DateTime? LfdFlag { get; private set; }

    /// <summary>
    /// LtdFlag of the DateLock
    /// LtdFlag الخاص بـ DateLock
    /// </summary>
    public DateTime? LtdFlag { get; private set; }
}
}
