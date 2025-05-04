using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تتبع أسعار الصرف ويحتوي على جميع خصائص تتبع أسعار العملات
/// </summary>
public class ExchangeRateTrace : Entity<ExchangeRateTraceId>
{

    private ExchangeRateTrace() { }

    public ExchangeRateTrace(ExchangeRateTraceId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لتتبع سعر الصرف
    /// </summary>
    public ExchangeRateTraceId Id { get; private set; }

    /// <summary>
    /// رقم العملة
    /// </summary>
    public decimal? CurNo { get; private set; }

    /// <summary>
    /// كود العملة
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// سعر العملة
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// أعلى سعر للعملة
    /// </summary>
    public decimal? MaxCurrencyRate { get; private set; }

    /// <summary>
    /// أقل سعر للعملة
    /// </summary>
    public decimal? MinCurrencyRate { get; private set; }

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
