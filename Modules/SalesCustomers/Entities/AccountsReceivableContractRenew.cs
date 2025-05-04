using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// AccountsReceivableContractRenew Entity
/// </summary>
public class AccountsReceivableContractRenew : Entity<AccountsReceivableContractRenewId>
{
    private AccountsReceivableContractRenew() { }

    /// <summary>
    /// The unique identifier for the AccountsReceivableContractRenew
    /// المعرف الفريد لـ AccountsReceivableContractRenew
    /// </summary>
    public AccountsReceivableContractRenewId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsReceivableContractRenew
    /// RecordNumber الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ContractNumber of the AccountsReceivableContractRenew
    /// ContractNumber الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public string ContractNumber { get; private set; }

    /// <summary>
    /// DocNo of the AccountsReceivableContractRenew
    /// DocNo الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSrl of the AccountsReceivableContractRenew
    /// DocSrl الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public decimal? DocSrl { get; private set; }

    /// <summary>
    /// ContractNewDate of the AccountsReceivableContractRenew
    /// ContractNewDate الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public DateTime? ContractNewDate { get; private set; }

    /// <summary>
    /// IncreaseType of the AccountsReceivableContractRenew
    /// IncreaseType الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public decimal? IncreaseType { get; private set; }

    /// <summary>
    /// ContractFromDate of the AccountsReceivableContractRenew
    /// ContractFromDate الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public DateTime? ContractFromDate { get; private set; }

    /// <summary>
    /// ContractTransactionDate of the AccountsReceivableContractRenew
    /// ContractTransactionDate الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public DateTime? ContractTransactionDate { get; private set; }

    /// <summary>
    /// ContractAmount of the AccountsReceivableContractRenew
    /// ContractAmount الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public decimal? ContractAmount { get; private set; }

    /// <summary>
    /// ContractDescription of the AccountsReceivableContractRenew
    /// ContractDescription الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public string ContractDescription { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AccountsReceivableContractRenew
    /// ReferenceNumber الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsReceivableContractRenew
    /// CompanyNumberShort الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsReceivableContractRenew
    /// BranchNumber الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsReceivableContractRenew
    /// BranchYear الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsReceivableContractRenew
    /// BranchUser الخاص بـ AccountsReceivableContractRenew
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to AccountsReceivableContractMaster
    /// </summary>
    public AccountsReceivableContractMaster AccountsReceivableContractMaster { get; private set; }
    #endregion
}
}
