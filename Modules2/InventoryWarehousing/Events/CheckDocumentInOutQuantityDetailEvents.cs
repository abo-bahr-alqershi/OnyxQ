using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to CheckDocumentInOutQuantityDetail entity
/// </summary>
public sealed class CheckDocumentInOutQuantityDetailCreatedEvent : DomainEvent
{
    public CheckDocumentInOutQuantityDetailId CheckDocumentInOutQuantityDetailId { get; }

    public CheckDocumentInOutQuantityDetailCreatedEvent(CheckDocumentInOutQuantityDetailId checkdocumentinoutquantitydetailId)
    {
        CheckDocumentInOutQuantityDetailId = checkdocumentinoutquantitydetailId;
    }
}

public sealed class CheckDocumentInOutQuantityDetailUpdatedEvent : DomainEvent
{
    public CheckDocumentInOutQuantityDetailId CheckDocumentInOutQuantityDetailId { get; }

    public CheckDocumentInOutQuantityDetailUpdatedEvent(CheckDocumentInOutQuantityDetailId checkdocumentinoutquantitydetailId)
    {
        CheckDocumentInOutQuantityDetailId = checkdocumentinoutquantitydetailId;
    }
}

public sealed class CheckDocumentInOutQuantityDetailDeletedEvent : DomainEvent
{
    public CheckDocumentInOutQuantityDetailId CheckDocumentInOutQuantityDetailId { get; }

    public CheckDocumentInOutQuantityDetailDeletedEvent(CheckDocumentInOutQuantityDetailId checkdocumentinoutquantitydetailId)
    {
        CheckDocumentInOutQuantityDetailId = checkdocumentinoutquantitydetailId;
    }
}
}
