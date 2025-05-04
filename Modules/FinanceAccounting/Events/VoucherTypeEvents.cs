using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to VoucherType entity
/// </summary>
public sealed class VoucherTypeCreatedEvent : DomainEvent
{
    public VoucherTypeId VoucherTypeId { get; }

    public VoucherTypeCreatedEvent(VoucherTypeId vouchertypeId)
    {
        VoucherTypeId = vouchertypeId;
    }
}

public sealed class VoucherTypeUpdatedEvent : DomainEvent
{
    public VoucherTypeId VoucherTypeId { get; }

    public VoucherTypeUpdatedEvent(VoucherTypeId vouchertypeId)
    {
        VoucherTypeId = vouchertypeId;
    }
}

public sealed class VoucherTypeDeletedEvent : DomainEvent
{
    public VoucherTypeId VoucherTypeId { get; }

    public VoucherTypeDeletedEvent(VoucherTypeId vouchertypeId)
    {
        VoucherTypeId = vouchertypeId;
    }
}
}
