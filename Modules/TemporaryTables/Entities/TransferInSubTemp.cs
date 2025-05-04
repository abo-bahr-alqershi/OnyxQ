using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Entities
{
/// <summary>
/// TransferInSubTemp Entity
/// </summary>
public class TransferInSubTemp : Entity<TransferInSubTempId>
{
    private TransferInSubTemp() { }

    /// <summary>
    /// The unique identifier for the TransferInSubTemp
    /// المعرف الفريد لـ TransferInSubTemp
    /// </summary>
    public TransferInSubTempId Id { get; private set; }

    /// <summary>
    /// TransactionSerial of the TransferInSubTemp
    /// TransactionSerial الخاص بـ TransferInSubTemp
    /// </summary>
    public decimal? TransactionSerial { get; private set; }
}
}
