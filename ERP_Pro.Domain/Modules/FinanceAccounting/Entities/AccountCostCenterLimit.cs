using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل حدود مركز تكلفة الحساب ويحتوي على جميع خصائص حدود الصلاحيات المالية
/// </summary>
public class AccountCostCenterLimit : Entity<AccountCostCenterLimitId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<Account> _account = new List<Account>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();

    private AccountCostCenterLimit() { }

    public AccountCostCenterLimit(AccountCostCenterLimitId id)
    {
        Id = id;
    }

    /// <summary>
    /// المعرف الفريد لـ AccountCostCenterLimit
    /// </summary>
    public AccountCostCenterLimitId Id { get; private set; }

    /// <summary>
    /// العملة الخاصة بـ AccountCostCenterLimit
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// الحد الأدنى للمبلغ الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MinAmount { get; private set; }

    /// <summary>
    /// الحد الأقصى للمبلغ الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MaxAmount { get; private set; }

    /// <summary>
    /// الحد الأدنى لمبلغ المعاملة الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MinTransactionAmount { get; private set; }

    /// <summary>
    /// الحد الأقصى لمبلغ المعاملة الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MaxTransactionAmount { get; private set; }

    /// <summary>
    /// الحد الأقصى للنسبة المئوية للحد الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MaxLimitPercent { get; private set; }

    /// <summary>
    /// الحد الأقصى الممكن للحد الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MaxLimitPossible { get; private set; }

    /// <summary>
    /// رقم الفرع الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// تجاوز الحد الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? ExceedLimit { get; private set; }

    /// <summary>
    /// DrCr الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? DrCr { get; private set; }

    /// <summary>
    /// وصف الحد الخاص بـ AccountCostCenterLimit
    /// </summary>
    public string LimitDescription { get; private set; }

    /// <summary>
    /// رمز تفاصيل الحساب الخاص بـ AccountCostCenterLimit
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// مبلغ التسهيلات الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? FacilityAmount { get; private set; }

    /// <summary>
    /// حالة التسهيلات الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? FacilityStatus { get; private set; }

    /// <summary>
    /// علم التعطيل الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// المبلغ اليومي الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? DalyAmt { get; private set; }

    /// <summary>
    /// المبلغ الشهري الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? MonthlyAmount { get; private set; }

    /// <summary>
    /// المبلغ السنوي الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? AnnualAmount { get; private set; }

    /// <summary>
    /// رمز تفاصيل الحساب الفرعي الخاص بـ AccountCostCenterLimit
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// علم النشر الخارجي الخاص بـ AccountCostCenterLimit
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة تجميع: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// علاقة تجميع: ManyToMany
    /// </summary>
    public ICollection<Account> Account => _account;
    /// <summary>
    /// علاقة تجميع: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// علاقة تجميع: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    #endregion

    #region Methods
    // أضف طرق منطق المجال هنا
    #endregion
}
}

