using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Events
{
/// <summary>
/// Events related to Country entity
/// </summary>
public sealed class CountryCreatedEvent : DomainEvent
{
    public CountryId CountryId { get; }

    public CountryCreatedEvent(CountryId countryId)
    {
        CountryId = countryId;
    }
}

public sealed class CountryUpdatedEvent : DomainEvent
{
    public CountryId CountryId { get; }

    public CountryUpdatedEvent(CountryId countryId)
    {
        CountryId = countryId;
    }
}

public sealed class CountryDeletedEvent : DomainEvent
{
    public CountryId CountryId { get; }

    public CountryDeletedEvent(CountryId countryId)
    {
        CountryId = countryId;
    }
}
}
