using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesPlanMaster entity
/// </summary>
public sealed class SalesPlanMasterCreatedEvent : DomainEvent
{
    public SalesPlanMasterId SalesPlanMasterId { get; }

    public SalesPlanMasterCreatedEvent(SalesPlanMasterId salesplanmasterId)
    {
        SalesPlanMasterId = salesplanmasterId;
    }
}

public sealed class SalesPlanMasterUpdatedEvent : DomainEvent
{
    public SalesPlanMasterId SalesPlanMasterId { get; }

    public SalesPlanMasterUpdatedEvent(SalesPlanMasterId salesplanmasterId)
    {
        SalesPlanMasterId = salesplanmasterId;
    }
}

public sealed class SalesPlanMasterDeletedEvent : DomainEvent
{
    public SalesPlanMasterId SalesPlanMasterId { get; }

    public SalesPlanMasterDeletedEvent(SalesPlanMasterId salesplanmasterId)
    {
        SalesPlanMasterId = salesplanmasterId;
    }
}
}
