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
/// الكلاس يمثل تفاصيل طلب اعتماد الميزانية ويحتوي على جميع خصائص التفاصيل المالية للطلب
/// </summary>
public class BudgetApprovalRequestFinanceDetail : Entity<BudgetApprovalRequestFinanceDetailId>
{

    private BudgetApprovalRequestFinanceDetail() { }

    public BudgetApprovalRequestFinanceDetail(BudgetApprovalRequestFinanceDetailId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// معرف فريد لتفاصيل طلب اعتماد الميزانية
    /// </summary>
    public BudgetApprovalRequestFinanceDetailId Id { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// سعر العملة
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// المبلغ المحلي
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// المبلغ بالعملة الأجنبية
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// الرصيد الفعلي
    /// </summary>
    public decimal? ActualBalance { get; private set; }

    /// <summary>
    /// مبلغ الصرف
    /// </summary>
    public decimal? IssueAmount { get; private set; }

    /// <summary>
    /// مبلغ غير مصروف
    /// </summary>
    public decimal? NotIssueAmount { get; private set; }

    /// <summary>
    /// كود المندوب
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// وصف المستند
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// تسلسل المستند
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// رقم فرع المستند
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

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
    /// علاقة مرجعية مع النشاط (متعدد إلى واحد)
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع عملة الحساب (متعدد إلى واحد)
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع المشروع (متعدد إلى واحد)
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع طلب اعتماد الميزانية الرئيسي (متعدد إلى واحد)
    /// </summary>
    public BudgetApprovalRequestFinanceMaster BudgetApprovalRequestFinanceMaster { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع مركز التكلفة (متعدد إلى واحد)
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

