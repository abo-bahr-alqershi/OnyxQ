using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;
namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// TransferOutTemp Entity
/// </summary>
public class TransferOutTemp : Entity<TransferOutTempId>
{

    private TransferOutTemp() { }

    public TransferOutTemp(TransferOutTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the TransferOutTemp
    /// المعرف الفريد لـ TransferOutTemp
    /// </summary>
    public TransferOutTempId Id { get; private set; }

    /// <summary>
    /// TransactionSerial of the TransferOutTemp
    /// TransactionSerial الخاص بـ TransferOutTemp
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

