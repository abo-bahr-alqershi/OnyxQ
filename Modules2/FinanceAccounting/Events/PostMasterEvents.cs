using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to PostMaster entity
/// </summary>
public sealed class PostMasterCreatedEvent : DomainEvent
{
    public PostMasterId PostMasterId { get; }

    public PostMasterCreatedEvent(PostMasterId postmasterId)
    {
        PostMasterId = postmasterId;
    }
}

public sealed class PostMasterUpdatedEvent : DomainEvent
{
    public PostMasterId PostMasterId { get; }

    public PostMasterUpdatedEvent(PostMasterId postmasterId)
    {
        PostMasterId = postmasterId;
    }
}

public sealed class PostMasterDeletedEvent : DomainEvent
{
    public PostMasterId PostMasterId { get; }

    public PostMasterDeletedEvent(PostMasterId postmasterId)
    {
        PostMasterId = postmasterId;
    }
}
}
