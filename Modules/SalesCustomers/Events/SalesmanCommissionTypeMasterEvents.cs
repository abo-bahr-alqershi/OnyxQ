using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCommissionTypeMaster entity
/// </summary>
public sealed class SalesmanCommissionTypeMasterCreatedEvent : DomainEvent
{
    public SalesmanCommissionTypeMasterId SalesmanCommissionTypeMasterId { get; }

    public SalesmanCommissionTypeMasterCreatedEvent(SalesmanCommissionTypeMasterId salesmancommissiontypemasterId)
    {
        SalesmanCommissionTypeMasterId = salesmancommissiontypemasterId;
    }
}

public sealed class SalesmanCommissionTypeMasterUpdatedEvent : DomainEvent
{
    public SalesmanCommissionTypeMasterId SalesmanCommissionTypeMasterId { get; }

    public SalesmanCommissionTypeMasterUpdatedEvent(SalesmanCommissionTypeMasterId salesmancommissiontypemasterId)
    {
        SalesmanCommissionTypeMasterId = salesmancommissiontypemasterId;
    }
}

public sealed class SalesmanCommissionTypeMasterDeletedEvent : DomainEvent
{
    public SalesmanCommissionTypeMasterId SalesmanCommissionTypeMasterId { get; }

    public SalesmanCommissionTypeMasterDeletedEvent(SalesmanCommissionTypeMasterId salesmancommissiontypemasterId)
    {
        SalesmanCommissionTypeMasterId = salesmancommissiontypemasterId;
    }
}
}
