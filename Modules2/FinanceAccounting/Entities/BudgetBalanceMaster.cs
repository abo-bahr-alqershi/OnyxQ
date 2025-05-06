using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل كيان الرصيد الرئيسي للميزانية ويحتوي على جميع خصائص مستندات الرصيد
/// </summary>
public class BudgetBalanceMaster : Entity<BudgetBalanceMasterId>
{

    private BudgetBalanceMaster() { }

    public BudgetBalanceMaster(BudgetBalanceMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// معرف فريد للرصيد الرئيسي للميزانية
    /// </summary>
    public BudgetBalanceMasterId Id { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// رقم تسلسلي للمستند
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// تاريخ المستند
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// وصف المستند
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ملاحظات المستند
    /// </summary>
    public string DocNote { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// نوع فترة الميزانية
    /// </summary>
    public decimal? BudgetPeriodType { get; private set; }

    /// <summary>
    /// نوع الميزانية
    /// </summary>
    public decimal? BudgetType { get; private set; }

    /// <summary>
    /// حالة الاعتماد
    /// </summary>
    public decimal? ApprovedFlag { get; private set; }

    /// <summary>
    /// رقم مستخدم الاعتماد
    /// </summary>
    public decimal? ApprovalUserId { get; private set; }

    /// <summary>
    /// تاريخ الاعتماد
    /// </summary>
    public DateTime? ApprovalDate { get; private set; }

    /// <summary>
    /// وصف الاعتماد
    /// </summary>
    public string ApprovalDescription { get; private set; }

    /// <summary>
    /// رقم المستند المرجعي
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// رقم تسلسلي للمستند المرجعي
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// افتراضي
    /// </summary>
    public decimal? Dflt { get; private set; }

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
    /// علاقة مرجعية مع سعر الصرف (متعدد إلى واحد)
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

