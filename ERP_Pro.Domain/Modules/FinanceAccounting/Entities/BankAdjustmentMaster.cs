using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل مستند تسوية البنك ويحتوي على جميع خصائص مستندات تسوية البنوك
/// </summary>
public class BankAdjustmentMaster : AggregateRoot<BankAdjustmentMasterId>
{

    private BankAdjustmentMaster() { }

    public BankAdjustmentMaster(BankAdjustmentMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// معرف فريد لمستند تسوية البنك
    /// </summary>
    public BankAdjustmentMasterId Id { get; private set; }

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
    /// رقم فرع البنك
    /// </summary>
    public decimal? BranchBankNumber { get; private set; }

    /// <summary>
    /// رصيد البنك في البنك
    /// </summary>
    public decimal? BankBalanceInBank { get; private set; }

    /// <summary>
    /// رصيد البنك في الشركة
    /// </summary>
    public decimal? BankBalanceInCompany { get; private set; }

    /// <summary>
    /// حالة المعالجة
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// مستند قيد اليومية
    /// </summary>
    public decimal? JournalVoucherDocument { get; private set; }

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
    /// نوع العملية المختصر
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// سعر الصرف
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// علم الاستعداد
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// رقم المرفق
    /// </summary>
    public decimal? AttachmentNumber { get; private set; }

    /// <summary>
    /// تسلسل المستند
    /// </summary>
    public decimal? DocSq { get; private set; }

    /// <summary>
    /// نوع المستند المرجعي
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// نوع قيد اليومية المرجعي
    /// </summary>
    public decimal? DocJvTypRef { get; private set; }

    /// <summary>
    /// رقم المستند المرجعي
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// رقم تسلسلي للمستند المرجعي
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// تسلسل المستند المرجعي
    /// </summary>
    public decimal? DocSqRef { get; private set; }

    /// <summary>
    /// وصف المستند
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// حالة الترحيل
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// رقم مستخدم الترحيل
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// تاريخ الترحيل
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// رقم مستخدم إلغاء الترحيل
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// تاريخ إلغاء الترحيل
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// مرجع التدقيق
    /// </summary>
    public decimal? AuditReference { get; private set; }

    /// <summary>
    /// وصف مرجع التدقيق
    /// </summary>
    public string AuditReferenceDescription { get; private set; }

    /// <summary>
    /// رقم مستخدم مرجع التدقيق
    /// </summary>
    public decimal? AuditReferenceUserId { get; private set; }

    /// <summary>
    /// تاريخ مرجع التدقيق
    /// </summary>
    public DateTime? AuditReferenceDate { get; private set; }

    /// <summary>
    /// علم الترحيل الخارجي
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

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

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع الحساب (متعدد إلى واحد)
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع تفاصيل النقدية في البنك (متعدد إلى واحد)
    /// </summary>
    public CashAtBankDetail CashAtBankDetail { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

