using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ServicesMaintenance.Events
{
/// <summary>
/// Events related to CargoService entity
/// </summary>
public sealed class CargoServiceCreatedEvent : DomainEvent
{
    public CargoServiceId CargoServiceId { get; }

    public CargoServiceCreatedEvent(CargoServiceId cargoserviceId)
    {
        CargoServiceId = cargoserviceId;
    }
}

public sealed class CargoServiceUpdatedEvent : DomainEvent
{
    public CargoServiceId CargoServiceId { get; }

    public CargoServiceUpdatedEvent(CargoServiceId cargoserviceId)
    {
        CargoServiceId = cargoserviceId;
    }
}

public sealed class CargoServiceDeletedEvent : DomainEvent
{
    public CargoServiceId CargoServiceId { get; }

    public CargoServiceDeletedEvent(CargoServiceId cargoserviceId)
    {
        CargoServiceId = cargoserviceId;
    }
}
}
