using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// AccountsReceivableContractBatch Entity
/// </summary>
public class AccountsReceivableContractBatch : Entity<AccountsReceivableContractBatchId>
{

    private AccountsReceivableContractBatch() { }

    public AccountsReceivableContractBatch(AccountsReceivableContractBatchId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsReceivableContractBatch
    /// المعرف الفريد لـ AccountsReceivableContractBatch
    /// </summary>
    public AccountsReceivableContractBatchId Id { get; private set; }

    /// <summary>
    /// ContractBatchNumber of the AccountsReceivableContractBatch
    /// ContractBatchNumber الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public decimal? ContractBatchNumber { get; private set; }

    /// <summary>
    /// ContractBatchDate of the AccountsReceivableContractBatch
    /// ContractBatchDate الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public DateTime? ContractBatchDate { get; private set; }

    /// <summary>
    /// ContractNumber of the AccountsReceivableContractBatch
    /// ContractNumber الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// DocNo of the AccountsReceivableContractBatch
    /// DocNo الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsReceivableContractBatch
    /// RecordNumber الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// Amount of the AccountsReceivableContractBatch
    /// Amount الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the AccountsReceivableContractBatch
    /// ProcessedFlagFull الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsReceivableContractBatch
    /// CompanyNumberShort الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsReceivableContractBatch
    /// BranchNumber الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsReceivableContractBatch
    /// BranchYear الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsReceivableContractBatch
    /// BranchUser الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// AdvancePayment of the AccountsReceivableContractBatch
    /// AdvancePayment الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public decimal? AdvancePayment { get; private set; }

    /// <summary>
    /// ProcessedFlagGlass of the AccountsReceivableContractBatch
    /// ProcessedFlagGlass الخاص بـ AccountsReceivableContractBatch
    /// </summary>
    public decimal? ProcessedFlagGlass { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountsReceivableContractMaster AccountsReceivableContractMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
