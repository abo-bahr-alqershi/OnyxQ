using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to SelectField entity
/// </summary>
public sealed class SelectFieldCreatedEvent : DomainEvent
{
    public SelectFieldId SelectFieldId { get; }

    public SelectFieldCreatedEvent(SelectFieldId selectfieldId)
    {
        SelectFieldId = selectfieldId;
    }
}

public sealed class SelectFieldUpdatedEvent : DomainEvent
{
    public SelectFieldId SelectFieldId { get; }

    public SelectFieldUpdatedEvent(SelectFieldId selectfieldId)
    {
        SelectFieldId = selectfieldId;
    }
}

public sealed class SelectFieldDeletedEvent : DomainEvent
{
    public SelectFieldId SelectFieldId { get; }

    public SelectFieldDeletedEvent(SelectFieldId selectfieldId)
    {
        SelectFieldId = selectfieldId;
    }
}
}
