using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to ParameterReportDetail entity
/// </summary>
public sealed class ParameterReportDetailCreatedEvent : DomainEvent
{
    public ParameterReportDetailId ParameterReportDetailId { get; }

    public ParameterReportDetailCreatedEvent(ParameterReportDetailId parameterreportdetailId)
    {
        ParameterReportDetailId = parameterreportdetailId;
    }
}

public sealed class ParameterReportDetailUpdatedEvent : DomainEvent
{
    public ParameterReportDetailId ParameterReportDetailId { get; }

    public ParameterReportDetailUpdatedEvent(ParameterReportDetailId parameterreportdetailId)
    {
        ParameterReportDetailId = parameterreportdetailId;
    }
}

public sealed class ParameterReportDetailDeletedEvent : DomainEvent
{
    public ParameterReportDetailId ParameterReportDetailId { get; }

    public ParameterReportDetailDeletedEvent(ParameterReportDetailId parameterreportdetailId)
    {
        ParameterReportDetailId = parameterreportdetailId;
    }
}
}
