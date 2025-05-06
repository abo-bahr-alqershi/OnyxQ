using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TaxFees.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Events
{
/// <summary>
/// Events related to GstReportMaster entity
/// </summary>
public sealed class GstReportMasterCreatedEvent : DomainEvent
{
    public GstReportMasterId GstReportMasterId { get; }

    public GstReportMasterCreatedEvent(GstReportMasterId gstreportmasterId)
    {
        GstReportMasterId = gstreportmasterId;
    }
}

public sealed class GstReportMasterUpdatedEvent : DomainEvent
{
    public GstReportMasterId GstReportMasterId { get; }

    public GstReportMasterUpdatedEvent(GstReportMasterId gstreportmasterId)
    {
        GstReportMasterId = gstreportmasterId;
    }
}

public sealed class GstReportMasterDeletedEvent : DomainEvent
{
    public GstReportMasterId GstReportMasterId { get; }

    public GstReportMasterDeletedEvent(GstReportMasterId gstreportmasterId)
    {
        GstReportMasterId = gstreportmasterId;
    }
}
}
