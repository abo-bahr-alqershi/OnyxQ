using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events;

/// <summary>
/// Event raised when a new period branch close record is created
/// حدث يتم رفعه عند إنشاء سجل إغلاق فترة فرع جديد
/// </summary>
public class PeriodBranchCloseCreatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchCloseCreatedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
}

/// <summary>
/// Event raised when a period branch is closed
/// حدث يتم رفعه عند إغلاق فترة الفرع
/// </summary>
public class PeriodBranchClosedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchClosedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
}

/// <summary>
/// Event raised when a period branch is unclosed
/// حدث يتم رفعه عند إلغاء إغلاق فترة الفرع
/// </summary>
public class PeriodBranchUnclosedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchUnclosedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
}

/// <summary>
/// Event raised when profit/loss is closed for a period branch
/// حدث يتم رفعه عند إغلاق الأرباح والخسائر لفترة الفرع
/// </summary>
public class PeriodBranchProfitLossClosedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchProfitLossClosedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
}

/// <summary>
/// Event raised when profit/loss is unclosed for a period branch
/// حدث يتم رفعه عند إلغاء إغلاق الأرباح والخسائر لفترة الفرع
/// </summary>
public class PeriodBranchProfitLossUnclosedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchProfitLossUnclosedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
}

/// <summary>
/// Event raised when inventory is closed for a period branch
/// حدث يتم رفعه عند إغلاق المخزون لفترة الفرع
/// </summary>
public class PeriodBranchInventoryClosedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchInventoryClosedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
}

/// <summary>
/// Event raised when inventory is unclosed for a period branch
/// حدث يتم رفعه عند إلغاء إغلاق المخزون لفترة الفرع
/// </summary>
public class PeriodBranchInventoryUnclosedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchInventoryUnclosedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
}

/// <summary>
/// Event raised when depreciation is closed for a period branch
/// حدث يتم رفعه عند إغلاق الإهلاك لفترة الفرع
/// </summary>
public class PeriodBranchDepreciationClosedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchDepreciationClosedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
}

/// <summary>
/// Event raised when depreciation is unclosed for a period branch
/// حدث يتم رفعه عند إلغاء إغلاق الإهلاك لفترة الفرع
/// </summary>
public class PeriodBranchDepreciationUnclosedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchDepreciationUnclosedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
}

/// <summary>
/// Event raised when MRP is closed for a period branch
/// حدث يتم رفعه عند إغلاق تخطيط موارد التصنيع لفترة الفرع
/// </summary>
public class PeriodBranchMrpClosedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchMrpClosedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
}

/// <summary>
/// Event raised when MRP is unclosed for a period branch
/// حدث يتم رفعه عند إلغاء إغلاق تخطيط موارد التصنيع لفترة الفرع
/// </summary>
public class PeriodBranchMrpUnclosedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchMrpUnclosedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
}

/// <summary>
/// Event raised when currency settings are updated for a period branch
/// حدث يتم رفعه عند تحديث إعدادات العملة لفترة الفرع
/// </summary>
public class PeriodBranchCurrencySettingsUpdatedEvent : DomainEvent
{
    /// <summary>
    /// Gets the period branch close
    /// إغلاق فترة الفرع
    /// </summary>
    public PeriodBranchClose PeriodBranchClose { get; }

    public PeriodBranchCurrencySettingsUpdatedEvent(PeriodBranchClose periodBranchClose)
    {
        PeriodBranchClose = periodBranchClose;
    }
} 