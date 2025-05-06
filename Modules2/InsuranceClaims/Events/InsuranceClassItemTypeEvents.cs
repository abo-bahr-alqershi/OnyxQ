using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceClassItemType entity
/// </summary>
public sealed class InsuranceClassItemTypeCreatedEvent : DomainEvent
{
    public InsuranceClassItemTypeId InsuranceClassItemTypeId { get; }

    public InsuranceClassItemTypeCreatedEvent(InsuranceClassItemTypeId insuranceclassitemtypeId)
    {
        InsuranceClassItemTypeId = insuranceclassitemtypeId;
    }
}

public sealed class InsuranceClassItemTypeUpdatedEvent : DomainEvent
{
    public InsuranceClassItemTypeId InsuranceClassItemTypeId { get; }

    public InsuranceClassItemTypeUpdatedEvent(InsuranceClassItemTypeId insuranceclassitemtypeId)
    {
        InsuranceClassItemTypeId = insuranceclassitemtypeId;
    }
}

public sealed class InsuranceClassItemTypeDeletedEvent : DomainEvent
{
    public InsuranceClassItemTypeId InsuranceClassItemTypeId { get; }

    public InsuranceClassItemTypeDeletedEvent(InsuranceClassItemTypeId insuranceclassitemtypeId)
    {
        InsuranceClassItemTypeId = insuranceclassitemtypeId;
    }
}
}
