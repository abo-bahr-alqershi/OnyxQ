using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل الترحيل المحاسبي ويحتوي على جميع خصائص العمليات المحاسبية التفصيلية
/// </summary>
public class PostDetail : Entity<PostDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<Branch> _branch = new List<Branch>();
    private readonly List<PeriodDetail> _periodDetail = new List<PeriodDetail>();
    private readonly List<PostMaster> _postMaster = new List<PostMaster>();
    private readonly List<AccountCurrency> _accountCurrency = new List<AccountCurrency>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<LetterOfCreditMaster> _letterOfCreditMaster = new List<LetterOfCreditMaster>();

    private PostDetail() { }

    public PostDetail(PostDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لتفاصيل الترحيل
    /// </summary>
    public PostDetailId Id { get; private set; }

    /// <summary>
    /// نوع المستند
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// نوع قيد اليومية الكامل
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// كود المستودع
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

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
    /// نوع تفاصيل الحساب
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// مبلغ المدين
    /// </summary>
    public decimal? DrAmt { get; private set; }

    /// <summary>
    /// مبلغ الدائن
    /// </summary>
    public decimal? CreditAmount { get; private set; }

    /// <summary>
    /// مبلغ المدين بالعملة الأجنبية
    /// </summary>
    public decimal? DrAmtF { get; private set; }

    /// <summary>
    /// مبلغ الدائن بالعملة الأجنبية المختصر
    /// </summary>
    public decimal? CreditAmountForeignShort { get; private set; }

    /// <summary>
    /// المبلغ
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// المبلغ بالعملة الأجنبية
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// تاريخ المستند
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// تاريخ استحقاق المستند
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// وصف المستند
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// سنة المستند
    /// </summary>
    public decimal? DYear { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// حالة الترحيل
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// حالة الإغلاق
    /// </summary>
    public decimal? DocClose { get; private set; }

    /// <summary>
    /// علم إغلاق الفاتورة
    /// </summary>
    public decimal? InvoiceCloseFlag { get; private set; }

    /// <summary>
    /// رصيد النقدية قبل العملية
    /// </summary>
    public decimal? CashBalanceBefore { get; private set; }

    /// <summary>
    /// رصيد النقدية بعد العملية
    /// </summary>
    public decimal? CashBalanceAfter { get; private set; }

    /// <summary>
    /// كود العميل
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// كود المورد
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// كود العميل/المورد
    /// </summary>
    public string CVCode { get; private set; }

    /// <summary>
    /// كود المورد للعميل
    /// </summary>
    public string VendorCCode { get; private set; }

    /// <summary>
    /// رقم العمود المختصر
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// كود المندوب
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// نوع بطاقة الائتمان الكامل
    /// </summary>
    public decimal? CreditCardTypeFull { get; private set; }

    /// <summary>
    /// كود المنطقة
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// رقم التسلسل الهرمي
    /// </summary>
    public decimal? HierarchyNumber { get; private set; }

    /// <summary>
    /// رقم أمر العمل
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// تسلسل أمر العمل
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// رقم الشيك
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// رقم السند
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// علم تقييم الشيك
    /// </summary>
    public decimal? ChequeValuedFlag { get; private set; }

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
    /// تسلسل المستند
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// علم الترحيل الخارجي
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// كود الضامن
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// كود مجموعة المستودعات
    /// </summary>
    public decimal? WarehouseGroupCode { get; private set; }

    /// <summary>
    /// اسم الجهاز الطرفي
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// نوع التقسيط
    /// </summary>
    public decimal? InstallType { get; private set; }

    /// <summary>
    /// سنة دفع مستند الحركة المختصر
    /// </summary>
    public decimal? MoveDocumentPaymentYearShort { get; private set; }

    /// <summary>
    /// كود مركز التكلفة المصدر
    /// </summary>
    public string FromCostCenterCode { get; private set; }

    /// <summary>
    /// رقم فرع المستند
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// رقم أمين الصندوق
    /// </summary>
    public decimal? CashierNumber { get; private set; }

    /// <summary>
    /// رقم شركة التأمين
    /// </summary>
    public decimal? InsuranceCompanyNumber { get; private set; }

    /// <summary>
    /// رقم منفعة التأمين
    /// </summary>
    public decimal? InsuranceBenefitNumber { get; private set; }

    /// <summary>
    /// رقم بطاقة التأمين
    /// </summary>
    public string InsuranceCardNumber { get; private set; }

    /// <summary>
    /// رقم بطاقة التأمين العائلية
    /// </summary>
    public string InsuranceCardNumberFamily { get; private set; }

    /// <summary>
    /// نوع علاقة التأمين
    /// </summary>
    public decimal? InsuranceRelationType { get; private set; }

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
    /// علم التأكيد
    /// </summary>
    public decimal? ConfirmFlag { get; private set; }

    /// <summary>
    /// وصف التأكيد
    /// </summary>
    public string ConfirmDescription { get; private set; }

    /// <summary>
    /// رقم مستخدم التأكيد
    /// </summary>
    public decimal? ConfirmUserId { get; private set; }

    /// <summary>
    /// تاريخ التأكيد
    /// </summary>
    public DateTime? ConfirmDate { get; private set; }

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
    /// تسلسل المستند المرجعي
    /// </summary>
    public decimal? DocSequenceRef { get; private set; }

    /// <summary>
    /// رقم السجل المرجعي
    /// </summary>
    public decimal? RecordNumberReference { get; private set; }

    /// <summary>
    /// رقم بطاقة الائتمان
    /// </summary>
    public decimal? CreditCardNumber { get; private set; }

    /// <summary>
    /// رقم بطاقة الائتمان المرجعي
    /// </summary>
    public decimal? CreditCardNumberReference { get; private set; }

    /// <summary>
    /// وصف بطاقة الائتمان
    /// </summary>
    public string CreditCardDescription { get; private set; }

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
    /// رقم المستند اليدوي
    /// </summary>
    public string DocNoMnl { get; private set; }

    /// <summary>
    /// تاريخ المستند اليدوي
    /// </summary>
    public DateTime? DocDateMnl { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة تجميعية مع الأنشطة (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// علاقة تجميعية مع الفروع (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Branch> Branch => _branch;
    /// <summary>
    /// علاقة تجميعية مع تفاصيل الفترات (متعدد إلى متعدد)
    /// </summary>
    public ICollection<PeriodDetail> PeriodDetail => _periodDetail;
    /// <summary>
    /// علاقة تجميعية مع الترحيل الرئيسي (متعدد إلى متعدد)
    /// </summary>
    public ICollection<PostMaster> PostMaster => _postMaster;
    /// <summary>
    /// علاقة تجميعية مع عملات الحساب (متعدد إلى متعدد)
    /// </summary>
    public ICollection<AccountCurrency> AccountCurrency => _accountCurrency;
    /// <summary>
    /// علاقة تجميعية مع المشاريع (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// علاقة تجميعية مع مراكز التكلفة (متعدد إلى متعدد)
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    /// <summary>
    /// علاقة تجميعية مع خطابات الاعتماد (متعدد إلى متعدد)
    /// </summary>
    public ICollection<LetterOfCreditMaster> LetterOfCreditMaster => _letterOfCreditMaster;
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
