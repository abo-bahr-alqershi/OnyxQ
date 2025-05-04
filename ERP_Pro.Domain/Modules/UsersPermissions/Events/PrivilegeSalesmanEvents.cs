using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.UsersPermissions.ValueObjects;

namespace ERP_Pro.Domain.ERP.UsersPermissions.Events
{
/// <summary>
/// Events related to PrivilegeSalesman entity
/// </summary>
public sealed class PrivilegeSalesmanCreatedEvent : DomainEvent
{
    public PrivilegeSalesmanId PrivilegeSalesmanId { get; }

    public PrivilegeSalesmanCreatedEvent(PrivilegeSalesmanId privilegesalesmanId)
    {
        PrivilegeSalesmanId = privilegesalesmanId;
    }
}

public sealed class PrivilegeSalesmanUpdatedEvent : DomainEvent
{
    public PrivilegeSalesmanId PrivilegeSalesmanId { get; }

    public PrivilegeSalesmanUpdatedEvent(PrivilegeSalesmanId privilegesalesmanId)
    {
        PrivilegeSalesmanId = privilegesalesmanId;
    }
}

public sealed class PrivilegeSalesmanDeletedEvent : DomainEvent
{
    public PrivilegeSalesmanId PrivilegeSalesmanId { get; }

    public PrivilegeSalesmanDeletedEvent(PrivilegeSalesmanId privilegesalesmanId)
    {
        PrivilegeSalesmanId = privilegesalesmanId;
    }
}
}
