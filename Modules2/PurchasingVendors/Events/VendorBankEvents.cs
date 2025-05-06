using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to VendorBank entity
/// </summary>
public sealed class VendorBankCreatedEvent : DomainEvent
{
    public VendorBankId VendorBankId { get; }

    public VendorBankCreatedEvent(VendorBankId vendorbankId)
    {
        VendorBankId = vendorbankId;
    }
}

public sealed class VendorBankUpdatedEvent : DomainEvent
{
    public VendorBankId VendorBankId { get; }

    public VendorBankUpdatedEvent(VendorBankId vendorbankId)
    {
        VendorBankId = vendorbankId;
    }
}

public sealed class VendorBankDeletedEvent : DomainEvent
{
    public VendorBankId VendorBankId { get; }

    public VendorBankDeletedEvent(VendorBankId vendorbankId)
    {
        VendorBankId = vendorbankId;
    }
}
}
