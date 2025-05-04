using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.JudicialLegal.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// ExchangeCurrencyDetail Entity
/// </summary>
public class ExchangeCurrencyDetail : Entity<ExchangeCurrencyDetailId>
{
    private ExchangeCurrencyDetail() { }

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
    /// DocSrl of the ExchangeCurrencyDetail
    /// DocSrl الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? DocSrl { get; private set; }

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
    /// AccountCode of the ExchangeCurrencyDetail
    /// AccountCode الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string AccountCode { get; private set; }

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
    /// CurCode of the ExchangeCurrencyDetail
    /// CurCode الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the ExchangeCurrencyDetail
    /// CostCenterCode الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the ExchangeCurrencyDetail
    /// ProjectNumber الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the ExchangeCurrencyDetail
    /// ActivityNumber الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

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
    /// LetterCreditNumber of the ExchangeCurrencyDetail
    /// LetterCreditNumber الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// RepCode of the ExchangeCurrencyDetail
    /// RepCode الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the ExchangeCurrencyDetail
    /// ColumnNumberShort الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the ExchangeCurrencyDetail
    /// ExternalPostFlag الخاص بـ ExchangeCurrencyDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Collector
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to LetterOfCreditMaster
    /// </summary>
    public LetterOfCreditMaster LetterOfCreditMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to ExchangeCurrencyMaster
    /// </summary>
    public ExchangeCurrencyMaster ExchangeCurrencyMaster { get; private set; }
    #endregion
}
}
