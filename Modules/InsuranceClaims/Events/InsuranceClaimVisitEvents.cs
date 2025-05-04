using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceClaimVisit entity
/// </summary>
public sealed class InsuranceClaimVisitCreatedEvent : DomainEvent
{
    public InsuranceClaimVisitId InsuranceClaimVisitId { get; }

    public InsuranceClaimVisitCreatedEvent(InsuranceClaimVisitId insuranceclaimvisitId)
    {
        InsuranceClaimVisitId = insuranceclaimvisitId;
    }
}

public sealed class InsuranceClaimVisitUpdatedEvent : DomainEvent
{
    public InsuranceClaimVisitId InsuranceClaimVisitId { get; }

    public InsuranceClaimVisitUpdatedEvent(InsuranceClaimVisitId insuranceclaimvisitId)
    {
        InsuranceClaimVisitId = insuranceclaimvisitId;
    }
}

public sealed class InsuranceClaimVisitDeletedEvent : DomainEvent
{
    public InsuranceClaimVisitId InsuranceClaimVisitId { get; }

    public InsuranceClaimVisitDeletedEvent(InsuranceClaimVisitId insuranceclaimvisitId)
    {
        InsuranceClaimVisitId = insuranceclaimvisitId;
    }
}
}
