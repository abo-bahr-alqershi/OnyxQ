using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to CompanyVerticalTemp entity
/// </summary>
public sealed class CompanyVerticalTempCreatedEvent : DomainEvent
{
    public CompanyVerticalTempId CompanyVerticalTempId { get; }

    public CompanyVerticalTempCreatedEvent(CompanyVerticalTempId companyverticaltempId)
    {
        CompanyVerticalTempId = companyverticaltempId;
    }
}

public sealed class CompanyVerticalTempUpdatedEvent : DomainEvent
{
    public CompanyVerticalTempId CompanyVerticalTempId { get; }

    public CompanyVerticalTempUpdatedEvent(CompanyVerticalTempId companyverticaltempId)
    {
        CompanyVerticalTempId = companyverticaltempId;
    }
}

public sealed class CompanyVerticalTempDeletedEvent : DomainEvent
{
    public CompanyVerticalTempId CompanyVerticalTempId { get; }

    public CompanyVerticalTempDeletedEvent(CompanyVerticalTempId companyverticaltempId)
    {
        CompanyVerticalTempId = companyverticaltempId;
    }
}
}
