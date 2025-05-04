using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ReportUserTemplateMaster entity
/// </summary>
public sealed class ReportUserTemplateMasterCreatedEvent : DomainEvent
{
    public ReportUserTemplateMasterId ReportUserTemplateMasterId { get; }

    public ReportUserTemplateMasterCreatedEvent(ReportUserTemplateMasterId reportusertemplatemasterId)
    {
        ReportUserTemplateMasterId = reportusertemplatemasterId;
    }
}

public sealed class ReportUserTemplateMasterUpdatedEvent : DomainEvent
{
    public ReportUserTemplateMasterId ReportUserTemplateMasterId { get; }

    public ReportUserTemplateMasterUpdatedEvent(ReportUserTemplateMasterId reportusertemplatemasterId)
    {
        ReportUserTemplateMasterId = reportusertemplatemasterId;
    }
}

public sealed class ReportUserTemplateMasterDeletedEvent : DomainEvent
{
    public ReportUserTemplateMasterId ReportUserTemplateMasterId { get; }

    public ReportUserTemplateMasterDeletedEvent(ReportUserTemplateMasterId reportusertemplatemasterId)
    {
        ReportUserTemplateMasterId = reportusertemplatemasterId;
    }
}
}
