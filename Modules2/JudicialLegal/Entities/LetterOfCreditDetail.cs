using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.JudicialLegal.ValueObjects;
namespace ERP_Pro.Domain.ERP.JudicialLegal.Entities
{
/// <summary>
/// LetterOfCreditDetail Entity
/// </summary>
public class LetterOfCreditDetail : Entity<LetterOfCreditDetailId>
{

    private LetterOfCreditDetail() { }

    public LetterOfCreditDetail(LetterOfCreditDetailId id, decimal? recordNumber)
    {
        Id = id;
        RecordNumber = recordNumber;
    }

    /// <summary>
    /// The unique identifier for the LetterOfCreditDetail
    /// المعرف الفريد لـ LetterOfCreditDetail
    /// </summary>
    public LetterOfCreditDetailId Id { get; private set; }

    /// <summary>
    /// LetterCreditSerial of the LetterOfCreditDetail
    /// LetterCreditSerial الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? LetterCreditSerial { get; private set; }

    /// <summary>
    /// AccountDetailCode of the LetterOfCreditDetail
    /// AccountDetailCode الخاص بـ LetterOfCreditDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the LetterOfCreditDetail
    /// AccountDetailType الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// LetterCreditExpenseAmount of the LetterOfCreditDetail
    /// LetterCreditExpenseAmount الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? LetterCreditExpenseAmount { get; private set; }

    /// <summary>
    /// LetterCreditExpenseAmountForeign of the LetterOfCreditDetail
    /// LetterCreditExpenseAmountForeign الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? LetterCreditExpenseAmountForeign { get; private set; }

    /// <summary>
    /// LetterCreditExpenseRate of the LetterOfCreditDetail
    /// LetterCreditExpenseRate الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? LetterCreditExpenseRate { get; private set; }

    /// <summary>
    /// LetterCreditExpenseGeneral of the LetterOfCreditDetail
    /// LetterCreditExpenseGeneral الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? LetterCreditExpenseGeneral { get; private set; }

    /// <summary>
    /// RecordNumber of the LetterOfCreditDetail
    /// RecordNumber الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the LetterOfCreditDetail
    /// CompanyNumberShort الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the LetterOfCreditDetail
    /// BranchNumber الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchUser of the LetterOfCreditDetail
    /// BranchUser الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// BranchYear of the LetterOfCreditDetail
    /// BranchYear الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// AmountType of the LetterOfCreditDetail
    /// AmountType الخاص بـ LetterOfCreditDetail
    /// </summary>
    public decimal? AmountType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
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

