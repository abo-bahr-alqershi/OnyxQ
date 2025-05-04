using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to RequestJournalMaster entity
/// </summary>
public sealed class RequestJournalMasterCreatedEvent : DomainEvent
{
    public RequestJournalMasterId RequestJournalMasterId { get; }

    public RequestJournalMasterCreatedEvent(RequestJournalMasterId requestjournalmasterId)
    {
        RequestJournalMasterId = requestjournalmasterId;
    }
}

public sealed class RequestJournalMasterUpdatedEvent : DomainEvent
{
    public RequestJournalMasterId RequestJournalMasterId { get; }

    public RequestJournalMasterUpdatedEvent(RequestJournalMasterId requestjournalmasterId)
    {
        RequestJournalMasterId = requestjournalmasterId;
    }
}

public sealed class RequestJournalMasterDeletedEvent : DomainEvent
{
    public RequestJournalMasterId RequestJournalMasterId { get; }

    public RequestJournalMasterDeletedEvent(RequestJournalMasterId requestjournalmasterId)
    {
        RequestJournalMasterId = requestjournalmasterId;
    }
}
}
