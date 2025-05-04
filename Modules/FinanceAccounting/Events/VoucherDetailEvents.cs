using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to VoucherDetail entity
/// </summary>
public sealed class VoucherDetailCreatedEvent : DomainEvent
{
    public VoucherDetailId VoucherDetailId { get; }

    public VoucherDetailCreatedEvent(VoucherDetailId voucherdetailId)
    {
        VoucherDetailId = voucherdetailId;
    }
}

public sealed class VoucherDetailUpdatedEvent : DomainEvent
{
    public VoucherDetailId VoucherDetailId { get; }

    public VoucherDetailUpdatedEvent(VoucherDetailId voucherdetailId)
    {
        VoucherDetailId = voucherdetailId;
    }
}

public sealed class VoucherDetailDeletedEvent : DomainEvent
{
    public VoucherDetailId VoucherDetailId { get; }

    public VoucherDetailDeletedEvent(VoucherDetailId voucherdetailId)
    {
        VoucherDetailId = voucherdetailId;
    }
}
}
