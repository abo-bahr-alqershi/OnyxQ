using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to VendorAccount entity
/// </summary>
public sealed class VendorAccountCreatedEvent : DomainEvent
{
    public VendorAccountId VendorAccountId { get; }

    public VendorAccountCreatedEvent(VendorAccountId vendoraccountId)
    {
        VendorAccountId = vendoraccountId;
    }
}

public sealed class VendorAccountUpdatedEvent : DomainEvent
{
    public VendorAccountId VendorAccountId { get; }

    public VendorAccountUpdatedEvent(VendorAccountId vendoraccountId)
    {
        VendorAccountId = vendoraccountId;
    }
}

public sealed class VendorAccountDeletedEvent : DomainEvent
{
    public VendorAccountId VendorAccountId { get; }

    public VendorAccountDeletedEvent(VendorAccountId vendoraccountId)
    {
        VendorAccountId = vendoraccountId;
    }
}
}
