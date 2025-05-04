using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to CodeSendMessage entity
/// </summary>
public sealed class CodeSendMessageCreatedEvent : DomainEvent
{
    public CodeSendMessageId CodeSendMessageId { get; }

    public CodeSendMessageCreatedEvent(CodeSendMessageId codesendmessageId)
    {
        CodeSendMessageId = codesendmessageId;
    }
}

public sealed class CodeSendMessageUpdatedEvent : DomainEvent
{
    public CodeSendMessageId CodeSendMessageId { get; }

    public CodeSendMessageUpdatedEvent(CodeSendMessageId codesendmessageId)
    {
        CodeSendMessageId = codesendmessageId;
    }
}

public sealed class CodeSendMessageDeletedEvent : DomainEvent
{
    public CodeSendMessageId CodeSendMessageId { get; }

    public CodeSendMessageDeletedEvent(CodeSendMessageId codesendmessageId)
    {
        CodeSendMessageId = codesendmessageId;
    }
}
}
