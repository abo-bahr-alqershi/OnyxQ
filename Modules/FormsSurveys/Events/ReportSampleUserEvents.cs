using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to ReportSampleUser entity
/// </summary>
public sealed class ReportSampleUserCreatedEvent : DomainEvent
{
    public ReportSampleUserId ReportSampleUserId { get; }

    public ReportSampleUserCreatedEvent(ReportSampleUserId reportsampleuserId)
    {
        ReportSampleUserId = reportsampleuserId;
    }
}

public sealed class ReportSampleUserUpdatedEvent : DomainEvent
{
    public ReportSampleUserId ReportSampleUserId { get; }

    public ReportSampleUserUpdatedEvent(ReportSampleUserId reportsampleuserId)
    {
        ReportSampleUserId = reportsampleuserId;
    }
}

public sealed class ReportSampleUserDeletedEvent : DomainEvent
{
    public ReportSampleUserId ReportSampleUserId { get; }

    public ReportSampleUserDeletedEvent(ReportSampleUserId reportsampleuserId)
    {
        ReportSampleUserId = reportsampleuserId;
    }
}
}
