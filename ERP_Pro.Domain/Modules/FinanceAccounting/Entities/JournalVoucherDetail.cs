using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل قيد اليومية ويحتوي على جميع خصائص العمليات المحاسبية التفصيلية
/// </summary>
public class JournalVoucherDetail : Entity<JournalVoucherDetailId>
{

    private JournalVoucherDetail() { }

    public JournalVoucherDetail(JournalVoucherDetailId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// معرف فريد لتفاصيل قيد اليومية
    /// </summary>
    public JournalVoucherDetailId Id { get; private set; }

    /// <summary>
    /// نوع قيد اليومية الكامل
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// رقم مستند اليومية
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب الفرعي
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// وصف اليومية
    /// </summary>
    public string JournalDescription { get; private set; }

    /// <summary>
    /// مبلغ اليومية
    /// </summary>
    public decimal? JournalAmount { get; private set; }

    /// <summary>
    /// مبلغ اليومية بالعملة الأجنبية
    /// </summary>
    public decimal? JournalAmountForeign { get; private set; }

    /// <summary>
    /// سعر الحساب
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// رقم المجموعة الكامل
    /// </summary>
    public string GroupNumberFull { get; private set; }

    /// <summary>
    /// رقم النقدية/البنك
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
    /// رقم فرع المستند
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// ملاحظة
    /// </summary>
    public string Note { get; private set; }

    /// <summary>
    /// تسلسل المستند المرجعي
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// رقم السجل المرجعي
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

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
    /// نوع حساب الضريبة
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// نسبة الضريبة
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    /// <summary>
    /// مبلغ الضريبة
    /// </summary>
    public decimal? TaxAmount { get; private set; }

    /// <summary>
    /// نوع مستند الساعات المرجعي
    /// </summary>
    public decimal? HoursDocumentTypeRef { get; private set; }

    /// <summary>
    /// تسلسل مستند الساعات المرجعي
    /// </summary>
    public decimal? HoursDocumentSerialRef { get; private set; }

    /// <summary>
    /// رقم مستند الساعات المرجعي
    /// </summary>
    public decimal? HoursDocumentNumberReference { get; private set; }

    /// <summary>
    /// حقل إضافي 1
    /// </summary>
    public string Field1Alt { get; private set; }

    /// <summary>
    /// حقل إضافي 2
    /// </summary>
    public string Field2Alt { get; private set; }

    /// <summary>
    /// حقل إضافي 3
    /// </summary>
    public string Field3Alt { get; private set; }

    /// <summary>
    /// حقل إضافي 4
    /// </summary>
    public string Field4Alt { get; private set; }

    /// <summary>
    /// حقل إضافي 5
    /// </summary>
    public string Field5Alt { get; private set; }

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
    /// علاقة مرجعية مع مندوب المبيعات (متعدد إلى واحد)
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع المحصل (متعدد إلى واحد)
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع مركز التكلفة (متعدد إلى واحد)
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع العميل (متعدد إلى واحد)
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع تفاصيل السندات (متعدد إلى واحد)
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع خطاب الاعتماد (متعدد إلى واحد)
    /// </summary>
    public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع قيد اليومية الرئيسي (متعدد إلى واحد)
    /// </summary>
    public JournalVoucherMaster JournalVoucherMaster { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
