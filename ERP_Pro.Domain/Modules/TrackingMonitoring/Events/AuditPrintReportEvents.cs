using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Events
{
/// <summary>
/// Events related to AuditPrintReport entity
/// </summary>
public sealed class AuditPrintReportCreatedEvent : DomainEvent
{
    public AuditPrintReportId AuditPrintReportId { get; }

    public AuditPrintReportCreatedEvent(AuditPrintReportId auditprintreportId)
    {
        AuditPrintReportId = auditprintreportId;
    }
}

public sealed class AuditPrintReportUpdatedEvent : DomainEvent
{
    public AuditPrintReportId AuditPrintReportId { get; }

    public AuditPrintReportUpdatedEvent(AuditPrintReportId auditprintreportId)
    {
        AuditPrintReportId = auditprintreportId;
    }
}

public sealed class AuditPrintReportDeletedEvent : DomainEvent
{
    public AuditPrintReportId AuditPrintReportId { get; }

    public AuditPrintReportDeletedEvent(AuditPrintReportId auditprintreportId)
    {
        AuditPrintReportId = auditprintreportId;
    }
}
}
