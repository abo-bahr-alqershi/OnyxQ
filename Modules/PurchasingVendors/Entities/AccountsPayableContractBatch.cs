using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableContractBatch Entity
/// </summary>
public class AccountsPayableContractBatch : Entity<AccountsPayableContractBatchId>
{
    private AccountsPayableContractBatch() { }

    /// <summary>
    /// The unique identifier for the AccountsPayableContractBatch
    /// المعرف الفريد لـ AccountsPayableContractBatch
    /// </summary>
    public AccountsPayableContractBatchId Id { get; private set; }

    /// <summary>
    /// ContractBatchNumber of the AccountsPayableContractBatch
    /// ContractBatchNumber الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public decimal? ContractBatchNumber { get; private set; }

    /// <summary>
    /// ContractBatchDate of the AccountsPayableContractBatch
    /// ContractBatchDate الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public DateTime? ContractBatchDate { get; private set; }

    /// <summary>
    /// ContractNumber of the AccountsPayableContractBatch
    /// ContractNumber الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// ContractSerial of the AccountsPayableContractBatch
    /// ContractSerial الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public string ContractSerial { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsPayableContractBatch
    /// RecordNumber الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// Amount of the AccountsPayableContractBatch
    /// Amount الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// ProcessedFlagFull of the AccountsPayableContractBatch
    /// ProcessedFlagFull الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public decimal? ProcessedFlagFull { get; private set; }

    /// <summary>
    /// InactiveFlag of the AccountsPayableContractBatch
    /// InactiveFlag الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the AccountsPayableContractBatch
    /// InactivatedByUserId الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the AccountsPayableContractBatch
    /// InactiveDate الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the AccountsPayableContractBatch
    /// InactiveReason الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableContractBatch
    /// CompanyNumberShort الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableContractBatch
    /// BranchNumber الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableContractBatch
    /// BranchYear الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableContractBatch
    /// BranchUser الخاص بـ AccountsPayableContractBatch
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to AccountsPayableContractMaster
    /// </summary>
    public AccountsPayableContractMaster AccountsPayableContractMaster { get; private set; }
    #endregion
}
}
