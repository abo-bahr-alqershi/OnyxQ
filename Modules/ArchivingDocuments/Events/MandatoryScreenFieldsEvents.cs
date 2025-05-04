using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to MandatoryScreenFields entity
/// </summary>
public sealed class MandatoryScreenFieldsCreatedEvent : DomainEvent
{
    public MandatoryScreenFieldsId MandatoryScreenFieldsId { get; }

    public MandatoryScreenFieldsCreatedEvent(MandatoryScreenFieldsId mandatoryscreenfieldsId)
    {
        MandatoryScreenFieldsId = mandatoryscreenfieldsId;
    }
}

public sealed class MandatoryScreenFieldsUpdatedEvent : DomainEvent
{
    public MandatoryScreenFieldsId MandatoryScreenFieldsId { get; }

    public MandatoryScreenFieldsUpdatedEvent(MandatoryScreenFieldsId mandatoryscreenfieldsId)
    {
        MandatoryScreenFieldsId = mandatoryscreenfieldsId;
    }
}

public sealed class MandatoryScreenFieldsDeletedEvent : DomainEvent
{
    public MandatoryScreenFieldsId MandatoryScreenFieldsId { get; }

    public MandatoryScreenFieldsDeletedEvent(MandatoryScreenFieldsId mandatoryscreenfieldsId)
    {
        MandatoryScreenFieldsId = mandatoryscreenfieldsId;
    }
}
}
