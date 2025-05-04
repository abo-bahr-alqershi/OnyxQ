using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to CompensationQuantitySetupDetail entity
/// </summary>
public sealed class CompensationQuantitySetupDetailCreatedEvent : DomainEvent
{
    public CompensationQuantitySetupDetailId CompensationQuantitySetupDetailId { get; }

    public CompensationQuantitySetupDetailCreatedEvent(CompensationQuantitySetupDetailId compensationquantitysetupdetailId)
    {
        CompensationQuantitySetupDetailId = compensationquantitysetupdetailId;
    }
}

public sealed class CompensationQuantitySetupDetailUpdatedEvent : DomainEvent
{
    public CompensationQuantitySetupDetailId CompensationQuantitySetupDetailId { get; }

    public CompensationQuantitySetupDetailUpdatedEvent(CompensationQuantitySetupDetailId compensationquantitysetupdetailId)
    {
        CompensationQuantitySetupDetailId = compensationquantitysetupdetailId;
    }
}

public sealed class CompensationQuantitySetupDetailDeletedEvent : DomainEvent
{
    public CompensationQuantitySetupDetailId CompensationQuantitySetupDetailId { get; }

    public CompensationQuantitySetupDetailDeletedEvent(CompensationQuantitySetupDetailId compensationquantitysetupdetailId)
    {
        CompensationQuantitySetupDetailId = compensationquantitysetupdetailId;
    }
}
}
