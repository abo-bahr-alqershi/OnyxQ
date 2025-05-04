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
/// الكلاس يمثل تفاصيل السندات المالية ويحتوي على جميع خصائص العمليات المالية التفصيلية للسند
/// </summary>
public class VoucherDetail : Entity<VoucherDetailId>
{

    private VoucherDetail() { }

    public VoucherDetail(VoucherDetailId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// معرف فريد لتفاصيل السند
    /// </summary>
    public VoucherDetailId Id { get; private set; }

    /// <summary>
    /// نوع السند الكامل
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
    /// كود تفاصيل الحساب
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب الفرعي
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// كود نهاية تفاصيل الحساب الفرعي
    /// </summary>
    public string AccountDetailSubEndCode { get; private set; }

    /// <summary>
    /// كود العمولة الفرعية للمدين
    /// </summary>
    public string AccountDetailSubDrCommissionCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// وصف الحساب
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// مبلغ الحساب
    /// </summary>
    public decimal? AccountAmount { get; private set; }

    /// <summary>
    /// مبلغ الحساب بالعملة الأجنبية
    /// </summary>
    public decimal? AccountAmountForeign { get; private set; }

    /// <summary>
    /// سعر الصرف
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// كود المندوب
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// رقم النقدية/البنك
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// رقم الشيك
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// تاريخ القيمة
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
    /// علم التأييد
    /// </summary>
    public decimal? Endrsmnt { get; private set; }

    /// <summary>
    /// رقم السند
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// رقم البنك
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// اسم البنك المختصر
    /// </summary>
    public string BankNameShort { get; private set; }

    /// <summary>
    /// رقم فرع البنك
    /// </summary>
    public decimal? BankBranchNumber { get; private set; }

    /// <summary>
    /// كود نهاية الحساب
    /// </summary>
    public string AccountCodeEnd { get; private set; }

    /// <summary>
    /// كود نهاية العميل
    /// </summary>
    public string CCodeEnd { get; private set; }

    /// <summary>
    /// كود نهاية المورد
    /// </summary>
    public string VendorCodeEnd { get; private set; }

    /// <summary>
    /// سبب الإرجاع
    /// </summary>
    public string ReturnReason { get; private set; }

    /// <summary>
    /// رقم CI
    /// </summary>
    public decimal? CiNumber { get; private set; }

    /// <summary>
    /// تسلسل CI
    /// </summary>
    public decimal? CiSerial { get; private set; }

    /// <summary>
    /// رقم دفع الساعات
    /// </summary>
    public decimal? HoursPayNumber { get; private set; }

    /// <summary>
    /// رقم K
    /// </summary>
    public decimal? KNumber { get; private set; }

    /// <summary>
    /// تسلسل K
    /// </summary>
    public decimal? KSerial { get; private set; }

    /// <summary>
    /// رقم الفاتورة
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// تسلسل الفاتورة
    /// </summary>
    public decimal? BillSerial { get; private set; }

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
    /// مبلغ عمولة المندوب
    /// </summary>
    public decimal? RepCommissionAmount { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// رقم اتصال السند
    /// </summary>
    public decimal? ConnectionVNumber { get; private set; }

    /// <summary>
    /// تسلسل اتصال السند
    /// </summary>
    public decimal? ConnectionVSerial { get; private set; }

    /// <summary>
    /// مبلغ اتصال السند
    /// </summary>
    public decimal? ConnectionVAmount { get; private set; }

    /// <summary>
    /// علم الترحيل الخارجي
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// تاريخ الفوترة
    /// </summary>
    public DateTime? BillmentDate { get; private set; }

    /// <summary>
    /// تسلسل المستند المرجعي
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// تسلسل المستند
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// رقم أمين الصندوق
    /// </summary>
    public decimal? CashierNumber { get; private set; }

    /// <summary>
    /// ملاحظة
    /// </summary>
    public string Note { get; private set; }

    /// <summary>
    /// كود عمولة المدين
    /// </summary>
    public string AccountDrCommissionCode { get; private set; }

    /// <summary>
    /// كود تفاصيل عمولة المدين
    /// </summary>
    public string AccountDetailDrCommissionCode { get; private set; }

    /// <summary>
    /// نوع تفاصيل عمولة المدين
    /// </summary>
    public decimal? AccountDetailTypeDrCommission { get; private set; }

    /// <summary>
    /// مبلغ آخر محلي
    /// </summary>
    public decimal? OtherAmountLocal { get; private set; }

    /// <summary>
    /// مبلغ آخر بالعملة الأجنبية
    /// </summary>
    public decimal? OtherAmountForeign { get; private set; }

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
    /// نوع تفاصيل الحساب النهائي
    /// </summary>
    public decimal? AccountDetailTypeEnd { get; private set; }

    /// <summary>
    /// كود تفاصيل الحساب النهائي
    /// </summary>
    public string AccountDetailEndCode { get; private set; }

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
    /// رقم فرع المستند
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

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
    /// تاريخ بداية العقد
    /// </summary>
    public DateTime? FContractDate { get; private set; }

    /// <summary>
    /// تاريخ نهاية العقد
    /// </summary>
    public DateTime? TContractDate { get; private set; }

    /// <summary>
    /// تاريخ بداية العقد هجري
    /// </summary>
    public string FContractDateHijri { get; private set; }

    /// <summary>
    /// تاريخ نهاية العقد هجري
    /// </summary>
    public string TContractDateHijri { get; private set; }

    /// <summary>
    /// رقم بطاقة الائتمان
    /// </summary>
    public decimal? CreditCardNumber { get; private set; }

    /// <summary>
    /// خطاب استلام حساب الائتمان
    /// </summary>
    public string CreditAccountReceiptLetter { get; private set; }

    /// <summary>
    /// حساب عمولة الائتمان
    /// </summary>
    public string CreditCommissionAccount { get; private set; }

    /// <summary>
    /// نوع حساب عمولة الائتمان
    /// </summary>
    public decimal? CreditCommissionCalculationType { get; private set; }

    /// <summary>
    /// نسبة عمولة الائتمان
    /// </summary>
    public decimal? CreditCommissionPercent { get; private set; }

    /// <summary>
    /// نسبة ضريبة عمولة الائتمان
    /// </summary>
    public decimal? CreditVatCommissionPercent { get; private set; }

    /// <summary>
    /// فترة استحقاق الائتمان
    /// </summary>
    public decimal? CreditDuePeriod { get; private set; }

    /// <summary>
    /// عدد عمليات الائتمان
    /// </summary>
    public decimal? CreditProcessesNumber { get; private set; }

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
    /// مبلغ عمولة الائتمان المحلي
    /// </summary>
    public decimal? CreditCommissionAmountLocal { get; private set; }

    /// <summary>
    /// مبلغ ضريبة عمولة الائتمان المحلي
    /// </summary>
    public decimal? CreditVatCommissionAmountLocal { get; private set; }

    /// <summary>
    /// مبلغ السحب المحلي للائتمان
    /// </summary>
    public decimal? CreditWithdrawAmountLocal { get; private set; }

    /// <summary>
    /// نوع بطاقة الائتمان
    /// </summary>
    public decimal? CreditCardType { get; private set; }

    /// <summary>
    /// تاريخ التأييد
    /// </summary>
    public DateTime? EndrsmntDate { get; private set; }

    /// <summary>
    /// حالة ترحيل التأييد
    /// </summary>
    public decimal? EndrsmntPost { get; private set; }

    /// <summary>
    /// رقم مستخدم ترحيل التأييد
    /// </summary>
    public decimal? EndrsmntPostUId { get; private set; }

    /// <summary>
    /// رقم مستخدم إلغاء ترحيل التأييد
    /// </summary>
    public decimal? EndrsmntUnpostUId { get; private set; }

    /// <summary>
    /// تاريخ ترحيل التأييد
    /// </summary>
    public DateTime? EndrsmntPostDate { get; private set; }

    /// <summary>
    /// تاريخ إلغاء ترحيل التأييد
    /// </summary>
    public DateTime? EndrsmntUnpostDate { get; private set; }

    /// <summary>
    /// رقم مرجع تدقيق التأييد
    /// </summary>
    public decimal? EndrsmntAuditRefUId { get; private set; }

    /// <summary>
    /// مرجع تدقيق التأييد
    /// </summary>
    public decimal? EndrsmntAuditRef { get; private set; }

    /// <summary>
    /// وصف مرجع تدقيق التأييد
    /// </summary>
    public string EndrsmntAuditRefDesc { get; private set; }

    /// <summary>
    /// تاريخ مرجع تدقيق التأييد (إلغاء)
    /// </summary>
    public DateTime? EndrsmntUauditRefDate { get; private set; }

    /// <summary>
    /// تاريخ مرجع تدقيق التأييد
    /// </summary>
    public DateTime? EndrsmntAuditRefDate { get; private set; }

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
    /// مبلغ عمولة الائتمان
    /// </summary>
    public decimal? CreditCommissionAmount { get; private set; }

    /// <summary>
    /// مبلغ ضريبة عمولة الائتمان
    /// </summary>
    public decimal? CreditVatCommissionAmount { get; private set; }

    /// <summary>
    /// عملة حساب العمولة القصوى للائتمان
    /// </summary>
    public string CreditAccountCurrencyMaxCommission { get; private set; }

    /// <summary>
    /// مبلغ السحب للائتمان
    /// </summary>
    public decimal? CreditWithdrawAmount { get; private set; }

    /// <summary>
    /// مبلغ العمولة القصوى لعملية الائتمان
    /// </summary>
    public decimal? CreditProcessMaxCommissionAmount { get; private set; }

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
    /// علاقة مرجعية مع مركز التكلفة (متعدد إلى واحد)
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع العميل (متعدد إلى واحد)
    /// </summary>
    public Customer Customer { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع السند الرئيسي (متعدد إلى واحد)
    /// </summary>
    public Voucher Voucher { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع تفاصيل السند (متعدد إلى واحد)
    /// </summary>
    public VoucherDetails VoucherDetails { get; private set; }
    /// <summary>
    /// علاقة مرجعية مع خطاب الاعتماد (متعدد إلى واحد)
    /// </summary>
    public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
