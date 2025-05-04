using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to Sponsor entity
/// </summary>
public sealed class SponsorCreatedEvent : DomainEvent
{
    public SponsorId SponsorId { get; }

    public SponsorCreatedEvent(SponsorId sponsorId)
    {
        SponsorId = sponsorId;
    }
}

public sealed class SponsorUpdatedEvent : DomainEvent
{
    public SponsorId SponsorId { get; }

    public SponsorUpdatedEvent(SponsorId sponsorId)
    {
        SponsorId = sponsorId;
    }
}

public sealed class SponsorDeletedEvent : DomainEvent
{
    public SponsorId SponsorId { get; }

    public SponsorDeletedEvent(SponsorId sponsorId)
    {
        SponsorId = sponsorId;
    }
}
}
