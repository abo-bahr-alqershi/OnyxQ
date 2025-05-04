using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to MedicalNetwork entity
/// </summary>
public sealed class MedicalNetworkCreatedEvent : DomainEvent
{
    public MedicalNetworkId MedicalNetworkId { get; }

    public MedicalNetworkCreatedEvent(MedicalNetworkId medicalnetworkId)
    {
        MedicalNetworkId = medicalnetworkId;
    }
}

public sealed class MedicalNetworkUpdatedEvent : DomainEvent
{
    public MedicalNetworkId MedicalNetworkId { get; }

    public MedicalNetworkUpdatedEvent(MedicalNetworkId medicalnetworkId)
    {
        MedicalNetworkId = medicalnetworkId;
    }
}

public sealed class MedicalNetworkDeletedEvent : DomainEvent
{
    public MedicalNetworkId MedicalNetworkId { get; }

    public MedicalNetworkDeletedEvent(MedicalNetworkId medicalnetworkId)
    {
        MedicalNetworkId = medicalnetworkId;
    }
}
}
