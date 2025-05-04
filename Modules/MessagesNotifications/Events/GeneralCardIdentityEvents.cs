using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to GeneralCardIdentity entity
/// </summary>
public sealed class GeneralCardIdentityCreatedEvent : DomainEvent
{
    public GeneralCardIdentityId GeneralCardIdentityId { get; }

    public GeneralCardIdentityCreatedEvent(GeneralCardIdentityId generalcardidentityId)
    {
        GeneralCardIdentityId = generalcardidentityId;
    }
}

public sealed class GeneralCardIdentityUpdatedEvent : DomainEvent
{
    public GeneralCardIdentityId GeneralCardIdentityId { get; }

    public GeneralCardIdentityUpdatedEvent(GeneralCardIdentityId generalcardidentityId)
    {
        GeneralCardIdentityId = generalcardidentityId;
    }
}

public sealed class GeneralCardIdentityDeletedEvent : DomainEvent
{
    public GeneralCardIdentityId GeneralCardIdentityId { get; }

    public GeneralCardIdentityDeletedEvent(GeneralCardIdentityId generalcardidentityId)
    {
        GeneralCardIdentityId = generalcardidentityId;
    }
}
}
