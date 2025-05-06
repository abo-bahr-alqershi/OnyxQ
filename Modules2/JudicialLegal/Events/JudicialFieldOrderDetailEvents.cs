using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.JudicialLegal.ValueObjects;

namespace ERP_Pro.Domain.ERP.JudicialLegal.Events
{
/// <summary>
/// Events related to JudicialFieldOrderDetail entity
/// </summary>
public sealed class JudicialFieldOrderDetailCreatedEvent : DomainEvent
{
    public JudicialFieldOrderDetailId JudicialFieldOrderDetailId { get; }

    public JudicialFieldOrderDetailCreatedEvent(JudicialFieldOrderDetailId judicialfieldorderdetailId)
    {
        JudicialFieldOrderDetailId = judicialfieldorderdetailId;
    }
}

public sealed class JudicialFieldOrderDetailUpdatedEvent : DomainEvent
{
    public JudicialFieldOrderDetailId JudicialFieldOrderDetailId { get; }

    public JudicialFieldOrderDetailUpdatedEvent(JudicialFieldOrderDetailId judicialfieldorderdetailId)
    {
        JudicialFieldOrderDetailId = judicialfieldorderdetailId;
    }
}

public sealed class JudicialFieldOrderDetailDeletedEvent : DomainEvent
{
    public JudicialFieldOrderDetailId JudicialFieldOrderDetailId { get; }

    public JudicialFieldOrderDetailDeletedEvent(JudicialFieldOrderDetailId judicialfieldorderdetailId)
    {
        JudicialFieldOrderDetailId = judicialfieldorderdetailId;
    }
}
}
