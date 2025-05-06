using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to Company entity
/// </summary>
public sealed class CompanyCreatedEvent : DomainEvent
{
    public CompanyId CompanyId { get; }

    public CompanyCreatedEvent(CompanyId companyId)
    {
        CompanyId = companyId;
    }
}

public sealed class CompanyUpdatedEvent : DomainEvent
{
    public CompanyId CompanyId { get; }

    public CompanyUpdatedEvent(CompanyId companyId)
    {
        CompanyId = companyId;
    }
}

public sealed class CompanyDeletedEvent : DomainEvent
{
    public CompanyId CompanyId { get; }

    public CompanyDeletedEvent(CompanyId companyId)
    {
        CompanyId = companyId;
    }
}
}
