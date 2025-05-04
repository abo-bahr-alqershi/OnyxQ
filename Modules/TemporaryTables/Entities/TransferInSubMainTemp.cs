using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// TransferInSubMainTemp Entity
/// </summary>
public class TransferInSubMainTemp : Entity<TransferInSubMainTempId>
{
    private TransferInSubMainTemp() { }

    /// <summary>
    /// The unique identifier for the TransferInSubMainTemp
    /// المعرف الفريد لـ TransferInSubMainTemp
    /// </summary>
    public TransferInSubMainTempId Id { get; private set; }

    /// <summary>
    /// TransactionSerial of the TransferInSubMainTemp
    /// TransactionSerial الخاص بـ TransferInSubMainTemp
    /// </summary>
    public decimal? TransactionSerial { get; private set; }
}
}
