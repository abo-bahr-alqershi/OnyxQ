using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceClassMedicalNetwork entity
/// </summary>
public sealed class InsuranceClassMedicalNetworkCreatedEvent : DomainEvent
{
    public InsuranceClassMedicalNetworkId InsuranceClassMedicalNetworkId { get; }

    public InsuranceClassMedicalNetworkCreatedEvent(InsuranceClassMedicalNetworkId insuranceclassmedicalnetworkId)
    {
        InsuranceClassMedicalNetworkId = insuranceclassmedicalnetworkId;
    }
}

public sealed class InsuranceClassMedicalNetworkUpdatedEvent : DomainEvent
{
    public InsuranceClassMedicalNetworkId InsuranceClassMedicalNetworkId { get; }

    public InsuranceClassMedicalNetworkUpdatedEvent(InsuranceClassMedicalNetworkId insuranceclassmedicalnetworkId)
    {
        InsuranceClassMedicalNetworkId = insuranceclassmedicalnetworkId;
    }
}

public sealed class InsuranceClassMedicalNetworkDeletedEvent : DomainEvent
{
    public InsuranceClassMedicalNetworkId InsuranceClassMedicalNetworkId { get; }

    public InsuranceClassMedicalNetworkDeletedEvent(InsuranceClassMedicalNetworkId insuranceclassmedicalnetworkId)
    {
        InsuranceClassMedicalNetworkId = insuranceclassmedicalnetworkId;
    }
}
}
