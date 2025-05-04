using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableContractRenew Entity
/// </summary>
public class AccountsPayableContractRenew : Entity<AccountsPayableContractRenewId>
{

    private AccountsPayableContractRenew() { }

    public AccountsPayableContractRenew(AccountsPayableContractRenewId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableContractRenew
    /// المعرف الفريد لـ AccountsPayableContractRenew
    /// </summary>
    public AccountsPayableContractRenewId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsPayableContractRenew
    /// RecordNumber الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ContractNumber of the AccountsPayableContractRenew
    /// ContractNumber الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// ContractNewDate of the AccountsPayableContractRenew
    /// ContractNewDate الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public DateTime? ContractNewDate { get; private set; }

    /// <summary>
    /// IncreaseType of the AccountsPayableContractRenew
    /// IncreaseType الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public decimal? IncreaseType { get; private set; }

    /// <summary>
    /// ContractFromDate of the AccountsPayableContractRenew
    /// ContractFromDate الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public DateTime? ContractFromDate { get; private set; }

    /// <summary>
    /// ContractTransactionDate of the AccountsPayableContractRenew
    /// ContractTransactionDate الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public DateTime? ContractTransactionDate { get; private set; }

    /// <summary>
    /// ContractAmount of the AccountsPayableContractRenew
    /// ContractAmount الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public decimal? ContractAmount { get; private set; }

    /// <summary>
    /// ContractDescription of the AccountsPayableContractRenew
    /// ContractDescription الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public string ContractDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AccountsPayableContractRenew
    /// ReferenceNumber الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableContractRenew
    /// CompanyNumberShort الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableContractRenew
    /// BranchNumber الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableContractRenew
    /// BranchYear الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableContractRenew
    /// BranchUser الخاص بـ AccountsPayableContractRenew
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountsPayableContractMaster AccountsPayableContractMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
