using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكيان يمثل تتبع الشيك ويحتوي على جميع خصائص تتبع الشيكات
/// </summary>
public class ChequeTrace : Entity<ChequeTraceId>
{

    private ChequeTrace() { }

    public ChequeTrace(ChequeTraceId id)
    {
        Id = id;
    }

    /// <summary>
    /// المعرف الفريد لتتبع الشيك
    /// </summary>
    public ChequeTraceId Id { get; private set; }

    /// <summary>
    /// نوع التدقيق
    /// </summary>
    public decimal? AuditType { get; private set; }

    /// <summary>
    /// نوع قيد السند الكامل
    /// </summary>
    public decimal? VoucherTypeFull { get; private set; }

    /// <summary>
    /// نوع دفع السند المختصر
    /// </summary>
    public decimal? VoucherPayTypeShort { get; private set; }

    /// <summary>
    /// رقم السند
    /// </summary>
    public decimal? VoucherNumber { get; private set; }

    /// <summary>
    /// رقم النقدية
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// الرقم المختصر للمورد
    /// </summary>
    public decimal? VendorSerialShort { get; private set; }

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
    /// وصف الحساب
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// سبب الإرجاع
    /// </summary>
    public string ReturnReason { get; private set; }

    /// <summary>
    /// مبلغ الحساب
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// مبلغ الحساب بالعملة الأجنبية
    /// </summary>
    public decimal? AccountAmountForeign { get; private set; }

    /// <summary>
    /// كود مركز التكلفة
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// كود العميل
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// كود المورد
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// نوع الشيك
    /// </summary>
    public decimal? ChequeType { get; private set; }

    /// <summary>
    /// رقم النقدية أو البنك
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// رقم الشيك
    /// </summary>
    public string ChequeNumber { get; private set; }

    /// <summary>
    /// تاريخ الاستحقاق
    /// </summary>
    public DateTime? ValueDate { get; private set; }

    /// <summary>
    /// علم ترحيل الشيك
    /// </summary>
    public decimal? ChequePostFlag { get; private set; }

    /// <summary>
    /// علم تقييم الشيك
    /// </summary>
    public decimal? ChequeValuedFlag { get; private set; }

    /// <summary>
    /// رقم السند
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// رقم البنك
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// رقم التأييد
    /// </summary>
    public decimal? Endrsmnt { get; private set; }

    /// <summary>
    /// كود الحساب النهائي
    /// </summary>
    public string AccountCodeEnd { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب النهائي
    /// </summary>
    public string AccountDetailEndCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب النهائي
    /// </summary>
    public decimal? AccountDetailTypeEnd { get; private set; }

    /// <summary>
    /// كود العميل النهائي
    /// </summary>
    public string CCodeEnd { get; private set; }

    /// <summary>
    /// كود المورد النهائي
    /// </summary>
    public string VendorCodeEnd { get; private set; }

    /// <summary>
    /// علم الترحيل الخارجي
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// تسلسل المستند
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// نوع المستند المرجعي
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// نوع قيد اليومية المرجعي
    /// </summary>
    public decimal? DocJvTypeRef { get; private set; }

    /// <summary>
    /// رقم المستند المرجعي
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// رقم تسلسلي للمستند المرجعي
    /// </summary>
    public decimal? DocSerRef { get; private set; }

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
    /// رقم مستخدم التدقيق
    /// </summary>
    public decimal? AuditUserId { get; private set; }

    /// <summary>
    /// تاريخ التدقيق
    /// </summary>
    public DateTime? AuditDate { get; private set; }

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
    /// تاريخ التأييد
    /// </summary>
    public DateTime? EndrsmntDate { get; private set; }

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

