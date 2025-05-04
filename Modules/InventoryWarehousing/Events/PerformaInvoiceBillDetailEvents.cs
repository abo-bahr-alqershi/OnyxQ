using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to PerformaInvoiceBillDetail entity
/// </summary>
public sealed class PerformaInvoiceBillDetailCreatedEvent : DomainEvent
{
    public PerformaInvoiceBillDetailId PerformaInvoiceBillDetailId { get; }

    public PerformaInvoiceBillDetailCreatedEvent(PerformaInvoiceBillDetailId performainvoicebilldetailId)
    {
        PerformaInvoiceBillDetailId = performainvoicebilldetailId;
    }
}

public sealed class PerformaInvoiceBillDetailUpdatedEvent : DomainEvent
{
    public PerformaInvoiceBillDetailId PerformaInvoiceBillDetailId { get; }

    public PerformaInvoiceBillDetailUpdatedEvent(PerformaInvoiceBillDetailId performainvoicebilldetailId)
    {
        PerformaInvoiceBillDetailId = performainvoicebilldetailId;
    }
}

public sealed class PerformaInvoiceBillDetailDeletedEvent : DomainEvent
{
    public PerformaInvoiceBillDetailId PerformaInvoiceBillDetailId { get; }

    public PerformaInvoiceBillDetailDeletedEvent(PerformaInvoiceBillDetailId performainvoicebilldetailId)
    {
        PerformaInvoiceBillDetailId = performainvoicebilldetailId;
    }
}
}
