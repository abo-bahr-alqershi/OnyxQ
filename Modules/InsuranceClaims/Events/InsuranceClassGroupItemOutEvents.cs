using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceClassGroupItemOut entity
/// </summary>
public sealed class InsuranceClassGroupItemOutCreatedEvent : DomainEvent
{
    public InsuranceClassGroupItemOutId InsuranceClassGroupItemOutId { get; }

    public InsuranceClassGroupItemOutCreatedEvent(InsuranceClassGroupItemOutId insuranceclassgroupitemoutId)
    {
        InsuranceClassGroupItemOutId = insuranceclassgroupitemoutId;
    }
}

public sealed class InsuranceClassGroupItemOutUpdatedEvent : DomainEvent
{
    public InsuranceClassGroupItemOutId InsuranceClassGroupItemOutId { get; }

    public InsuranceClassGroupItemOutUpdatedEvent(InsuranceClassGroupItemOutId insuranceclassgroupitemoutId)
    {
        InsuranceClassGroupItemOutId = insuranceclassgroupitemoutId;
    }
}

public sealed class InsuranceClassGroupItemOutDeletedEvent : DomainEvent
{
    public InsuranceClassGroupItemOutId InsuranceClassGroupItemOutId { get; }

    public InsuranceClassGroupItemOutDeletedEvent(InsuranceClassGroupItemOutId insuranceclassgroupitemoutId)
    {
        InsuranceClassGroupItemOutId = insuranceclassgroupitemoutId;
    }
}
}
