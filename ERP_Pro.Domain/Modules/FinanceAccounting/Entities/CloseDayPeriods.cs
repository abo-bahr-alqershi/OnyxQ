using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل فترات إغلاق الأيام ويحتوي على جميع خصائص إغلاق الفترات اليومية
/// </summary>
public class CloseDayPeriods : Entity<CloseDayPeriodsId>
{

    private CloseDayPeriods() { }

    public CloseDayPeriods(CloseDayPeriodsId id, DateTime? fDate, DateTime? tDate, decimal? branchNumber)
    {
        Id = id;
        FDate = fDate;
        TDate = tDate;
        BranchNumber = branchNumber;
    }

    /// <summary>
    /// معرف فريد لفترات إغلاق الأيام
    /// </summary>
    public CloseDayPeriodsId Id { get; private set; }

    /// <summary>
    /// تاريخ البداية
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// تاريخ النهاية
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// رقم الفترة المختصر
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// رقم السنة
    /// </summary>
    public decimal? YearNumber { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// حالة الفترة
    /// </summary>
    public decimal? Status { get; private set; }

    /// <summary>
    /// رقم مستخدم إغلاق الفترة
    /// </summary>
    public decimal? PeriodCloseUserId { get; private set; }

    /// <summary>
    /// تاريخ إغلاق الفترة
    /// </summary>
    public DateTime? PeriodCloseDate { get; private set; }

    /// <summary>
    /// رقم مستخدم إعادة فتح الفترة
    /// </summary>
    public decimal? PeriodUncloseUserId { get; private set; }

    /// <summary>
    /// تاريخ إعادة فتح الفترة
    /// </summary>
    public DateTime? PeriodUncloseDate { get; private set; }

    /// <summary>
    /// عدد مرات إغلاق الفترة
    /// </summary>
    public decimal? PeriodCloseCount { get; private set; }

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
