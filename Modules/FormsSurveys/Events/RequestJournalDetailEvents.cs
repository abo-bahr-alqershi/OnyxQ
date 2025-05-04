using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to RequestJournalDetail entity
/// </summary>
public sealed class RequestJournalDetailCreatedEvent : DomainEvent
{
    public RequestJournalDetailId RequestJournalDetailId { get; }

    public RequestJournalDetailCreatedEvent(RequestJournalDetailId requestjournaldetailId)
    {
        RequestJournalDetailId = requestjournaldetailId;
    }
}

public sealed class RequestJournalDetailUpdatedEvent : DomainEvent
{
    public RequestJournalDetailId RequestJournalDetailId { get; }

    public RequestJournalDetailUpdatedEvent(RequestJournalDetailId requestjournaldetailId)
    {
        RequestJournalDetailId = requestjournaldetailId;
    }
}

public sealed class RequestJournalDetailDeletedEvent : DomainEvent
{
    public RequestJournalDetailId RequestJournalDetailId { get; }

    public RequestJournalDetailDeletedEvent(RequestJournalDetailId requestjournaldetailId)
    {
        RequestJournalDetailId = requestjournaldetailId;
    }
}
}
