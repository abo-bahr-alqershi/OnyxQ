using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ReportUserTemplateDetail entity
/// </summary>
public sealed class ReportUserTemplateDetailCreatedEvent : DomainEvent
{
    public ReportUserTemplateDetailId ReportUserTemplateDetailId { get; }

    public ReportUserTemplateDetailCreatedEvent(ReportUserTemplateDetailId reportusertemplatedetailId)
    {
        ReportUserTemplateDetailId = reportusertemplatedetailId;
    }
}

public sealed class ReportUserTemplateDetailUpdatedEvent : DomainEvent
{
    public ReportUserTemplateDetailId ReportUserTemplateDetailId { get; }

    public ReportUserTemplateDetailUpdatedEvent(ReportUserTemplateDetailId reportusertemplatedetailId)
    {
        ReportUserTemplateDetailId = reportusertemplatedetailId;
    }
}

public sealed class ReportUserTemplateDetailDeletedEvent : DomainEvent
{
    public ReportUserTemplateDetailId ReportUserTemplateDetailId { get; }

    public ReportUserTemplateDetailDeletedEvent(ReportUserTemplateDetailId reportusertemplatedetailId)
    {
        ReportUserTemplateDetailId = reportusertemplatedetailId;
    }
}
}
