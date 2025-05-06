using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ConnectContact entity
/// </summary>
public sealed class ConnectContactCreatedEvent : DomainEvent
{
    public ConnectContactId ConnectContactId { get; }

    public ConnectContactCreatedEvent(ConnectContactId connectcontactId)
    {
        ConnectContactId = connectcontactId;
    }
}

public sealed class ConnectContactUpdatedEvent : DomainEvent
{
    public ConnectContactId ConnectContactId { get; }

    public ConnectContactUpdatedEvent(ConnectContactId connectcontactId)
    {
        ConnectContactId = connectcontactId;
    }
}

public sealed class ConnectContactDeletedEvent : DomainEvent
{
    public ConnectContactId ConnectContactId { get; }

    public ConnectContactDeletedEvent(ConnectContactId connectcontactId)
    {
        ConnectContactId = connectcontactId;
    }
}
}
