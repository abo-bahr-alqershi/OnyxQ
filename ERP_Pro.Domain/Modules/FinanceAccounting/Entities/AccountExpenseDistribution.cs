using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل توزيع مصروف الحساب ويحتوي على جميع خصائص توزيع المصروفات
/// </summary>
public class AccountExpenseDistribution : Entity<AccountExpenseDistributionId>
{

    private AccountExpenseDistribution() { }

    public AccountExpenseDistribution(AccountExpenseDistributionId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لتوزيع مصروف الحساب
    /// </summary>
    public AccountExpenseDistributionId Id { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// كود الحساب
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// كود مركز التكلفة
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// رقم المشروع
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// رقم النشاط
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// نسبة المصروف
    /// </summary>
    public decimal? ExpensePercent { get; private set; }

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

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

