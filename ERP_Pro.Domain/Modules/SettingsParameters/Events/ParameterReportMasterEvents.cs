using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to ParameterReportMaster entity
/// </summary>
public sealed class ParameterReportMasterCreatedEvent : DomainEvent
{
    public ParameterReportMasterId ParameterReportMasterId { get; }

    public ParameterReportMasterCreatedEvent(ParameterReportMasterId parameterreportmasterId)
    {
        ParameterReportMasterId = parameterreportmasterId;
    }
}

public sealed class ParameterReportMasterUpdatedEvent : DomainEvent
{
    public ParameterReportMasterId ParameterReportMasterId { get; }

    public ParameterReportMasterUpdatedEvent(ParameterReportMasterId parameterreportmasterId)
    {
        ParameterReportMasterId = parameterreportmasterId;
    }
}

public sealed class ParameterReportMasterDeletedEvent : DomainEvent
{
    public ParameterReportMasterId ParameterReportMasterId { get; }

    public ParameterReportMasterDeletedEvent(ParameterReportMasterId parameterreportmasterId)
    {
        ParameterReportMasterId = parameterreportmasterId;
    }
}
}
