using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكيان يمثل تفاصيل النقدية في البنك ويحتوي على جميع خصائص النقدية في البنوك
/// </summary>
public class CashAtBankDetail : Entity<CashAtBankDetailId>
{

    private CashAtBankDetail() { }

    public CashAtBankDetail(CashAtBankDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// المعرف الفريد لتفاصيل النقدية في البنك
    /// </summary>
    public CashAtBankDetailId Id { get; private set; }

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
    /// علم التعطيل
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// تاريخ التعطيل
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

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
    /// حد جواز السفر
    /// </summary>
    public decimal? PassportLimit { get; private set; }

    /// <summary>
    /// رقم حساب البنك
    /// </summary>
    public string BankAccount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع عملة الحساب (متعدد إلى واحد)
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع البنك النقدي (متعدد إلى واحد)
    /// </summary>
    public BankCash BankCash { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

