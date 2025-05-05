using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل قيد اليومية للفرع ويحتوي على جميع خصائص تفاصيل قيود اليومية للفروع
/// </summary>
public class BranchJournalVoucherDetail : Entity<BranchJournalVoucherDetailId>
{

    private BranchJournalVoucherDetail() { }

    public BranchJournalVoucherDetail(BranchJournalVoucherDetailId id, string accountCode, decimal? recordNumber)
    {
        Id = id;
        AccountCode = accountCode;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// معرف فريد لتفاصيل قيد اليومية للفرع
    /// </summary>
    public BranchJournalVoucherDetailId Id { get; private set; }

    /// <summary>
    /// نوع قيد اليومية الكامل
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// رقم مستند القيد
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

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
    /// وصف القيد
    /// </summary>
    public string JournalDescription { get; private set; }

    /// <summary>
    /// مبلغ القيد
    /// </summary>
    public decimal? JournalAmount { get; private set; }

    /// <summary>
    /// مبلغ القيد بالعملة الأجنبية
    /// </summary>
    public decimal? JournalAmountForeign { get; private set; }

    /// <summary>
    /// سعر الحساب
    /// </summary>
    public decimal? AccountRate { get; private set; }

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
    /// كود العميل
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// كود المورد
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// كود المندوب
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// رقم العمود المختصر
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// رقم اعتماد مستندي
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// رقم المجموعة الكامل
    /// </summary>
    public string GroupNumberFull { get; private set; }

    /// <summary>
    /// رقم النقدية أو البنك
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ترتيب رقم السجل
    /// </summary>
    public decimal? RecordNumberOrder { get; private set; }

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
    /// تاريخ استحقاق المستند
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// رقم الفاتورة
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// تسلسل الفاتورة
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// رقم أمين الصندوق
    /// </summary>
    public decimal? CashierNumber { get; private set; }

    /// <summary>
    /// رقم البند
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// رقم أمر العمل
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// تسلسل أمر العمل
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// رقم الشيك
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// رقم السند
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// تسلسل المستند
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// علم الترحيل الخارجي
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// رقم مستند الفرع
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// ملاحظة
    /// </summary>
    public string Note { get; private set; }

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
    /// رقم العقد
    /// </summary>
    public decimal? ContractNumber { get; private set; }

    /// <summary>
    /// تسلسل العقد المختصر
    /// </summary>
    public decimal? ContractSerialShort { get; private set; }

    /// <summary>
    /// دفعة العقد
    /// </summary>
    public decimal? ContractBatch { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة مرجعية مع مستند قيد اليومية (متعدد إلى واحد)
    /// </summary>
    public JournalVoucherMaster JournalVoucherMaster { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

