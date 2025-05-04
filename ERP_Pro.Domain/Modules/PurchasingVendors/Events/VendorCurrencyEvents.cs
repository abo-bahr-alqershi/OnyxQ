using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorCurrency entity
/// </summary>
public sealed class VendorCurrencyCreatedEvent : DomainEvent
{
    public VendorCurrencyId VendorCurrencyId { get; }

    public VendorCurrencyCreatedEvent(VendorCurrencyId vendorcurrencyId)
    {
        VendorCurrencyId = vendorcurrencyId;
    }
}

public sealed class VendorCurrencyUpdatedEvent : DomainEvent
{
    public VendorCurrencyId VendorCurrencyId { get; }

    public VendorCurrencyUpdatedEvent(VendorCurrencyId vendorcurrencyId)
    {
        VendorCurrencyId = vendorcurrencyId;
    }
}

public sealed class VendorCurrencyDeletedEvent : DomainEvent
{
    public VendorCurrencyId VendorCurrencyId { get; }

    public VendorCurrencyDeletedEvent(VendorCurrencyId vendorcurrencyId)
    {
        VendorCurrencyId = vendorcurrencyId;
    }
}
}
