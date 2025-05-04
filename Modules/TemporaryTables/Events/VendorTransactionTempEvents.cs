using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to VendorTransactionTemp entity
/// </summary>
public sealed class VendorTransactionTempCreatedEvent : DomainEvent
{
    public VendorTransactionTempId VendorTransactionTempId { get; }

    public VendorTransactionTempCreatedEvent(VendorTransactionTempId vendortransactiontempId)
    {
        VendorTransactionTempId = vendortransactiontempId;
    }
}

public sealed class VendorTransactionTempUpdatedEvent : DomainEvent
{
    public VendorTransactionTempId VendorTransactionTempId { get; }

    public VendorTransactionTempUpdatedEvent(VendorTransactionTempId vendortransactiontempId)
    {
        VendorTransactionTempId = vendortransactiontempId;
    }
}

public sealed class VendorTransactionTempDeletedEvent : DomainEvent
{
    public VendorTransactionTempId VendorTransactionTempId { get; }

    public VendorTransactionTempDeletedEvent(VendorTransactionTempId vendortransactiontempId)
    {
        VendorTransactionTempId = vendortransactiontempId;
    }
}
}
