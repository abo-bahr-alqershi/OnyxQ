using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to GeneralCodeMaster entity
/// </summary>
public sealed class GeneralCodeMasterCreatedEvent : DomainEvent
{
    public GeneralCodeMasterId GeneralCodeMasterId { get; }

    public GeneralCodeMasterCreatedEvent(GeneralCodeMasterId generalcodemasterId)
    {
        GeneralCodeMasterId = generalcodemasterId;
    }
}

public sealed class GeneralCodeMasterUpdatedEvent : DomainEvent
{
    public GeneralCodeMasterId GeneralCodeMasterId { get; }

    public GeneralCodeMasterUpdatedEvent(GeneralCodeMasterId generalcodemasterId)
    {
        GeneralCodeMasterId = generalcodemasterId;
    }
}

public sealed class GeneralCodeMasterDeletedEvent : DomainEvent
{
    public GeneralCodeMasterId GeneralCodeMasterId { get; }

    public GeneralCodeMasterDeletedEvent(GeneralCodeMasterId generalcodemasterId)
    {
        GeneralCodeMasterId = generalcodemasterId;
    }
}
}
