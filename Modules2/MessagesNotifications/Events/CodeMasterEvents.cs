using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.MessagesNotifications.ValueObjects;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to CodeMaster entity
/// </summary>
public sealed class CodeMasterCreatedEvent : DomainEvent
{
    public CodeMasterId CodeMasterId { get; }

    public CodeMasterCreatedEvent(CodeMasterId codemasterId)
    {
        CodeMasterId = codemasterId;
    }
}

public sealed class CodeMasterUpdatedEvent : DomainEvent
{
    public CodeMasterId CodeMasterId { get; }

    public CodeMasterUpdatedEvent(CodeMasterId codemasterId)
    {
        CodeMasterId = codemasterId;
    }
}

public sealed class CodeMasterDeletedEvent : DomainEvent
{
    public CodeMasterId CodeMasterId { get; }

    public CodeMasterDeletedEvent(CodeMasterId codemasterId)
    {
        CodeMasterId = codemasterId;
    }
}
}
