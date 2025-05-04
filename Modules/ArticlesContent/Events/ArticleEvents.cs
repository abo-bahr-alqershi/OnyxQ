using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArticlesContent.Events
{
/// <summary>
/// Events related to Article entity
/// </summary>
public sealed class ArticleCreatedEvent : DomainEvent
{
    public ArticleId ArticleId { get; }

    public ArticleCreatedEvent(ArticleId articleId)
    {
        ArticleId = articleId;
    }
}

public sealed class ArticleUpdatedEvent : DomainEvent
{
    public ArticleId ArticleId { get; }

    public ArticleUpdatedEvent(ArticleId articleId)
    {
        ArticleId = articleId;
    }
}

public sealed class ArticleDeletedEvent : DomainEvent
{
    public ArticleId ArticleId { get; }

    public ArticleDeletedEvent(ArticleId articleId)
    {
        ArticleId = articleId;
    }
}
}
