using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceClaimMaster entity
/// </summary>
public sealed class InsuranceClaimMasterCreatedEvent : DomainEvent
{
    public InsuranceClaimMasterId InsuranceClaimMasterId { get; }

    public InsuranceClaimMasterCreatedEvent(InsuranceClaimMasterId insuranceclaimmasterId)
    {
        InsuranceClaimMasterId = insuranceclaimmasterId;
    }
}

public sealed class InsuranceClaimMasterUpdatedEvent : DomainEvent
{
    public InsuranceClaimMasterId InsuranceClaimMasterId { get; }

    public InsuranceClaimMasterUpdatedEvent(InsuranceClaimMasterId insuranceclaimmasterId)
    {
        InsuranceClaimMasterId = insuranceclaimmasterId;
    }
}

public sealed class InsuranceClaimMasterDeletedEvent : DomainEvent
{
    public InsuranceClaimMasterId InsuranceClaimMasterId { get; }

    public InsuranceClaimMasterDeletedEvent(InsuranceClaimMasterId insuranceclaimmasterId)
    {
        InsuranceClaimMasterId = insuranceclaimmasterId;
    }
}
}
