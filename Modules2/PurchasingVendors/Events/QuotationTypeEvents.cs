using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to QuotationType entity
/// </summary>
public sealed class QuotationTypeCreatedEvent : DomainEvent
{
    public QuotationTypeId QuotationTypeId { get; }

    public QuotationTypeCreatedEvent(QuotationTypeId quotationtypeId)
    {
        QuotationTypeId = quotationtypeId;
    }
}

public sealed class QuotationTypeUpdatedEvent : DomainEvent
{
    public QuotationTypeId QuotationTypeId { get; }

    public QuotationTypeUpdatedEvent(QuotationTypeId quotationtypeId)
    {
        QuotationTypeId = quotationtypeId;
    }
}

public sealed class QuotationTypeDeletedEvent : DomainEvent
{
    public QuotationTypeId QuotationTypeId { get; }

    public QuotationTypeDeletedEvent(QuotationTypeId quotationtypeId)
    {
        QuotationTypeId = quotationtypeId;
    }
}
}
