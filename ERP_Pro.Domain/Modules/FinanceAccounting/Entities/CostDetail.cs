using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل التكلفة ويحتوي على جميع خصائص تفاصيل التكاليف
/// </summary>
public class CostDetail : Entity<CostDetailId>
{
    private readonly List<AccountCurrency> _accountCurrency = new List<AccountCurrency>();
    private readonly List<CostMaster> _costMaster = new List<CostMaster>();

    private CostDetail() { }

    public CostDetail(CostDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لتفاصيل التكلفة
    /// </summary>
    public CostDetailId Id { get; private set; }

    /// <summary>
    /// رقم فاتورة الشراء
    /// </summary>
    public decimal? PurchaseInvoiceNumber { get; private set; }

    /// <summary>
    /// رقم المجموعة الكامل
    /// </summary>
    public decimal? GroupNumberFull { get; private set; }

    /// <summary>
    /// رقم تسلسلي للمستند
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// مبلغ عملة الحساب
    /// </summary>
    public decimal? AccountCurrencyAmount { get; private set; }

    /// <summary>
    /// مبلغ عملة الفاتورة
    /// </summary>
    public decimal? AccountInvoiceCurrencyAmount { get; private set; }

    /// <summary>
    /// نوع توزيع التكلفة
    /// </summary>
    public decimal? CostDistributionType { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// سعر الصرف
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// رقم الشركة المختصر
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// رقم الفرع
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// سنة الفرع
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// مستخدم الفرع
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة تجميعية مع عملات الحساب (متعدد إلى متعدد)
    /// </summary>
    public ICollection<AccountCurrency> AccountCurrency => _accountCurrency;
    /// <summary>
    /// علاقة تجميعية مع التكاليف الرئيسية (متعدد إلى متعدد)
    /// </summary>
    public ICollection<CostMaster> CostMaster => _costMaster;
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
