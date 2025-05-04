using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ServicesMaintenance.Events
{
/// <summary>
/// Events related to BranchCargoService entity
/// </summary>
public sealed class BranchCargoServiceCreatedEvent : DomainEvent
{
    public BranchCargoServiceId BranchCargoServiceId { get; }

    public BranchCargoServiceCreatedEvent(BranchCargoServiceId branchcargoserviceId)
    {
        BranchCargoServiceId = branchcargoserviceId;
    }
}

public sealed class BranchCargoServiceUpdatedEvent : DomainEvent
{
    public BranchCargoServiceId BranchCargoServiceId { get; }

    public BranchCargoServiceUpdatedEvent(BranchCargoServiceId branchcargoserviceId)
    {
        BranchCargoServiceId = branchcargoserviceId;
    }
}

public sealed class BranchCargoServiceDeletedEvent : DomainEvent
{
    public BranchCargoServiceId BranchCargoServiceId { get; }

    public BranchCargoServiceDeletedEvent(BranchCargoServiceId branchcargoserviceId)
    {
        BranchCargoServiceId = branchcargoserviceId;
    }
}
}
