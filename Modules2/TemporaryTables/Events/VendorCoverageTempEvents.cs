using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to VendorCoverageTemp entity
/// </summary>
public sealed class VendorCoverageTempCreatedEvent : DomainEvent
{
    public VendorCoverageTempId VendorCoverageTempId { get; }

    public VendorCoverageTempCreatedEvent(VendorCoverageTempId vendorcoveragetempId)
    {
        VendorCoverageTempId = vendorcoveragetempId;
    }
}

public sealed class VendorCoverageTempUpdatedEvent : DomainEvent
{
    public VendorCoverageTempId VendorCoverageTempId { get; }

    public VendorCoverageTempUpdatedEvent(VendorCoverageTempId vendorcoveragetempId)
    {
        VendorCoverageTempId = vendorcoveragetempId;
    }
}

public sealed class VendorCoverageTempDeletedEvent : DomainEvent
{
    public VendorCoverageTempId VendorCoverageTempId { get; }

    public VendorCoverageTempDeletedEvent(VendorCoverageTempId vendorcoveragetempId)
    {
        VendorCoverageTempId = vendorcoveragetempId;
    }
}
}
