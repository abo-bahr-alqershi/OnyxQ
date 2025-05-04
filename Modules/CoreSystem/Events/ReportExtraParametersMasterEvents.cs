using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ReportExtraParametersMaster entity
/// </summary>
public sealed class ReportExtraParametersMasterCreatedEvent : DomainEvent
{
    public ReportExtraParametersMasterId ReportExtraParametersMasterId { get; }

    public ReportExtraParametersMasterCreatedEvent(ReportExtraParametersMasterId reportextraparametersmasterId)
    {
        ReportExtraParametersMasterId = reportextraparametersmasterId;
    }
}

public sealed class ReportExtraParametersMasterUpdatedEvent : DomainEvent
{
    public ReportExtraParametersMasterId ReportExtraParametersMasterId { get; }

    public ReportExtraParametersMasterUpdatedEvent(ReportExtraParametersMasterId reportextraparametersmasterId)
    {
        ReportExtraParametersMasterId = reportextraparametersmasterId;
    }
}

public sealed class ReportExtraParametersMasterDeletedEvent : DomainEvent
{
    public ReportExtraParametersMasterId ReportExtraParametersMasterId { get; }

    public ReportExtraParametersMasterDeletedEvent(ReportExtraParametersMasterId reportextraparametersmasterId)
    {
        ReportExtraParametersMasterId = reportextraparametersmasterId;
    }
}
}
