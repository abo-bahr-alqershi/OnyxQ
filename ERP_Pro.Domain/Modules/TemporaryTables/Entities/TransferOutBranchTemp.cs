using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;
namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// TransferOutBranchTemp Entity
/// </summary>
public class TransferOutBranchTemp : Entity<TransferOutBranchTempId>
{

    private TransferOutBranchTemp() { }

    public TransferOutBranchTemp(TransferOutBranchTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the TransferOutBranchTemp
    /// المعرف الفريد لـ TransferOutBranchTemp
    /// </summary>
    public TransferOutBranchTempId Id { get; private set; }

    /// <summary>
    /// TransactionSerial of the TransferOutBranchTemp
    /// TransactionSerial الخاص بـ TransferOutBranchTemp
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    /// <summary>
    /// FTransactionSerial of the TransferOutBranchTemp
    /// FTransactionSerial الخاص بـ TransferOutBranchTemp
    /// </summary>
    public decimal? FTransactionSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

