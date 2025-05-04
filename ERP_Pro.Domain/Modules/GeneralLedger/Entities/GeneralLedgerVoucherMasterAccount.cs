using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerVoucherMasterAccount Entity
/// </summary>
public class GeneralLedgerVoucherMasterAccount : Entity<GeneralLedgerVoucherMasterAccountId>
{

    private GeneralLedgerVoucherMasterAccount() { }

    public GeneralLedgerVoucherMasterAccount(GeneralLedgerVoucherMasterAccountId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerVoucherMasterAccount
    /// المعرف الفريد لـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public GeneralLedgerVoucherMasterAccountId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerVoucherMasterAccount
    /// RecordNumber الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// VoucherType of the GeneralLedgerVoucherMasterAccount
    /// VoucherType الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? VoucherType { get; private set; }

    /// <summary>
    /// VoucherPayType of the GeneralLedgerVoucherMasterAccount
    /// VoucherPayType الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? VoucherPayType { get; private set; }

    /// <summary>
    /// CashNumber of the GeneralLedgerVoucherMasterAccount
    /// CashNumber الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerVoucherMasterAccount
    /// DocNo الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerVoucherMasterAccount
    /// AccountDetailCode الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the GeneralLedgerVoucherMasterAccount
    /// AccountDetailSubCode الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerVoucherMasterAccount
    /// AccountDetailType الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CurRate of the GeneralLedgerVoucherMasterAccount
    /// CurRate الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? CurRate { get; private set; }

    /// <summary>
    /// AmountLocal of the GeneralLedgerVoucherMasterAccount
    /// AmountLocal الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? AmountLocal { get; private set; }

    /// <summary>
    /// AmountForeign of the GeneralLedgerVoucherMasterAccount
    /// AmountForeign الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// DocDsc of the GeneralLedgerVoucherMasterAccount
    /// DocDsc الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public string DocDsc { get; private set; }

    /// <summary>
    /// DocSeq of the GeneralLedgerVoucherMasterAccount
    /// DocSeq الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// DocBrnNo of the GeneralLedgerVoucherMasterAccount
    /// DocBrnNo الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerVoucherMasterAccount
    /// CompanyNumberShort الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerVoucherMasterAccount
    /// BranchNumber الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerVoucherMasterAccount
    /// BranchYear الخاص بـ GeneralLedgerVoucherMasterAccount
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerVoucherMasterAccount
    /// BranchUser الخاص بـ GeneralLedgerVoucherMasterAccount
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
    public Salesman Salesman { get; private set; }
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
    public Voucher Voucher { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
