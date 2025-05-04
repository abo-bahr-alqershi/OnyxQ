using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ReportExtraParametersDetail entity
/// </summary>
public sealed class ReportExtraParametersDetailCreatedEvent : DomainEvent
{
    public ReportExtraParametersDetailId ReportExtraParametersDetailId { get; }

    public ReportExtraParametersDetailCreatedEvent(ReportExtraParametersDetailId reportextraparametersdetailId)
    {
        ReportExtraParametersDetailId = reportextraparametersdetailId;
    }
}

public sealed class ReportExtraParametersDetailUpdatedEvent : DomainEvent
{
    public ReportExtraParametersDetailId ReportExtraParametersDetailId { get; }

    public ReportExtraParametersDetailUpdatedEvent(ReportExtraParametersDetailId reportextraparametersdetailId)
    {
        ReportExtraParametersDetailId = reportextraparametersdetailId;
    }
}

public sealed class ReportExtraParametersDetailDeletedEvent : DomainEvent
{
    public ReportExtraParametersDetailId ReportExtraParametersDetailId { get; }

    public ReportExtraParametersDetailDeletedEvent(ReportExtraParametersDetailId reportextraparametersdetailId)
    {
        ReportExtraParametersDetailId = reportextraparametersdetailId;
    }
}
}
