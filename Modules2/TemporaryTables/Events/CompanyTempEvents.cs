using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to CompanyTemp entity
/// </summary>
public sealed class CompanyTempCreatedEvent : DomainEvent
{
    public CompanyTempId CompanyTempId { get; }

    public CompanyTempCreatedEvent(CompanyTempId companytempId)
    {
        CompanyTempId = companytempId;
    }
}

public sealed class CompanyTempUpdatedEvent : DomainEvent
{
    public CompanyTempId CompanyTempId { get; }

    public CompanyTempUpdatedEvent(CompanyTempId companytempId)
    {
        CompanyTempId = companytempId;
    }
}

public sealed class CompanyTempDeletedEvent : DomainEvent
{
    public CompanyTempId CompanyTempId { get; }

    public CompanyTempDeletedEvent(CompanyTempId companytempId)
    {
        CompanyTempId = companytempId;
    }
}
}
