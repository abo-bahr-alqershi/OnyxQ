using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to FormDetail entity
/// </summary>
public sealed class FormDetailCreatedEvent : DomainEvent
{
    public FormDetailId FormDetailId { get; }

    public FormDetailCreatedEvent(FormDetailId formdetailId)
    {
        FormDetailId = formdetailId;
    }
}

public sealed class FormDetailUpdatedEvent : DomainEvent
{
    public FormDetailId FormDetailId { get; }

    public FormDetailUpdatedEvent(FormDetailId formdetailId)
    {
        FormDetailId = formdetailId;
    }
}

public sealed class FormDetailDeletedEvent : DomainEvent
{
    public FormDetailId FormDetailId { get; }

    public FormDetailDeletedEvent(FormDetailId formdetailId)
    {
        FormDetailId = formdetailId;
    }
}
}
