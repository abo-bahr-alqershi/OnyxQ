using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to MandatoryScreen entity
/// </summary>
public sealed class MandatoryScreenCreatedEvent : DomainEvent
{
    public MandatoryScreenId MandatoryScreenId { get; }

    public MandatoryScreenCreatedEvent(MandatoryScreenId mandatoryscreenId)
    {
        MandatoryScreenId = mandatoryscreenId;
    }
}

public sealed class MandatoryScreenUpdatedEvent : DomainEvent
{
    public MandatoryScreenId MandatoryScreenId { get; }

    public MandatoryScreenUpdatedEvent(MandatoryScreenId mandatoryscreenId)
    {
        MandatoryScreenId = mandatoryscreenId;
    }
}

public sealed class MandatoryScreenDeletedEvent : DomainEvent
{
    public MandatoryScreenId MandatoryScreenId { get; }

    public MandatoryScreenDeletedEvent(MandatoryScreenId mandatoryscreenId)
    {
        MandatoryScreenId = mandatoryscreenId;
    }
}
}
