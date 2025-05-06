using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to BranchYearsTemp entity
/// </summary>
public sealed class BranchYearsTempCreatedEvent : DomainEvent
{
    public BranchYearsTempId BranchYearsTempId { get; }

    public BranchYearsTempCreatedEvent(BranchYearsTempId branchyearstempId)
    {
        BranchYearsTempId = branchyearstempId;
    }
}

public sealed class BranchYearsTempUpdatedEvent : DomainEvent
{
    public BranchYearsTempId BranchYearsTempId { get; }

    public BranchYearsTempUpdatedEvent(BranchYearsTempId branchyearstempId)
    {
        BranchYearsTempId = branchyearstempId;
    }
}

public sealed class BranchYearsTempDeletedEvent : DomainEvent
{
    public BranchYearsTempId BranchYearsTempId { get; }

    public BranchYearsTempDeletedEvent(BranchYearsTempId branchyearstempId)
    {
        BranchYearsTempId = branchyearstempId;
    }
}
}
