using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to GstReportDetail entity
/// </summary>
public sealed class GstReportDetailCreatedEvent : DomainEvent
{
    public GstReportDetailId GstReportDetailId { get; }

    public GstReportDetailCreatedEvent(GstReportDetailId gstreportdetailId)
    {
        GstReportDetailId = gstreportdetailId;
    }
}

public sealed class GstReportDetailUpdatedEvent : DomainEvent
{
    public GstReportDetailId GstReportDetailId { get; }

    public GstReportDetailUpdatedEvent(GstReportDetailId gstreportdetailId)
    {
        GstReportDetailId = gstreportdetailId;
    }
}

public sealed class GstReportDetailDeletedEvent : DomainEvent
{
    public GstReportDetailId GstReportDetailId { get; }

    public GstReportDetailDeletedEvent(GstReportDetailId gstreportdetailId)
    {
        GstReportDetailId = gstreportdetailId;
    }
}
}
