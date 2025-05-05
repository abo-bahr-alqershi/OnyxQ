using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;
namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// AccountTree Entity
/// </summary>
public class AccountTree : Entity<AccountTreeId>
{

    private AccountTree() { }

    public AccountTree(AccountTreeId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountTree
    /// المعرف الفريد لـ AccountTree
    /// </summary>
    public AccountTreeId Id { get; private set; }

    /// <summary>
    /// AccountName of the AccountTree
    /// AccountName الخاص بـ AccountTree
    /// </summary>
    public string AccountName { get; private set; }

    /// <summary>
    /// AccountNameEnglishFull of the AccountTree
    /// AccountNameEnglishFull الخاص بـ AccountTree
    /// </summary>
    public string AccountNameEnglishFull { get; private set; }

    /// <summary>
    /// AccountLevel of the AccountTree
    /// AccountLevel الخاص بـ AccountTree
    /// </summary>
    public decimal? AccountLevel { get; private set; }

    /// <summary>
    /// ParentAccountCode of the AccountTree
    /// ParentAccountCode الخاص بـ AccountTree
    /// </summary>
    public string ParentAccountCode { get; private set; }

    /// <summary>
    /// AccountSmCode of the AccountTree
    /// AccountSmCode الخاص بـ AccountTree
    /// </summary>
    public decimal? AccountSmCode { get; private set; }

    /// <summary>
    /// MainSubject of the AccountTree
    /// MainSubject الخاص بـ AccountTree
    /// </summary>
    public decimal? MainSubject { get; private set; }

    /// <summary>
    /// AccountGrouping of the AccountTree
    /// AccountGrouping الخاص بـ AccountTree
    /// </summary>
    public decimal? AccountGrouping { get; private set; }

    /// <summary>
    /// AccountReport of the AccountTree
    /// AccountReport الخاص بـ AccountTree
    /// </summary>
    public decimal? AccountReport { get; private set; }

    /// <summary>
    /// ClassNumber of the AccountTree
    /// ClassNumber الخاص بـ AccountTree
    /// </summary>
    public decimal? ClassNumber { get; private set; }

    /// <summary>
    /// AccountCloseFlag of the AccountTree
    /// AccountCloseFlag الخاص بـ AccountTree
    /// </summary>
    public decimal? AccountCloseFlag { get; private set; }

    /// <summary>
    /// AccountAnalysis of the AccountTree
    /// AccountAnalysis الخاص بـ AccountTree
    /// </summary>
    public decimal? AccountAnalysis { get; private set; }

    /// <summary>
    /// AccountDetailType of the AccountTree
    /// AccountDetailType الخاص بـ AccountTree
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// Dr of the AccountTree
    /// Dr الخاص بـ AccountTree
    /// </summary>
    public decimal? Dr { get; private set; }

    /// <summary>
    /// FlowType of the AccountTree
    /// FlowType الخاص بـ AccountTree
    /// </summary>
    public decimal? FlowType { get; private set; }

    /// <summary>
    /// AdvanceExpenseRevenueFlag of the AccountTree
    /// AdvanceExpenseRevenueFlag الخاص بـ AccountTree
    /// </summary>
    public decimal? AdvanceExpenseRevenueFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Account AccountAcTree { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

