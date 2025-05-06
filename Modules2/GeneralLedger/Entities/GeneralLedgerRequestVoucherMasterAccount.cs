using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FormsSurveys.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerRequestVoucherMasterAccount Entity
/// </summary>
public class GeneralLedgerRequestVoucherMasterAccount : Entity<GeneralLedgerRequestVoucherMasterAccountId>
{

    private GeneralLedgerRequestVoucherMasterAccount() { }

    public GeneralLedgerRequestVoucherMasterAccount(GeneralLedgerRequestVoucherMasterAccountId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestVoucherMasterAccount
    /// المعرف الفريد لـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public GeneralLedgerRequestVoucherMasterAccountId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerRequestVoucherMasterAccount
    /// RecordNumber الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// VoucherType of the GeneralLedgerRequestVoucherMasterAccount
    /// VoucherType الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? VoucherType { get; private set; }

    /// <summary>
    /// VoucherPayType of the GeneralLedgerRequestVoucherMasterAccount
    /// VoucherPayType الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? VoucherPayType { get; private set; }

    /// <summary>
    /// CashNumber of the GeneralLedgerRequestVoucherMasterAccount
    /// CashNumber الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerRequestVoucherMasterAccount
    /// DocNo الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerRequestVoucherMasterAccount
    /// AccountDetailCode الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the GeneralLedgerRequestVoucherMasterAccount
    /// AccountDetailSubCode الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerRequestVoucherMasterAccount
    /// AccountDetailType الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CurRate of the GeneralLedgerRequestVoucherMasterAccount
    /// CurRate الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// AmountLocal of the GeneralLedgerRequestVoucherMasterAccount
    /// AmountLocal الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// AmountForeign of the GeneralLedgerRequestVoucherMasterAccount
    /// AmountForeign الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// DocDsc of the GeneralLedgerRequestVoucherMasterAccount
    /// DocDsc الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// DocSeq of the GeneralLedgerRequestVoucherMasterAccount
    /// DocSeq الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// DocBrnNo of the GeneralLedgerRequestVoucherMasterAccount
    /// DocBrnNo الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerRequestVoucherMasterAccount
    /// CompanyNumberShort الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerRequestVoucherMasterAccount
    /// BranchNumber الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerRequestVoucherMasterAccount
    /// BranchYear الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerRequestVoucherMasterAccount
    /// BranchUser الخاص بـ GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public decimal? BranchUser { get; private set; }

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
    public RequestVoucherMaster RequestVoucherMaster { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Salesman Salesman { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Collector Collector { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

