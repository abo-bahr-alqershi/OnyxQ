using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;
namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// TransferOutSubMainTemp Entity
/// </summary>
public class TransferOutSubMainTemp : Entity<TransferOutSubMainTempId>
{

    private TransferOutSubMainTemp() { }

    public TransferOutSubMainTemp(TransferOutSubMainTempId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the TransferOutSubMainTemp
    /// المعرف الفريد لـ TransferOutSubMainTemp
    /// </summary>
    public TransferOutSubMainTempId Id { get; private set; }

    /// <summary>
    /// TransactionSerial of the TransferOutSubMainTemp
    /// TransactionSerial الخاص بـ TransferOutSubMainTemp
    /// </summary>
    public decimal? TransactionSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

