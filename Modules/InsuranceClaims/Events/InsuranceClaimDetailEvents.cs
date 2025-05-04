using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceClaimDetail entity
/// </summary>
public sealed class InsuranceClaimDetailCreatedEvent : DomainEvent
{
    public InsuranceClaimDetailId InsuranceClaimDetailId { get; }

    public InsuranceClaimDetailCreatedEvent(InsuranceClaimDetailId insuranceclaimdetailId)
    {
        InsuranceClaimDetailId = insuranceclaimdetailId;
    }
}

public sealed class InsuranceClaimDetailUpdatedEvent : DomainEvent
{
    public InsuranceClaimDetailId InsuranceClaimDetailId { get; }

    public InsuranceClaimDetailUpdatedEvent(InsuranceClaimDetailId insuranceclaimdetailId)
    {
        InsuranceClaimDetailId = insuranceclaimdetailId;
    }
}

public sealed class InsuranceClaimDetailDeletedEvent : DomainEvent
{
    public InsuranceClaimDetailId InsuranceClaimDetailId { get; }

    public InsuranceClaimDetailDeletedEvent(InsuranceClaimDetailId insuranceclaimdetailId)
    {
        InsuranceClaimDetailId = insuranceclaimdetailId;
    }
}
}
