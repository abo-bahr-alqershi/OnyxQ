using System;

using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل تأكيد رصيد الحساب ويحتوي على جميع خصائص التأكيدات المالية
/// </summary>
public class AccountConfirmBalanceDetail : Entity<AccountConfirmBalanceDetailId>
{

    private AccountConfirmBalanceDetail() { }

    public AccountConfirmBalanceDetail(AccountConfirmBalanceDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لتفاصيل تأكيد رصيد الحساب
    /// </summary>
    public AccountConfirmBalanceDetailId Id { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// كود الحساب
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// عملة الحساب
    /// </summary>
    public string AccountCurrency { get; private set; }

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
    /// كود المندوب
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// مبلغ الرصيد
    /// </summary>
    public decimal? BalanceAmount { get; private set; }

    /// <summary>
    /// مبلغ الرصيد اليدوي
    /// </summary>
    public decimal? BalanceAmountManual { get; private set; }

    /// <summary>
    /// وصف التأكيد
    /// </summary>
    public string ConfirmDescription { get; private set; }

    /// <summary>
    /// تاريخ التأكيد
    /// </summary>
    public DateTime? ConfirmDate { get; private set; }

    /// <summary>
    /// وصف تأكيد العميل
    /// </summary>
    public string CustomerConfirmDescription { get; private set; }

    /// <summary>
    /// علم فئة التأكيد
    /// </summary>
    public decimal? ConfirmClassFlag { get; private set; }

    /// <summary>
    /// علم تأكيد العميل
    /// </summary>
    public decimal? CustomerConfirmFlag { get; private set; }

    /// <summary>
    /// تاريخ تأكيد العميل
    /// </summary>
    public DateTime? CustomerConfirmDate { get; private set; }

    /// <summary>
    /// سعر الحساب
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

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
    /// علاقة مرجعية مع تأكيد رصيد الحساب الرئيسي (متعدد إلى واحد)
    /// </summary>
    public AccountConfirmBalanceMaster AccountConfirmBalanceMaster { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

