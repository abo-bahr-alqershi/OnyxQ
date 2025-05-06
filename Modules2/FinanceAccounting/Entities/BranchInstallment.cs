using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل أقساط الفروع ويحتوي على جميع خصائص عمليات التقسيط للفروع
/// </summary>
public class BranchInstallment : Entity<BranchInstallmentId>
{

    private BranchInstallment() { }

    public BranchInstallment(BranchInstallmentId id, decimal? billSerial, decimal? itemNumber, string cCode, decimal? itemPaymentYear, decimal? recordNumber)
    {
        Id = id;
        BillSerial = billSerial;
        ItemNumber = itemNumber;
        CCode = cCode;
        ItemPaymentYear = itemPaymentYear;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// معرف فريد لقسط الفرع
    /// </summary>
    public BranchInstallmentId Id { get; private set; }

    /// <summary>
    /// نوع المستند
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// نوع مستند الفاتورة الكامل
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// رقم الفاتورة
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// تسلسل الفاتورة
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// تاريخ المستند
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// رقم القسط
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// تاريخ القسط
    /// </summary>
    public DateTime? ItemDate { get; private set; }

    /// <summary>
    /// مبلغ الفاتورة
    /// </summary>
    public decimal? InvoiceAmount { get; private set; }

    /// <summary>
    /// سعر الحساب
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// رقم الشيك
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// تاريخ استحقاق الشيك
    /// </summary>
    public DateTime? ChequeDueDate { get; private set; }

    /// <summary>
    /// كود مركز التكلفة
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// رقم المشروع
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// كود العميل
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// عملة الحساب
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// المبلغ المدفوع
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// تاريخ الدفع
    /// </summary>
    public DateTime? PaidDate { get; private set; }

    /// <summary>
    /// مبلغ التسوية
    /// </summary>
    public decimal? AdjustmentAmount { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// رقم السند
    /// </summary>
    public decimal? DrNo { get; private set; }

    /// <summary>
    /// سنة دفع القسط
    /// </summary>
    public decimal? ItemPaymentYear { get; private set; }

    /// <summary>
    /// علم الترحيل الخارجي
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// تسلسل المستند
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// وصف المستند
    /// </summary>
    public string DocDsc { get; private set; }

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
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

