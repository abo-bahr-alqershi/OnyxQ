using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to CompensationQuantitySetupMaster entity
/// </summary>
public sealed class CompensationQuantitySetupMasterCreatedEvent : DomainEvent
{
    public CompensationQuantitySetupMasterId CompensationQuantitySetupMasterId { get; }

    public CompensationQuantitySetupMasterCreatedEvent(CompensationQuantitySetupMasterId compensationquantitysetupmasterId)
    {
        CompensationQuantitySetupMasterId = compensationquantitysetupmasterId;
    }
}

public sealed class CompensationQuantitySetupMasterUpdatedEvent : DomainEvent
{
    public CompensationQuantitySetupMasterId CompensationQuantitySetupMasterId { get; }

    public CompensationQuantitySetupMasterUpdatedEvent(CompensationQuantitySetupMasterId compensationquantitysetupmasterId)
    {
        CompensationQuantitySetupMasterId = compensationquantitysetupmasterId;
    }
}

public sealed class CompensationQuantitySetupMasterDeletedEvent : DomainEvent
{
    public CompensationQuantitySetupMasterId CompensationQuantitySetupMasterId { get; }

    public CompensationQuantitySetupMasterDeletedEvent(CompensationQuantitySetupMasterId compensationquantitysetupmasterId)
    {
        CompensationQuantitySetupMasterId = compensationquantitysetupmasterId;
    }
}
}
