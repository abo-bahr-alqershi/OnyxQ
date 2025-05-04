using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to CheckDocumentInOutQuantityMaster entity
/// </summary>
public sealed class CheckDocumentInOutQuantityMasterCreatedEvent : DomainEvent
{
    public CheckDocumentInOutQuantityMasterId CheckDocumentInOutQuantityMasterId { get; }

    public CheckDocumentInOutQuantityMasterCreatedEvent(CheckDocumentInOutQuantityMasterId checkdocumentinoutquantitymasterId)
    {
        CheckDocumentInOutQuantityMasterId = checkdocumentinoutquantitymasterId;
    }
}

public sealed class CheckDocumentInOutQuantityMasterUpdatedEvent : DomainEvent
{
    public CheckDocumentInOutQuantityMasterId CheckDocumentInOutQuantityMasterId { get; }

    public CheckDocumentInOutQuantityMasterUpdatedEvent(CheckDocumentInOutQuantityMasterId checkdocumentinoutquantitymasterId)
    {
        CheckDocumentInOutQuantityMasterId = checkdocumentinoutquantitymasterId;
    }
}

public sealed class CheckDocumentInOutQuantityMasterDeletedEvent : DomainEvent
{
    public CheckDocumentInOutQuantityMasterId CheckDocumentInOutQuantityMasterId { get; }

    public CheckDocumentInOutQuantityMasterDeletedEvent(CheckDocumentInOutQuantityMasterId checkdocumentinoutquantitymasterId)
    {
        CheckDocumentInOutQuantityMasterId = checkdocumentinoutquantitymasterId;
    }
}
}
