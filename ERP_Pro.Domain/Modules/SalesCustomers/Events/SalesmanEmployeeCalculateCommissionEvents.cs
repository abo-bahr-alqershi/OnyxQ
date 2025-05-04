using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanEmployeeCalculateCommission entity
/// </summary>
public sealed class SalesmanEmployeeCalculateCommissionCreatedEvent : DomainEvent
{
    public SalesmanEmployeeCalculateCommissionId SalesmanEmployeeCalculateCommissionId { get; }

    public SalesmanEmployeeCalculateCommissionCreatedEvent(SalesmanEmployeeCalculateCommissionId salesmanemployeecalculatecommissionId)
    {
        SalesmanEmployeeCalculateCommissionId = salesmanemployeecalculatecommissionId;
    }
}

public sealed class SalesmanEmployeeCalculateCommissionUpdatedEvent : DomainEvent
{
    public SalesmanEmployeeCalculateCommissionId SalesmanEmployeeCalculateCommissionId { get; }

    public SalesmanEmployeeCalculateCommissionUpdatedEvent(SalesmanEmployeeCalculateCommissionId salesmanemployeecalculatecommissionId)
    {
        SalesmanEmployeeCalculateCommissionId = salesmanemployeecalculatecommissionId;
    }
}

public sealed class SalesmanEmployeeCalculateCommissionDeletedEvent : DomainEvent
{
    public SalesmanEmployeeCalculateCommissionId SalesmanEmployeeCalculateCommissionId { get; }

    public SalesmanEmployeeCalculateCommissionDeletedEvent(SalesmanEmployeeCalculateCommissionId salesmanemployeecalculatecommissionId)
    {
        SalesmanEmployeeCalculateCommissionId = salesmanemployeecalculatecommissionId;
    }
}
}
