using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل سعر صرف العملة لفترة يومية ويحتوي على جميع خصائص أسعار الصرف اليومية للفترات
/// </summary>
public class PeriodExchangeRateDay : Entity<PeriodExchangeRateDayId>
{

    private PeriodExchangeRateDay() { }

    public PeriodExchangeRateDay(PeriodExchangeRateDayId id, DateTime? fDate, DateTime? tDate, string accountCurrency)
    {
        Id = id;
        FDate = fDate;
        TDate = tDate;
        AccountCurrency = accountCurrency;
    }

    /// <summary>
    /// معرف فريد لسعر صرف العملة لفترة يومية
    /// </summary>
    public PeriodExchangeRateDayId Id { get; private set; }

    /// <summary>
    /// تاريخ البداية
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// تاريخ النهاية
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// عملة الحساب
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// سعر العملة
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
