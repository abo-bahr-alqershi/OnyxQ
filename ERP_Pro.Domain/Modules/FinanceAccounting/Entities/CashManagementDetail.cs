using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل إدارة النقد ويحتوي على جميع خصائص تفاصيل العمليات النقدية
/// </summary>
public class CashManagementDetail : Entity<CashManagementDetailId>
{
    private readonly List<AccountCurrency> _accountCurrency = new List<AccountCurrency>();
    private readonly List<CashInHandDetail> _cashInHandDetail = new List<CashInHandDetail>();
    private readonly List<CashManagementMaster> _cashManagementMaster = new List<CashManagementMaster>();

    private CashManagementDetail() { }

    public CashManagementDetail(CashManagementDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لتفاصيل إدارة النقد
    /// </summary>
    public CashManagementDetailId Id { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// سعر الحساب
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// المبلغ
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// المبلغ بالعملة الأجنبية
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// نوع النقدية
    /// </summary>
    public string MoneyClass { get; private set; }

    /// <summary>
    /// مبلغ النقدية
    /// </summary>
    public decimal? CashAmount { get; private set; }

    /// <summary>
    /// رصيد النقدية
    /// </summary>
    public decimal? CashBalance { get; private set; }

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

    /// <summary>
    /// عدد الأصناف
    /// </summary>
    public decimal? ClassCount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة تجميعية مع عملات الحساب (متعدد إلى متعدد)
    /// </summary>
    public ICollection<AccountCurrency> AccountCurrency => _accountCurrency;
    /// <summary>
    /// علاقة تجميعية مع تفاصيل النقدية باليد (متعدد إلى متعدد)
    /// </summary>
    public ICollection<CashInHandDetail> CashInHandDetail => _cashInHandDetail;
    /// <summary>
    /// علاقة تجميعية مع إدارة النقد الرئيسية (متعدد إلى متعدد)
    /// </summary>
    public ICollection<CashManagementMaster> CashManagementMaster => _cashManagementMaster;
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
