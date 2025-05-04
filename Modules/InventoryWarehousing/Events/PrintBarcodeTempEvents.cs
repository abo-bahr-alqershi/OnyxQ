using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to PrintBarcodeTemp entity
/// </summary>
public sealed class PrintBarcodeTempCreatedEvent : DomainEvent
{
    public PrintBarcodeTempId PrintBarcodeTempId { get; }

    public PrintBarcodeTempCreatedEvent(PrintBarcodeTempId printbarcodetempId)
    {
        PrintBarcodeTempId = printbarcodetempId;
    }
}

public sealed class PrintBarcodeTempUpdatedEvent : DomainEvent
{
    public PrintBarcodeTempId PrintBarcodeTempId { get; }

    public PrintBarcodeTempUpdatedEvent(PrintBarcodeTempId printbarcodetempId)
    {
        PrintBarcodeTempId = printbarcodetempId;
    }
}

public sealed class PrintBarcodeTempDeletedEvent : DomainEvent
{
    public PrintBarcodeTempId PrintBarcodeTempId { get; }

    public PrintBarcodeTempDeletedEvent(PrintBarcodeTempId printbarcodetempId)
    {
        PrintBarcodeTempId = printbarcodetempId;
    }
}
}
