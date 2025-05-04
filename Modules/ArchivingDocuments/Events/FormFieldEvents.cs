using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to FormField entity
/// </summary>
public sealed class FormFieldCreatedEvent : DomainEvent
{
    public FormFieldId FormFieldId { get; }

    public FormFieldCreatedEvent(FormFieldId formfieldId)
    {
        FormFieldId = formfieldId;
    }
}

public sealed class FormFieldUpdatedEvent : DomainEvent
{
    public FormFieldId FormFieldId { get; }

    public FormFieldUpdatedEvent(FormFieldId formfieldId)
    {
        FormFieldId = formfieldId;
    }
}

public sealed class FormFieldDeletedEvent : DomainEvent
{
    public FormFieldId FormFieldId { get; }

    public FormFieldDeletedEvent(FormFieldId formfieldId)
    {
        FormFieldId = formfieldId;
    }
}
}
