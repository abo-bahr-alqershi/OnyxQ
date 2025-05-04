using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// BankAdjustmentDetail Entity
/// </summary>
public class BankAdjustmentDetail : Entity<BankAdjustmentDetailId>
{
    private BankAdjustmentDetail() { }

    /// <summary>
    /// The unique identifier for the BankAdjustmentDetail
    /// المعرف الفريد لـ BankAdjustmentDetail
    /// </summary>
    public BankAdjustmentDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the BankAdjustmentDetail
    /// DocNo الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the BankAdjustmentDetail
    /// DocSer الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// BankNumber of the BankAdjustmentDetail
    /// BankNumber الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// AccountCode of the BankAdjustmentDetail
    /// AccountCode الخاص بـ BankAdjustmentDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the BankAdjustmentDetail
    /// AccountDetailCode الخاص بـ BankAdjustmentDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the BankAdjustmentDetail
    /// AccountDetailType الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the BankAdjustmentDetail
    /// AccountCurrency الخاص بـ BankAdjustmentDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// BranchBankNumber of the BankAdjustmentDetail
    /// BranchBankNumber الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? BranchBankNumber { get; private set; }

    /// <summary>
    /// BankBalance of the BankAdjustmentDetail
    /// BankBalance الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? BankBalance { get; private set; }

    /// <summary>
    /// DocDesc of the BankAdjustmentDetail
    /// DocDesc الخاص بـ BankAdjustmentDetail
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// JournalAmount of the BankAdjustmentDetail
    /// JournalAmount الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? JournalAmount { get; private set; }

    /// <summary>
    /// JournalAmountForeign of the BankAdjustmentDetail
    /// JournalAmountForeign الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? JournalAmountForeign { get; private set; }

    /// <summary>
    /// RecordNumber of the BankAdjustmentDetail
    /// RecordNumber الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BankAdjustmentDetail
    /// CompanyNumberShort الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BankAdjustmentDetail
    /// BranchNumber الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BankAdjustmentDetail
    /// BranchYear الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BankAdjustmentDetail
    /// BranchUser الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CostCenterCode of the BankAdjustmentDetail
    /// CostCenterCode الخاص بـ BankAdjustmentDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the BankAdjustmentDetail
    /// ProjectNumber الخاص بـ BankAdjustmentDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the BankAdjustmentDetail
    /// ActivityNumber الخاص بـ BankAdjustmentDetail
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the BankAdjustmentDetail
    /// ReferenceNumber الخاص بـ BankAdjustmentDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocBrnNo of the BankAdjustmentDetail
    /// DocBrnNo الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? DocBrnNo { get; private set; }

    /// <summary>
    /// DocTypRef of the BankAdjustmentDetail
    /// DocTypRef الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? DocTypRef { get; private set; }

    /// <summary>
    /// DocJvTypRef of the BankAdjustmentDetail
    /// DocJvTypRef الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? DocJvTypRef { get; private set; }

    /// <summary>
    /// DocNoRef of the BankAdjustmentDetail
    /// DocNoRef الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSrlRef of the BankAdjustmentDetail
    /// DocSrlRef الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? DocSrlRef { get; private set; }

    /// <summary>
    /// DocSqRef of the BankAdjustmentDetail
    /// DocSqRef الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? DocSqRef { get; private set; }

    /// <summary>
    /// DocSq of the BankAdjustmentDetail
    /// DocSq الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? DocSq { get; private set; }

    /// <summary>
    /// ExchangeRate of the BankAdjustmentDetail
    /// ExchangeRate الخاص بـ BankAdjustmentDetail
    /// </summary>
    public decimal? ExchangeRate { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the BankAdjustmentDetail
    /// AccountDetailSubCode الخاص بـ BankAdjustmentDetail
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to AccountCurrency
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    /// <summary>
    /// ManyToOne relationship to BankAdjustmentMaster
    /// </summary>
    public BankAdjustmentMaster BankAdjustmentMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CashAtBankDetail
    /// </summary>
    public CashAtBankDetail CashAtBankDetail { get; private set; }
    #endregion
}
}
