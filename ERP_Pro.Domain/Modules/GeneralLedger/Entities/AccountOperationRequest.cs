using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// AccountOperationRequest Entity
/// </summary>
public class AccountOperationRequest : Entity<AccountOperationRequestId>
{

    private AccountOperationRequest() { }

    public AccountOperationRequest(AccountOperationRequestId id, decimal? accountType, string accountCode)
    {
        Id = id;
        AccountType = accountType;
        AccountCode = accountCode;
    }

    /// <summary>
    /// The unique identifier for the AccountOperationRequest
    /// المعرف الفريد لـ AccountOperationRequest
    /// </summary>
    public AccountOperationRequestId Id { get; private set; }

    /// <summary>
    /// AccountType of the AccountOperationRequest
    /// AccountType الخاص بـ AccountOperationRequest
    /// </summary>
    public decimal? AccountType { get; private set; }

    /// <summary>
    /// AccountCode of the AccountOperationRequest
    /// AccountCode الخاص بـ AccountOperationRequest
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountName of the AccountOperationRequest
    /// AccountName الخاص بـ AccountOperationRequest
    /// </summary>
    public string AccountName { get; private set; }

    /// <summary>
    /// AccountNameEnglish of the AccountOperationRequest
    /// AccountNameEnglish الخاص بـ AccountOperationRequest
    /// </summary>
    public string AccountNameEnglish { get; private set; }

    /// <summary>
    /// ParentAccountCode of the AccountOperationRequest
    /// ParentAccountCode الخاص بـ AccountOperationRequest
    /// </summary>
    public string ParentAccountCode { get; private set; }

    /// <summary>
    /// AccountReport of the AccountOperationRequest
    /// AccountReport الخاص بـ AccountOperationRequest
    /// </summary>
    public decimal? AccountReport { get; private set; }

    /// <summary>
    /// AccountGroup of the AccountOperationRequest
    /// AccountGroup الخاص بـ AccountOperationRequest
    /// </summary>
    public decimal? AccountGroup { get; private set; }

    /// <summary>
    /// AccountNote of the AccountOperationRequest
    /// AccountNote الخاص بـ AccountOperationRequest
    /// </summary>
    public string AccountNote { get; private set; }

    /// <summary>
    /// AccountOperationNumber of the AccountOperationRequest
    /// AccountOperationNumber الخاص بـ AccountOperationRequest
    /// </summary>
    public decimal? AccountOperationNumber { get; private set; }

    /// <summary>
    /// InsertedFlag of the AccountOperationRequest
    /// InsertedFlag الخاص بـ AccountOperationRequest
    /// </summary>
    public decimal? InsertedFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
