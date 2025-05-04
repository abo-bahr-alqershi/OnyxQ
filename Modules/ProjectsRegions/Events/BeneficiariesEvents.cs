using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to Beneficiaries entity
/// </summary>
public sealed class BeneficiariesCreatedEvent : DomainEvent
{
    public BeneficiariesId BeneficiariesId { get; }

    public BeneficiariesCreatedEvent(BeneficiariesId beneficiariesId)
    {
        BeneficiariesId = beneficiariesId;
    }
}

public sealed class BeneficiariesUpdatedEvent : DomainEvent
{
    public BeneficiariesId BeneficiariesId { get; }

    public BeneficiariesUpdatedEvent(BeneficiariesId beneficiariesId)
    {
        BeneficiariesId = beneficiariesId;
    }
}

public sealed class BeneficiariesDeletedEvent : DomainEvent
{
    public BeneficiariesId BeneficiariesId { get; }

    public BeneficiariesDeletedEvent(BeneficiariesId beneficiariesId)
    {
        BeneficiariesId = beneficiariesId;
    }
}
}
