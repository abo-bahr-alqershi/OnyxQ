using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerRequestExchangeCurrencyDetail Entity
/// </summary>
public class GeneralLedgerRequestExchangeCurrencyDetail : Entity<GeneralLedgerRequestExchangeCurrencyDetailId>
{

    private GeneralLedgerRequestExchangeCurrencyDetail() { }

    public GeneralLedgerRequestExchangeCurrencyDetail(GeneralLedgerRequestExchangeCurrencyDetailId id, decimal? docSq)
    {
        Id = id;
        DocSq = docSq;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestExchangeCurrencyDetail
    /// المعرف الفريد لـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public GeneralLedgerRequestExchangeCurrencyDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerRequestExchangeCurrencyDetail
    /// DocNo الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// TypeNumberShort of the GeneralLedgerRequestExchangeCurrencyDetail
    /// TypeNumberShort الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? TypeNumberShort { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerRequestExchangeCurrencyDetail
    /// AccountDetailCode الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerRequestExchangeCurrencyDetail
    /// AccountDetailType الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// DocDsc of the GeneralLedgerRequestExchangeCurrencyDetail
    /// DocDsc الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// AmountLocal of the GeneralLedgerRequestExchangeCurrencyDetail
    /// AmountLocal الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// AmountForeign of the GeneralLedgerRequestExchangeCurrencyDetail
    /// AmountForeign الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// CurRate of the GeneralLedgerRequestExchangeCurrencyDetail
    /// CurRate الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerRequestExchangeCurrencyDetail
    /// ReferenceNumber الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerRequestExchangeCurrencyDetail
    /// RecordNumber الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocSq of the GeneralLedgerRequestExchangeCurrencyDetail
    /// DocSq الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? DocSq { get; private set; }

    /// <summary>
    /// DocTypRef of the GeneralLedgerRequestExchangeCurrencyDetail
    /// DocTypRef الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocJvTypRef of the GeneralLedgerRequestExchangeCurrencyDetail
    /// DocJvTypRef الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? DocJvTypRef { get; private set; }

    /// <summary>
    /// DocNoRef of the GeneralLedgerRequestExchangeCurrencyDetail
    /// DocNoRef الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the GeneralLedgerRequestExchangeCurrencyDetail
    /// DocSrlRef الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// DocSqRef of the GeneralLedgerRequestExchangeCurrencyDetail
    /// DocSqRef الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? DocSqRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerRequestExchangeCurrencyDetail
    /// CompanyNumberShort الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerRequestExchangeCurrencyDetail
    /// BranchNumber الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerRequestExchangeCurrencyDetail
    /// BranchYear الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerRequestExchangeCurrencyDetail
    /// BranchUser الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// DocBrnNo of the GeneralLedgerRequestExchangeCurrencyDetail
    /// DocBrnNo الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// NoteNumber of the GeneralLedgerRequestExchangeCurrencyDetail
    /// NoteNumber الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public string NoteNumber { get; private set; }

    /// <summary>
    /// RepCode of the GeneralLedgerRequestExchangeCurrencyDetail
    /// RepCode الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the GeneralLedgerRequestExchangeCurrencyDetail
    /// AccountDetailSubCode الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the GeneralLedgerRequestExchangeCurrencyDetail
    /// ExternalPostFlag الخاص بـ GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public GeneralLedgerRequestExchangeCurrencyMaster GeneralLedgerRequestExchangeCurrencyMaster { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

