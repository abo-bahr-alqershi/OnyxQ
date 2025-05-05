using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل كيان طلب اعتماد الميزانية الرئيسي ويحتوي على جميع خصائص مستندات طلبات الاعتماد
/// </summary>
public class BudgetApprovalRequestFinanceMaster : AggregateRoot<BudgetApprovalRequestFinanceMasterId>
{

    private BudgetApprovalRequestFinanceMaster() { }

    public BudgetApprovalRequestFinanceMaster(BudgetApprovalRequestFinanceMasterId id, decimal? docSrl)
    {
        Id = id;
        DocSrl = docSrl;
    }

    /// <summary>
    /// معرف فريد لطلب اعتماد الميزانية الرئيسي
    /// </summary>
    public BudgetApprovalRequestFinanceMasterId Id { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// رقم تسلسلي للمستند
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// تاريخ المستند
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// وصف المستند
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// اسم المستفيد
    /// </summary>
    public string BeneficiaryName { get; private set; }

    /// <summary>
    /// اسم المستلم
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

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
    /// نوع الرقم المختصر
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// كود العملة
    /// </summary>
    public string CurCode { get; private set; }

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
    /// رقم المرفق
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// طريقة الدفع
    /// </summary>
    public decimal? PaymentMethod { get; private set; }

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
    /// حالة التعطيل
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// سبب التعطيل
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// رقم المستخدم الذي قام بالتعطيل
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// تاريخ التعطيل
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// حالة المعالجة
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// كود المندوب
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// حالة الانتظار
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// حالة الترحيل
    /// </summary>
    public decimal? PostedFlag { get; private set; }

    /// <summary>
    /// حقل إضافي 1
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// حقل إضافي 2
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// حقل إضافي 3
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// حقل إضافي 4
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// حقل إضافي 5
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// حقل إضافي 6
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// حقل إضافي 7
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// حقل إضافي 8
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// حقل إضافي 9
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// حقل إضافي 10
    /// </summary>
    public string Field10 { get; private set; }

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

