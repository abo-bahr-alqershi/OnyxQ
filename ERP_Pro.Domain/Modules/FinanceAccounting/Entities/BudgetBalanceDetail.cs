using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل رصيد الميزانية ويحتوي على جميع خصائص التفاصيل المالية
/// </summary>
public class BudgetBalanceDetail : Entity<BudgetBalanceDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<Account> _account = new List<Account>();
    private readonly List<ExchangeRate> _exchangeRate = new List<ExchangeRate>();
    private readonly List<BudgetBalanceMaster> _budgetBalanceMaster = new List<BudgetBalanceMaster>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();

    private BudgetBalanceDetail() { }

    public BudgetBalanceDetail(BudgetBalanceDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لتفاصيل رصيد الميزانية
    /// </summary>
    public BudgetBalanceDetailId Id { get; private set; }

    /// <summary>
    /// نوع الميزانية
    /// </summary>
    public decimal? BudgetType { get; private set; }

    /// <summary>
    /// نوع فترة الميزانية
    /// </summary>
    public decimal? BudgetPeriodType { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// رقم الفترة المختصر
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// تاريخ البداية
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// تاريخ النهاية
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// المبلغ المحلي
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// المبلغ بالعملة الأجنبية
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// حركة الإضافة المحلية
    /// </summary>
    public decimal? AmountLocalAdditionalMovement { get; private set; }

    /// <summary>
    /// حركة الإضافة بالعملة الأجنبية
    /// </summary>
    public decimal? AmountForeignAdditionalMovement { get; private set; }

    /// <summary>
    /// حركة الخصم المحلية
    /// </summary>
    public decimal? AmountLocalDiscountMovement { get; private set; }

    /// <summary>
    /// حركة الخصم بالعملة الأجنبية
    /// </summary>
    public decimal? AmountForeignDiscountMovement { get; private set; }

    /// <summary>
    /// سعر الحساب
    /// </summary>
    public decimal? AccountRate { get; private set; }

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
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// إضافة محلية
    /// </summary>
    public decimal? AmountLocalAdditional { get; private set; }

    /// <summary>
    /// إضافة بالعملة الأجنبية
    /// </summary>
    public decimal? AmountForeignAdditional { get; private set; }

    /// <summary>
    /// خصم محلي
    /// </summary>
    public decimal? AmountLocalDiscount { get; private set; }

    /// <summary>
    /// خصم بالعملة الأجنبية
    /// </summary>
    public decimal? AmountForeignDiscount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة تجميعية مع الأنشطة (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// علاقة تجميعية مع الحسابات (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Account> Account => _account;
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
