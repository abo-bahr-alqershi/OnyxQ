using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCommissionSlice entity
/// </summary>
public sealed class SalesmanCommissionSliceCreatedEvent : DomainEvent
{
    public SalesmanCommissionSliceId SalesmanCommissionSliceId { get; }

    public SalesmanCommissionSliceCreatedEvent(SalesmanCommissionSliceId salesmancommissionsliceId)
    {
        SalesmanCommissionSliceId = salesmancommissionsliceId;
    }
}

public sealed class SalesmanCommissionSliceUpdatedEvent : DomainEvent
{
    public SalesmanCommissionSliceId SalesmanCommissionSliceId { get; }

    public SalesmanCommissionSliceUpdatedEvent(SalesmanCommissionSliceId salesmancommissionsliceId)
    {
        SalesmanCommissionSliceId = salesmancommissionsliceId;
    }
}

public sealed class SalesmanCommissionSliceDeletedEvent : DomainEvent
{
    public SalesmanCommissionSliceId SalesmanCommissionSliceId { get; }

    public SalesmanCommissionSliceDeletedEvent(SalesmanCommissionSliceId salesmancommissionsliceId)
    {
        SalesmanCommissionSliceId = salesmancommissionsliceId;
    }
}
}
