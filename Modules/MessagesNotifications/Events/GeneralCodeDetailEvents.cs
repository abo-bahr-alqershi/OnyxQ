using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to GeneralCodeDetail entity
/// </summary>
public sealed class GeneralCodeDetailCreatedEvent : DomainEvent
{
    public GeneralCodeDetailId GeneralCodeDetailId { get; }

    public GeneralCodeDetailCreatedEvent(GeneralCodeDetailId generalcodedetailId)
    {
        GeneralCodeDetailId = generalcodedetailId;
    }
}

public sealed class GeneralCodeDetailUpdatedEvent : DomainEvent
{
    public GeneralCodeDetailId GeneralCodeDetailId { get; }

    public GeneralCodeDetailUpdatedEvent(GeneralCodeDetailId generalcodedetailId)
    {
        GeneralCodeDetailId = generalcodedetailId;
    }
}

public sealed class GeneralCodeDetailDeletedEvent : DomainEvent
{
    public GeneralCodeDetailId GeneralCodeDetailId { get; }

    public GeneralCodeDetailDeletedEvent(GeneralCodeDetailId generalcodedetailId)
    {
        GeneralCodeDetailId = generalcodedetailId;
    }
}
}
