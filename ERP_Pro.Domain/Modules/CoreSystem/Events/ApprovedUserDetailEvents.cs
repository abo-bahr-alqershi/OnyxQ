using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Events
{
/// <summary>
/// Events related to ApprovedUserDetail entity
/// </summary>
public sealed class ApprovedUserDetailCreatedEvent : DomainEvent
{
    public ApprovedUserDetailId ApprovedUserDetailId { get; }

    public ApprovedUserDetailCreatedEvent(ApprovedUserDetailId approveduserdetailId)
    {
        ApprovedUserDetailId = approveduserdetailId;
    }
}

public sealed class ApprovedUserDetailUpdatedEvent : DomainEvent
{
    public ApprovedUserDetailId ApprovedUserDetailId { get; }

    public ApprovedUserDetailUpdatedEvent(ApprovedUserDetailId approveduserdetailId)
    {
        ApprovedUserDetailId = approveduserdetailId;
    }
}

public sealed class ApprovedUserDetailDeletedEvent : DomainEvent
{
    public ApprovedUserDetailId ApprovedUserDetailId { get; }

    public ApprovedUserDetailDeletedEvent(ApprovedUserDetailId approveduserdetailId)
    {
        ApprovedUserDetailId = approveduserdetailId;
    }
}
}
