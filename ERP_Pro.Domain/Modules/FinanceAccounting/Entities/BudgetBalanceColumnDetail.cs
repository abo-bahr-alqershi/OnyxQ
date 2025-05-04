using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل أعمدة رصيد الميزانية ويحتوي على جميع خصائص الأعمدة المالية
/// </summary>
public class BudgetBalanceColumnDetail : Entity<BudgetBalanceColumnDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<AccountCurrency> _accountCurrency = new List<AccountCurrency>();
    private readonly List<ExchangeRate> _exchangeRate = new List<ExchangeRate>();
    private readonly List<BudgetBalanceMaster> _budgetBalanceMaster = new List<BudgetBalanceMaster>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();

    private BudgetBalanceColumnDetail() { }

    public BudgetBalanceColumnDetail(BudgetBalanceColumnDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لتفاصيل أعمدة رصيد الميزانية
    /// </summary>
    public BudgetBalanceColumnDetailId Id { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// المبلغ المحلي 1
    /// </summary>
    public decimal? AmountLocal1 { get; private set; }

    /// <summary>
    /// المبلغ المحلي 2
    /// </summary>
    public decimal? AmountLocal2 { get; private set; }

    /// <summary>
    /// المبلغ المحلي 3
    /// </summary>
    public decimal? AmountLocal3 { get; private set; }

    /// <summary>
    /// المبلغ المحلي 4
    /// </summary>
    public decimal? AmountLocal4 { get; private set; }

    /// <summary>
    /// المبلغ المحلي 5
    /// </summary>
    public decimal? AmountLocal5 { get; private set; }

    /// <summary>
    /// المبلغ المحلي 6
    /// </summary>
    public decimal? AmountLocal6 { get; private set; }

    /// <summary>
    /// المبلغ المحلي 7
    /// </summary>
    public decimal? AmountLocal7 { get; private set; }

    /// <summary>
    /// المبلغ المحلي 8
    /// </summary>
    public decimal? AmountLocal8 { get; private set; }

    /// <summary>
    /// المبلغ المحلي 9
    /// </summary>
    public decimal? AmountLocal9 { get; private set; }

    /// <summary>
    /// المبلغ المحلي 10
    /// </summary>
    public decimal? AmountLocal10 { get; private set; }

    /// <summary>
    /// المبلغ المحلي 11
    /// </summary>
    public decimal? AmountLocal11 { get; private set; }

    /// <summary>
    /// المبلغ المحلي 12
    /// </summary>
    public decimal? AmountLocal12 { get; private set; }

    /// <summary>
    /// وصف المستند
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// رقم المستند المرجعي
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// رقم تسلسلي للمستند المرجعي
    /// </summary>
    public decimal? DocSerRef { get; private set; }

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
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// نوع الميزانية
    /// </summary>
    public decimal? BudgetType { get; private set; }

    /// <summary>
    /// نوع فترة الميزانية
    /// </summary>
    public decimal? BudgetPeriodType { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة تجميعية مع الأنشطة (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// علاقة تجميعية مع عملات الحساب (متعدد إلى متعدد)
    /// </summary>
    public ICollection<AccountCurrency> AccountCurrency => _accountCurrency;
    /// <summary>
    /// علاقة تجميعية مع أسعار الصرف (متعدد إلى متعدد)
    /// </summary>
    public ICollection<ExchangeRate> ExchangeRate => _exchangeRate;
    /// <summary>
    /// علاقة تجميعية مع الرصيد الرئيسي للميزانية (متعدد إلى متعدد)
    /// </summary>
    public ICollection<BudgetBalanceMaster> BudgetBalanceMaster => _budgetBalanceMaster;
    /// <summary>
    /// علاقة تجميعية مع المشاريع (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// علاقة تجميعية مع مراكز التكلفة (متعدد إلى متعدد)
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
