using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to FormName entity
/// </summary>
public sealed class FormNameCreatedEvent : DomainEvent
{
    public FormNameId FormNameId { get; }

    public FormNameCreatedEvent(FormNameId formnameId)
    {
        FormNameId = formnameId;
    }
}

public sealed class FormNameUpdatedEvent : DomainEvent
{
    public FormNameId FormNameId { get; }

    public FormNameUpdatedEvent(FormNameId formnameId)
    {
        FormNameId = formnameId;
    }
}

public sealed class FormNameDeletedEvent : DomainEvent
{
    public FormNameId FormNameId { get; }

    public FormNameDeletedEvent(FormNameId formnameId)
    {
        FormNameId = formnameId;
    }
}
}
