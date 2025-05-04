using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to PostDetail entity
/// </summary>
public sealed class PostDetailCreatedEvent : DomainEvent
{
    public PostDetailId PostDetailId { get; }

    public PostDetailCreatedEvent(PostDetailId postdetailId)
    {
        PostDetailId = postdetailId;
    }
}

public sealed class PostDetailUpdatedEvent : DomainEvent
{
    public PostDetailId PostDetailId { get; }

    public PostDetailUpdatedEvent(PostDetailId postdetailId)
    {
        PostDetailId = postdetailId;
    }
}

public sealed class PostDetailDeletedEvent : DomainEvent
{
    public PostDetailId PostDetailId { get; }

    public PostDetailDeletedEvent(PostDetailId postdetailId)
    {
        PostDetailId = postdetailId;
    }
}
}
