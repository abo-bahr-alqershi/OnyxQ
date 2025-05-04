using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to TenderType entity
/// </summary>
public sealed class TenderTypeCreatedEvent : DomainEvent
{
    public TenderTypeId TenderTypeId { get; }

    public TenderTypeCreatedEvent(TenderTypeId tendertypeId)
    {
        TenderTypeId = tendertypeId;
    }
}

public sealed class TenderTypeUpdatedEvent : DomainEvent
{
    public TenderTypeId TenderTypeId { get; }

    public TenderTypeUpdatedEvent(TenderTypeId tendertypeId)
    {
        TenderTypeId = tendertypeId;
    }
}

public sealed class TenderTypeDeletedEvent : DomainEvent
{
    public TenderTypeId TenderTypeId { get; }

    public TenderTypeDeletedEvent(TenderTypeId tendertypeId)
    {
        TenderTypeId = tendertypeId;
    }
}
}
