using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to Voucher entity
/// </summary>
public sealed class VoucherCreatedEvent : DomainEvent
{
    public VoucherId VoucherId { get; }

    public VoucherCreatedEvent(VoucherId voucherId)
    {
        VoucherId = voucherId;
    }
}

public sealed class VoucherUpdatedEvent : DomainEvent
{
    public VoucherId VoucherId { get; }

    public VoucherUpdatedEvent(VoucherId voucherId)
    {
        VoucherId = voucherId;
    }
}

public sealed class VoucherDeletedEvent : DomainEvent
{
    public VoucherId VoucherId { get; }

    public VoucherDeletedEvent(VoucherId voucherId)
    {
        VoucherId = voucherId;
    }
}
}
