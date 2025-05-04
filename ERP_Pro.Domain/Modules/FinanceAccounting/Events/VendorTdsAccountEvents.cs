using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to VendorTdsAccount entity
/// </summary>
public sealed class VendorTdsAccountCreatedEvent : DomainEvent
{
    public VendorTdsAccountId VendorTdsAccountId { get; }

    public VendorTdsAccountCreatedEvent(VendorTdsAccountId vendortdsaccountId)
    {
        VendorTdsAccountId = vendortdsaccountId;
    }
}

public sealed class VendorTdsAccountUpdatedEvent : DomainEvent
{
    public VendorTdsAccountId VendorTdsAccountId { get; }

    public VendorTdsAccountUpdatedEvent(VendorTdsAccountId vendortdsaccountId)
    {
        VendorTdsAccountId = vendortdsaccountId;
    }
}

public sealed class VendorTdsAccountDeletedEvent : DomainEvent
{
    public VendorTdsAccountId VendorTdsAccountId { get; }

    public VendorTdsAccountDeletedEvent(VendorTdsAccountId vendortdsaccountId)
    {
        VendorTdsAccountId = vendortdsaccountId;
    }
}
}
