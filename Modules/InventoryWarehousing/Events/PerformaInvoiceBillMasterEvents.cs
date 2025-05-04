using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to PerformaInvoiceBillMaster entity
/// </summary>
public sealed class PerformaInvoiceBillMasterCreatedEvent : DomainEvent
{
    public PerformaInvoiceBillMasterId PerformaInvoiceBillMasterId { get; }

    public PerformaInvoiceBillMasterCreatedEvent(PerformaInvoiceBillMasterId performainvoicebillmasterId)
    {
        PerformaInvoiceBillMasterId = performainvoicebillmasterId;
    }
}

public sealed class PerformaInvoiceBillMasterUpdatedEvent : DomainEvent
{
    public PerformaInvoiceBillMasterId PerformaInvoiceBillMasterId { get; }

    public PerformaInvoiceBillMasterUpdatedEvent(PerformaInvoiceBillMasterId performainvoicebillmasterId)
    {
        PerformaInvoiceBillMasterId = performainvoicebillmasterId;
    }
}

public sealed class PerformaInvoiceBillMasterDeletedEvent : DomainEvent
{
    public PerformaInvoiceBillMasterId PerformaInvoiceBillMasterId { get; }

    public PerformaInvoiceBillMasterDeletedEvent(PerformaInvoiceBillMasterId performainvoicebillmasterId)
    {
        PerformaInvoiceBillMasterId = performainvoicebillmasterId;
    }
}
}
