using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCommissionTypeDetail entity
/// </summary>
public sealed class SalesmanCommissionTypeDetailCreatedEvent : DomainEvent
{
    public SalesmanCommissionTypeDetailId SalesmanCommissionTypeDetailId { get; }

    public SalesmanCommissionTypeDetailCreatedEvent(SalesmanCommissionTypeDetailId salesmancommissiontypedetailId)
    {
        SalesmanCommissionTypeDetailId = salesmancommissiontypedetailId;
    }
}

public sealed class SalesmanCommissionTypeDetailUpdatedEvent : DomainEvent
{
    public SalesmanCommissionTypeDetailId SalesmanCommissionTypeDetailId { get; }

    public SalesmanCommissionTypeDetailUpdatedEvent(SalesmanCommissionTypeDetailId salesmancommissiontypedetailId)
    {
        SalesmanCommissionTypeDetailId = salesmancommissiontypedetailId;
    }
}

public sealed class SalesmanCommissionTypeDetailDeletedEvent : DomainEvent
{
    public SalesmanCommissionTypeDetailId SalesmanCommissionTypeDetailId { get; }

    public SalesmanCommissionTypeDetailDeletedEvent(SalesmanCommissionTypeDetailId salesmancommissiontypedetailId)
    {
        SalesmanCommissionTypeDetailId = salesmancommissiontypedetailId;
    }
}
}
