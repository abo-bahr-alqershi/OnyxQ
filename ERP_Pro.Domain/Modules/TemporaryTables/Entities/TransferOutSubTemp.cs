using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// TransferOutSubTemp Entity
/// </summary>
public class TransferOutSubTemp : Entity<TransferOutSubTempId>
{

    private TransferOutSubTemp() { }

    public TransferOutSubTemp(TransferOutSubTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the TransferOutSubTemp
    /// المعرف الفريد لـ TransferOutSubTemp
    /// </summary>
    public TransferOutSubTempId Id { get; private set; }

    /// <summary>
    /// TransactionSerial of the TransferOutSubTemp
    /// TransactionSerial الخاص بـ TransferOutSubTemp
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
