using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكيان يمثل سند الفرع ويحتوي على جميع خصائص سندات الفروع
/// </summary>
public class BranchVoucher : Entity<BranchVoucherId>
{

    private BranchVoucher() { }

    public BranchVoucher(BranchVoucherId id, decimal? vendorSerialShort)
    {
        Id = id;
        VendorSerialShort = vendorSerialShort;
    }

    /// <summary>
    /// المعرف الفريد لسند الفرع
    /// </summary>
    public BranchVoucherId Id { get; private set; }

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
    /// عملة الحساب
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// الرقم المختصر للمورد
    /// </summary>
    public decimal? VendorSerialShort { get; private set; }

    /// <summary>
    /// تاريخ السند
    /// </summary>
    public DateTime? VoucherDate { get; private set; }

    /// <summary>
    /// مبلغ النقدية
    /// </summary>
    public decimal? CashAmount { get; private set; }

    /// <summary>
    /// مبلغ النقدية بالعملة الأجنبية
    /// </summary>
    public decimal? CashAmountForeign { get; private set; }

    /// <summary>
    /// سعر الصرف
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// علم ترحيل السند
    /// </summary>
    public decimal? VoucherPostFlag { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// اسم المرجع
    /// </summary>
    public string ReferenceName { get; private set; }

    /// <summary>
    /// وصف الحساب
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// اسم المستلم
    /// </summary>
    public string ReceiverName { get; private set; }

    /// <summary>
    /// علم الانتظار
    /// </summary>
    public decimal? StandByFlag { get; private set; }

    /// <summary>
    /// علم التحويل
    /// </summary>
    public decimal? TransferFlag { get; private set; }

    /// <summary>
    /// نوع الشيك
    /// </summary>
    public decimal? ChequeType { get; private set; }

    /// <summary>
    /// رقم العمود المختصر
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

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
    /// نسبة العمولة
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// رقم سند الدفع السنوي
    /// </summary>
    public decimal? VoucherNumberPaymentYear { get; private set; }

    /// <summary>
    /// تاريخ سند الدفع السنوي
    /// </summary>
    public DateTime? VoucherDatePaymentYear { get; private set; }

    /// <summary>
    /// حركة الشيك السنوية
    /// </summary>
    public decimal? MoveChequePaymentYear { get; private set; }

    /// <summary>
    /// حركة عملة الشيك السنوية
    /// </summary>
    public decimal? MoveChequeCurrencyYear { get; private set; }

    /// <summary>
    /// رقم نوع المورد
    /// </summary>
    public decimal? VendorTypeNumber { get; private set; }

    /// <summary>
    /// علم الترحيل الخارجي
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

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
    /// تسلسل المستند
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// رقم مستند الفرع
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

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

