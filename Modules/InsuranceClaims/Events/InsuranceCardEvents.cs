using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceCard entity
/// </summary>
public sealed class InsuranceCardCreatedEvent : DomainEvent
{
    public InsuranceCardId InsuranceCardId { get; }

    public InsuranceCardCreatedEvent(InsuranceCardId insurancecardId)
    {
        InsuranceCardId = insurancecardId;
    }
}

public sealed class InsuranceCardUpdatedEvent : DomainEvent
{
    public InsuranceCardId InsuranceCardId { get; }

    public InsuranceCardUpdatedEvent(InsuranceCardId insurancecardId)
    {
        InsuranceCardId = insurancecardId;
    }
}

public sealed class InsuranceCardDeletedEvent : DomainEvent
{
    public InsuranceCardId InsuranceCardId { get; }

    public InsuranceCardDeletedEvent(InsuranceCardId insurancecardId)
    {
        InsuranceCardId = insurancecardId;
    }
}
}
