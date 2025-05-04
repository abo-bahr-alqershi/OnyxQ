using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// TransferInTemp Entity
/// </summary>
public class TransferInTemp : Entity<TransferInTempId>
{

    private TransferInTemp() { }

    public TransferInTemp(TransferInTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the TransferInTemp
    /// المعرف الفريد لـ TransferInTemp
    /// </summary>
    public TransferInTempId Id { get; private set; }

    /// <summary>
    /// TransactionSerial of the TransferInTemp
    /// TransactionSerial الخاص بـ TransferInTemp
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
