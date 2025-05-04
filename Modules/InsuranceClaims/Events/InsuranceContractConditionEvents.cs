using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceContractCondition entity
/// </summary>
public sealed class InsuranceContractConditionCreatedEvent : DomainEvent
{
    public InsuranceContractConditionId InsuranceContractConditionId { get; }

    public InsuranceContractConditionCreatedEvent(InsuranceContractConditionId insurancecontractconditionId)
    {
        InsuranceContractConditionId = insurancecontractconditionId;
    }
}

public sealed class InsuranceContractConditionUpdatedEvent : DomainEvent
{
    public InsuranceContractConditionId InsuranceContractConditionId { get; }

    public InsuranceContractConditionUpdatedEvent(InsuranceContractConditionId insurancecontractconditionId)
    {
        InsuranceContractConditionId = insurancecontractconditionId;
    }
}

public sealed class InsuranceContractConditionDeletedEvent : DomainEvent
{
    public InsuranceContractConditionId InsuranceContractConditionId { get; }

    public InsuranceContractConditionDeletedEvent(InsuranceContractConditionId insurancecontractconditionId)
    {
        InsuranceContractConditionId = insurancecontractconditionId;
    }
}
}
