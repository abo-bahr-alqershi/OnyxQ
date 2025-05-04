using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to AuditReportTemp entity
/// </summary>
public sealed class AuditReportTempCreatedEvent : DomainEvent
{
    public AuditReportTempId AuditReportTempId { get; }

    public AuditReportTempCreatedEvent(AuditReportTempId auditreporttempId)
    {
        AuditReportTempId = auditreporttempId;
    }
}

public sealed class AuditReportTempUpdatedEvent : DomainEvent
{
    public AuditReportTempId AuditReportTempId { get; }

    public AuditReportTempUpdatedEvent(AuditReportTempId auditreporttempId)
    {
        AuditReportTempId = auditreporttempId;
    }
}

public sealed class AuditReportTempDeletedEvent : DomainEvent
{
    public AuditReportTempId AuditReportTempId { get; }

    public AuditReportTempDeletedEvent(AuditReportTempId auditreporttempId)
    {
        AuditReportTempId = auditreporttempId;
    }
}
}
