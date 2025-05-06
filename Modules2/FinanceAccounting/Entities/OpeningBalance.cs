using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;

using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;
namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// OpeningBalance Entity
/// </summary>
public class OpeningBalance : Entity<OpeningBalanceId>
{

    private OpeningBalance() { }

    public OpeningBalance(OpeningBalanceId id, decimal? docSequence)
    {
        Id = id;
        DocSequence = docSequence;
    }

    /// <summary>
    /// The unique identifier for the OpeningBalance
    /// المعرف الفريد لـ OpeningBalance
    /// </summary>
    public OpeningBalanceId Id { get; private set; }

    /// <summary>
    /// AccountDetailCode of the OpeningBalance
    /// AccountDetailCode الخاص بـ OpeningBalance
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailSubCode of the OpeningBalance
    /// AccountDetailSubCode الخاص بـ OpeningBalance
    /// </summary>
    public string AccountDetailSubCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the OpeningBalance
    /// AccountDetailType الخاص بـ OpeningBalance
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// FromCostCenterCode of the OpeningBalance
    /// FromCostCenterCode الخاص بـ OpeningBalance
    /// </summary>
    public string FromCostCenterCode { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the OpeningBalance
    /// LetterCreditNumber الخاص بـ OpeningBalance
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// ProjectNumber of the OpeningBalance
    /// ProjectNumber الخاص بـ OpeningBalance
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// RepCode of the OpeningBalance
    /// RepCode الخاص بـ OpeningBalance
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// JournalAmount of the OpeningBalance
    /// JournalAmount الخاص بـ OpeningBalance
    /// </summary>
    public decimal? JournalAmount { get; private set; }

    /// <summary>
    /// JournalAmountForeign of the OpeningBalance
    /// JournalAmountForeign الخاص بـ OpeningBalance
    /// </summary>
    public decimal? JournalAmountForeign { get; private set; }

    /// <summary>
    /// AccountRate of the OpeningBalance
    /// AccountRate الخاص بـ OpeningBalance
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// VerifyFlag of the OpeningBalance
    /// VerifyFlag الخاص بـ OpeningBalance
    /// </summary>
    public decimal? VerifyFlag { get; private set; }

    /// <summary>
    /// ObjectPaymentYear of the OpeningBalance
    /// ObjectPaymentYear الخاص بـ OpeningBalance
    /// </summary>
    public decimal? ObjectPaymentYear { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the OpeningBalance
    /// ColumnNumberShort الخاص بـ OpeningBalance
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// DocSequence of the OpeningBalance
    /// DocSequence الخاص بـ OpeningBalance
    /// </summary>
    public decimal? DocSequence { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the OpeningBalance
    /// ExternalPostFlag الخاص بـ OpeningBalance
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// ValueDate of the OpeningBalance
    /// ValueDate الخاص بـ OpeningBalance
    /// </summary>
    public DateTime? ValueDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the OpeningBalance
    /// CompanyNumberShort الخاص بـ OpeningBalance
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the OpeningBalance
    /// BranchNumber الخاص بـ OpeningBalance
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the OpeningBalance
    /// BranchYear الخاص بـ OpeningBalance
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the OpeningBalance
    /// BranchUser الخاص بـ OpeningBalance
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ReferenceNumber of the OpeningBalance
    /// ReferenceNumber الخاص بـ OpeningBalance
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// AccountDescriptionShort of the OpeningBalance
    /// AccountDescriptionShort الخاص بـ OpeningBalance
    /// </summary>
    public string AccountDescriptionShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Branch Branch { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
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

