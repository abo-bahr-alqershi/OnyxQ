using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceCardChronic entity
/// </summary>
public sealed class InsuranceCardChronicCreatedEvent : DomainEvent
{
    public InsuranceCardChronicId InsuranceCardChronicId { get; }

    public InsuranceCardChronicCreatedEvent(InsuranceCardChronicId insurancecardchronicId)
    {
        InsuranceCardChronicId = insurancecardchronicId;
    }
}

public sealed class InsuranceCardChronicUpdatedEvent : DomainEvent
{
    public InsuranceCardChronicId InsuranceCardChronicId { get; }

    public InsuranceCardChronicUpdatedEvent(InsuranceCardChronicId insurancecardchronicId)
    {
        InsuranceCardChronicId = insurancecardchronicId;
    }
}

public sealed class InsuranceCardChronicDeletedEvent : DomainEvent
{
    public InsuranceCardChronicId InsuranceCardChronicId { get; }

    public InsuranceCardChronicDeletedEvent(InsuranceCardChronicId insurancecardchronicId)
    {
        InsuranceCardChronicId = insurancecardchronicId;
    }
}
}
