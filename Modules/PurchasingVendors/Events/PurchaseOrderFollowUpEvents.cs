using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to PurchaseOrderFollowUp entity
/// </summary>
public sealed class PurchaseOrderFollowUpCreatedEvent : DomainEvent
{
    public PurchaseOrderFollowUpId PurchaseOrderFollowUpId { get; }

    public PurchaseOrderFollowUpCreatedEvent(PurchaseOrderFollowUpId purchaseorderfollowupId)
    {
        PurchaseOrderFollowUpId = purchaseorderfollowupId;
    }
}

public sealed class PurchaseOrderFollowUpUpdatedEvent : DomainEvent
{
    public PurchaseOrderFollowUpId PurchaseOrderFollowUpId { get; }

    public PurchaseOrderFollowUpUpdatedEvent(PurchaseOrderFollowUpId purchaseorderfollowupId)
    {
        PurchaseOrderFollowUpId = purchaseorderfollowupId;
    }
}

public sealed class PurchaseOrderFollowUpDeletedEvent : DomainEvent
{
    public PurchaseOrderFollowUpId PurchaseOrderFollowUpId { get; }

    public PurchaseOrderFollowUpDeletedEvent(PurchaseOrderFollowUpId purchaseorderfollowupId)
    {
        PurchaseOrderFollowUpId = purchaseorderfollowupId;
    }
}
}
