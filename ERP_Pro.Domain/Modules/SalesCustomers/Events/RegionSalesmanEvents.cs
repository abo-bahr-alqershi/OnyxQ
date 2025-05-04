using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to RegionSalesman entity
/// </summary>
public sealed class RegionSalesmanCreatedEvent : DomainEvent
{
    public RegionSalesmanId RegionSalesmanId { get; }

    public RegionSalesmanCreatedEvent(RegionSalesmanId regionsalesmanId)
    {
        RegionSalesmanId = regionsalesmanId;
    }
}

public sealed class RegionSalesmanUpdatedEvent : DomainEvent
{
    public RegionSalesmanId RegionSalesmanId { get; }

    public RegionSalesmanUpdatedEvent(RegionSalesmanId regionsalesmanId)
    {
        RegionSalesmanId = regionsalesmanId;
    }
}

public sealed class RegionSalesmanDeletedEvent : DomainEvent
{
    public RegionSalesmanId RegionSalesmanId { get; }

    public RegionSalesmanDeletedEvent(RegionSalesmanId regionsalesmanId)
    {
        RegionSalesmanId = regionsalesmanId;
    }
}
}
