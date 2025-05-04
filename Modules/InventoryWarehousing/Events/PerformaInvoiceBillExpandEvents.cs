using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to PerformaInvoiceBillExpand entity
/// </summary>
public sealed class PerformaInvoiceBillExpandCreatedEvent : DomainEvent
{
    public PerformaInvoiceBillExpandId PerformaInvoiceBillExpandId { get; }

    public PerformaInvoiceBillExpandCreatedEvent(PerformaInvoiceBillExpandId performainvoicebillexpandId)
    {
        PerformaInvoiceBillExpandId = performainvoicebillexpandId;
    }
}

public sealed class PerformaInvoiceBillExpandUpdatedEvent : DomainEvent
{
    public PerformaInvoiceBillExpandId PerformaInvoiceBillExpandId { get; }

    public PerformaInvoiceBillExpandUpdatedEvent(PerformaInvoiceBillExpandId performainvoicebillexpandId)
    {
        PerformaInvoiceBillExpandId = performainvoicebillexpandId;
    }
}

public sealed class PerformaInvoiceBillExpandDeletedEvent : DomainEvent
{
    public PerformaInvoiceBillExpandId PerformaInvoiceBillExpandId { get; }

    public PerformaInvoiceBillExpandDeletedEvent(PerformaInvoiceBillExpandId performainvoicebillexpandId)
    {
        PerformaInvoiceBillExpandId = performainvoicebillexpandId;
    }
}
}
