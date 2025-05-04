using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// TransferType Entity
/// </summary>
public class TransferType : Entity<TransferTypeId>
{

    private TransferType() { }

    public TransferType(TransferTypeId id, decimal? transactionTypeFull)
    {
        Id = id;
        TransactionTypeFull = transactionTypeFull;
    }

    /// <summary>
    /// The unique identifier for the TransferType
    /// المعرف الفريد لـ TransferType
    /// </summary>
    public TransferTypeId Id { get; private set; }

    /// <summary>
    /// TransactionTypeFull of the TransferType
    /// TransactionTypeFull الخاص بـ TransferType
    /// </summary>
    public decimal? TransactionTypeFull { get; private set; }

    /// <summary>
    /// TransactionName of the TransferType
    /// TransactionName الخاص بـ TransferType
    /// </summary>
    public string TransactionName { get; private set; }

    /// <summary>
    /// TransactionNameEnglish of the TransferType
    /// TransactionNameEnglish الخاص بـ TransferType
    /// </summary>
    public string TransactionNameEnglish { get; private set; }

    /// <summary>
    /// TransactionReason of the TransferType
    /// TransactionReason الخاص بـ TransferType
    /// </summary>
    public decimal? TransactionReason { get; private set; }

    /// <summary>
    /// TransactionSerialReference of the TransferType
    /// TransactionSerialReference الخاص بـ TransferType
    /// </summary>
    public decimal? TransactionSerialReference { get; private set; }

    /// <summary>
    /// TransactionReceiveFlag of the TransferType
    /// TransactionReceiveFlag الخاص بـ TransferType
    /// </summary>
    public decimal? TransactionReceiveFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
