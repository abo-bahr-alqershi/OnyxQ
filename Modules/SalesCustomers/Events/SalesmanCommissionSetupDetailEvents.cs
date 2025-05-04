using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCommissionSetupDetail entity
/// </summary>
public sealed class SalesmanCommissionSetupDetailCreatedEvent : DomainEvent
{
    public SalesmanCommissionSetupDetailId SalesmanCommissionSetupDetailId { get; }

    public SalesmanCommissionSetupDetailCreatedEvent(SalesmanCommissionSetupDetailId salesmancommissionsetupdetailId)
    {
        SalesmanCommissionSetupDetailId = salesmancommissionsetupdetailId;
    }
}

public sealed class SalesmanCommissionSetupDetailUpdatedEvent : DomainEvent
{
    public SalesmanCommissionSetupDetailId SalesmanCommissionSetupDetailId { get; }

    public SalesmanCommissionSetupDetailUpdatedEvent(SalesmanCommissionSetupDetailId salesmancommissionsetupdetailId)
    {
        SalesmanCommissionSetupDetailId = salesmancommissionsetupdetailId;
    }
}

public sealed class SalesmanCommissionSetupDetailDeletedEvent : DomainEvent
{
    public SalesmanCommissionSetupDetailId SalesmanCommissionSetupDetailId { get; }

    public SalesmanCommissionSetupDetailDeletedEvent(SalesmanCommissionSetupDetailId salesmancommissionsetupdetailId)
    {
        SalesmanCommissionSetupDetailId = salesmancommissionsetupdetailId;
    }
}
}
