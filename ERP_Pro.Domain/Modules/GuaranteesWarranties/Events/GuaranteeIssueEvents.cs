using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.ValueObjects;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Events
{
/// <summary>
/// Events related to GuaranteeIssue entity
/// </summary>
public sealed class GuaranteeIssueCreatedEvent : DomainEvent
{
    public GuaranteeIssueId GuaranteeIssueId { get; }

    public GuaranteeIssueCreatedEvent(GuaranteeIssueId guaranteeissueId)
    {
        GuaranteeIssueId = guaranteeissueId;
    }
}

public sealed class GuaranteeIssueUpdatedEvent : DomainEvent
{
    public GuaranteeIssueId GuaranteeIssueId { get; }

    public GuaranteeIssueUpdatedEvent(GuaranteeIssueId guaranteeissueId)
    {
        GuaranteeIssueId = guaranteeissueId;
    }
}

public sealed class GuaranteeIssueDeletedEvent : DomainEvent
{
    public GuaranteeIssueId GuaranteeIssueId { get; }

    public GuaranteeIssueDeletedEvent(GuaranteeIssueId guaranteeissueId)
    {
        GuaranteeIssueId = guaranteeissueId;
    }
}
}
