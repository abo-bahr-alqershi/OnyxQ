using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceContractConditionBill entity
/// </summary>
public sealed class InsuranceContractConditionBillCreatedEvent : DomainEvent
{
    public InsuranceContractConditionBillId InsuranceContractConditionBillId { get; }

    public InsuranceContractConditionBillCreatedEvent(InsuranceContractConditionBillId insurancecontractconditionbillId)
    {
        InsuranceContractConditionBillId = insurancecontractconditionbillId;
    }
}

public sealed class InsuranceContractConditionBillUpdatedEvent : DomainEvent
{
    public InsuranceContractConditionBillId InsuranceContractConditionBillId { get; }

    public InsuranceContractConditionBillUpdatedEvent(InsuranceContractConditionBillId insurancecontractconditionbillId)
    {
        InsuranceContractConditionBillId = insurancecontractconditionbillId;
    }
}

public sealed class InsuranceContractConditionBillDeletedEvent : DomainEvent
{
    public InsuranceContractConditionBillId InsuranceContractConditionBillId { get; }

    public InsuranceContractConditionBillDeletedEvent(InsuranceContractConditionBillId insurancecontractconditionbillId)
    {
        InsuranceContractConditionBillId = insurancecontractconditionbillId;
    }
}
}
