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
/// ExchangeCurrencyDetail Entity
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
    /// The unique identifier for the ExchangeCurrencyDetail
    /// المعرف الفريد لـ ExchangeCurrencyDetail
    /// </summary>
    public ExchangeCurrencyDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the ExchangeCurrencyDetail
    /// DocNo الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// TypeNumberShort of the ExchangeCurrencyDetail
    /// TypeNumberShort الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// CashBankNumber of the ExchangeCurrencyDetail
    /// CashBankNumber الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// AccountDetailCode of the ExchangeCurrencyDetail
    /// AccountDetailCode الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the ExchangeCurrencyDetail
    /// AccountDetailSubCode الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the ExchangeCurrencyDetail
    /// AccountDetailType الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// DocDsc of the ExchangeCurrencyDetail
    /// DocDsc الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// AmountLocal of the ExchangeCurrencyDetail
    /// AmountLocal الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// AmountForeign of the ExchangeCurrencyDetail
    /// AmountForeign الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// CurRate of the ExchangeCurrencyDetail
    /// CurRate الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the ExchangeCurrencyDetail
    /// ReferenceNumber الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the ExchangeCurrencyDetail
    /// RecordNumber الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSq of the ExchangeCurrencyDetail
    /// DocSq الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? DocSq { get; private set; }

    /// <summary>
    /// DocTypRef of the ExchangeCurrencyDetail
    /// DocTypRef الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocJvTypRef of the ExchangeCurrencyDetail
    /// DocJvTypRef الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? DocJvTypRef { get; private set; }

    /// <summary>
    /// DocNoRef of the ExchangeCurrencyDetail
    /// DocNoRef الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the ExchangeCurrencyDetail
    /// DocSrlRef الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// DocSqRef of the ExchangeCurrencyDetail
    /// DocSqRef الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? DocSqRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ExchangeCurrencyDetail
    /// CompanyNumberShort الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ExchangeCurrencyDetail
    /// BranchNumber الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ExchangeCurrencyDetail
    /// BranchYear الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ExchangeCurrencyDetail
    /// BranchUser الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocBrnNo of the ExchangeCurrencyDetail
    /// DocBrnNo الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// NoteNumber of the ExchangeCurrencyDetail
    /// NoteNumber الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ExchangeCurrencyDetail
    /// ExternalPostFlag الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<AccountCurrency> AccountCurrency => _accountCurrency;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Salesman> Salesman => _salesman;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Collector> Collector => _collector;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<LetterOfCreditMaster> LetterOfCreditMaster => _letterOfCreditMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ExchangeCurrencyMaster> ExchangeCurrencyMaster => _exchangeCurrencyMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
