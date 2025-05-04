using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// TransferInBranchTemp Entity
/// </summary>
public class TransferInBranchTemp : Entity<TransferInBranchTempId>
{

    private TransferInBranchTemp() { }

    public TransferInBranchTemp(TransferInBranchTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the TransferInBranchTemp
    /// المعرف الفريد لـ TransferInBranchTemp
    /// </summary>
    public TransferInBranchTempId Id { get; private set; }

    /// <summary>
    /// TransactionSerial of the TransferInBranchTemp
    /// TransactionSerial الخاص بـ TransferInBranchTemp
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    /// <summary>
    /// FTransactionSerial of the TransferInBranchTemp
    /// FTransactionSerial الخاص بـ TransferInBranchTemp
    /// </summary>
    public decimal? FTransactionSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
