using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ScreenReportSample entity
/// </summary>
public sealed class ScreenReportSampleCreatedEvent : DomainEvent
{
    public ScreenReportSampleId ScreenReportSampleId { get; }

    public ScreenReportSampleCreatedEvent(ScreenReportSampleId screenreportsampleId)
    {
        ScreenReportSampleId = screenreportsampleId;
    }
}

public sealed class ScreenReportSampleUpdatedEvent : DomainEvent
{
    public ScreenReportSampleId ScreenReportSampleId { get; }

    public ScreenReportSampleUpdatedEvent(ScreenReportSampleId screenreportsampleId)
    {
        ScreenReportSampleId = screenreportsampleId;
    }
}

public sealed class ScreenReportSampleDeletedEvent : DomainEvent
{
    public ScreenReportSampleId ScreenReportSampleId { get; }

    public ScreenReportSampleDeletedEvent(ScreenReportSampleId screenreportsampleId)
    {
        ScreenReportSampleId = screenreportsampleId;
    }
}
}
