using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل تفاصيل صرف العملات ويحتوي على جميع خصائص العمليات التفصيلية لصرف العملات
/// </summary>
public class ExchangeCurrencyDetail : Entity<ExchangeCurrencyDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<AccountCurrency> _accountCurrency = new List<AccountCurrency>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<Salesman> _salesman = new List<Salesman>();
    private readonly List<Collector> _collector = new List<Collector>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();
    private readonly List<LetterOfCreditMaster> _letterOfCreditMaster = new List<LetterOfCreditMaster>();
    private readonly List<ExchangeCurrencyMaster> _exchangeCurrencyMaster = new List<ExchangeCurrencyMaster>();

    private ExchangeCurrencyDetail() { }

    public ExchangeCurrencyDetail(ExchangeCurrencyDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// معرف فريد لتفاصيل صرف العملات
    /// </summary>
    public ExchangeCurrencyDetailId Id { get; private set; }

    /// <summary>
    /// رقم المستند
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// نوع العملية المختصر
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// رقم النقدية/البنك
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

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
    /// وصف المستند
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// المبلغ المحلي
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// المبلغ بالعملة الأجنبية
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// سعر العملة
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// رقم المرجع
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

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
    /// رقم فرع المستند
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// رقم السند
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// علم الترحيل الخارجي
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة تجميعية مع الأنشطة (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// علاقة تجميعية مع عملات الحساب (متعدد إلى متعدد)
    /// </summary>
    public ICollection<AccountCurrency> AccountCurrency => _accountCurrency;
    /// <summary>
    /// علاقة تجميعية مع المشاريع (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// علاقة تجميعية مع مندوبي المبيعات (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Salesman> Salesman => _salesman;
    /// <summary>
    /// علاقة تجميعية مع المحصلين (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Collector> Collector => _collector;
    /// <summary>
    /// علاقة تجميعية مع مراكز التكلفة (متعدد إلى متعدد)
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    /// <summary>
    /// علاقة تجميعية مع خطابات الاعتماد (متعدد إلى متعدد)
    /// </summary>
    public ICollection<LetterOfCreditMaster> LetterOfCreditMaster => _letterOfCreditMaster;
    /// <summary>
    /// علاقة تجميعية مع مستند صرف العملات الرئيسي (متعدد إلى متعدد)
    /// </summary>
    public ICollection<ExchangeCurrencyMaster> ExchangeCurrencyMaster => _exchangeCurrencyMaster;
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}

