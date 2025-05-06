using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.StationsFuel.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل النقدية باليد ويحتوي على جميع خصائص النقدية باليد
/// </summary>
public class CashInHandDetail : Entity<CashInHandDetailId>
{

    private CashInHandDetail() { }

    public CashInHandDetail(CashInHandDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لتفاصيل النقدية باليد
    /// </summary>
    public CashInHandDetailId Id { get; private set; }

    /// <summary>
    /// الرصيد الافتتاحي بالعملة المحلية
    /// </summary>
    public decimal? OpenBalanceLocal { get; private set; }

    /// <summary>
    /// الرصيد الافتتاحي بالعملة الأجنبية
    /// </summary>
    public decimal? OpenBalanceForeign { get; private set; }

    /// <summary>
    /// الرصيد الحالي بالعملة المحلية
    /// </summary>
    public decimal? CurrBalL { get; private set; }

    /// <summary>
    /// الرصيد الحالي بالعملة الأجنبية
    /// </summary>
    public decimal? CurrBalF { get; private set; }

    /// <summary>
    /// حالة التعطيل
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// الحد الأدنى للمبلغ
    /// </summary>
    public decimal? MinLimitAmount { get; private set; }

    /// <summary>
    /// الحد الأعلى للمبلغ
    /// </summary>
    public decimal? MaxLimitAmount { get; private set; }

    /// <summary>
    /// الحد الأعلى لمبلغ العملية
    /// </summary>
    public decimal? MaxLimitTransactionAmount { get; private set; }

    /// <summary>
    /// الحد الأدنى لمبلغ العملية
    /// </summary>
    public decimal? MinLimitTransactionAmount { get; private set; }

    /// <summary>
    /// حد الجواز
    /// </summary>
    public decimal? PassportLimit { get; private set; }

    /// <summary>
    /// تاريخ التعطيل
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع عملة الحساب (متعدد إلى واحد)
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع النقدية باليد (متعدد إلى واحد)
    /// </summary>
    public HandCash HandCash { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

