using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.MessagesNotifications.Events
{
/// <summary>
/// Events related to CodeDetail entity
/// </summary>
public sealed class CodeDetailCreatedEvent : DomainEvent
{
    public CodeDetailId CodeDetailId { get; }

    public CodeDetailCreatedEvent(CodeDetailId codedetailId)
    {
        CodeDetailId = codedetailId;
    }
}

public sealed class CodeDetailUpdatedEvent : DomainEvent
{
    public CodeDetailId CodeDetailId { get; }

    public CodeDetailUpdatedEvent(CodeDetailId codedetailId)
    {
        CodeDetailId = codedetailId;
    }
}

public sealed class CodeDetailDeletedEvent : DomainEvent
{
    public CodeDetailId CodeDetailId { get; }

    public CodeDetailDeletedEvent(CodeDetailId codedetailId)
    {
        CodeDetailId = codedetailId;
    }
}
}
