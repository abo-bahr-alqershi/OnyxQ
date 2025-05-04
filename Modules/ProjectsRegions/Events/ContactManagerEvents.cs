using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to ContactManager entity
/// </summary>
public sealed class ContactManagerCreatedEvent : DomainEvent
{
    public ContactManagerId ContactManagerId { get; }

    public ContactManagerCreatedEvent(ContactManagerId contactmanagerId)
    {
        ContactManagerId = contactmanagerId;
    }
}

public sealed class ContactManagerUpdatedEvent : DomainEvent
{
    public ContactManagerId ContactManagerId { get; }

    public ContactManagerUpdatedEvent(ContactManagerId contactmanagerId)
    {
        ContactManagerId = contactmanagerId;
    }
}

public sealed class ContactManagerDeletedEvent : DomainEvent
{
    public ContactManagerId ContactManagerId { get; }

    public ContactManagerDeletedEvent(ContactManagerId contactmanagerId)
    {
        ContactManagerId = contactmanagerId;
    }
}
}
