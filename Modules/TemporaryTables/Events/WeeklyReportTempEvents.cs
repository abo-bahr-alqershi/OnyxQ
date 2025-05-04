using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to WeeklyReportTemp entity
/// </summary>
public sealed class WeeklyReportTempCreatedEvent : DomainEvent
{
    public WeeklyReportTempId WeeklyReportTempId { get; }

    public WeeklyReportTempCreatedEvent(WeeklyReportTempId weeklyreporttempId)
    {
        WeeklyReportTempId = weeklyreporttempId;
    }
}

public sealed class WeeklyReportTempUpdatedEvent : DomainEvent
{
    public WeeklyReportTempId WeeklyReportTempId { get; }

    public WeeklyReportTempUpdatedEvent(WeeklyReportTempId weeklyreporttempId)
    {
        WeeklyReportTempId = weeklyreporttempId;
    }
}

public sealed class WeeklyReportTempDeletedEvent : DomainEvent
{
    public WeeklyReportTempId WeeklyReportTempId { get; }

    public WeeklyReportTempDeletedEvent(WeeklyReportTempId weeklyreporttempId)
    {
        WeeklyReportTempId = weeklyreporttempId;
    }
}
}
