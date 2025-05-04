using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to VoucherDetails entity
/// </summary>
public sealed class VoucherDetailsCreatedEvent : DomainEvent
{
    public VoucherDetailsId VoucherDetailsId { get; }

    public VoucherDetailsCreatedEvent(VoucherDetailsId voucherdetailsId)
    {
        VoucherDetailsId = voucherdetailsId;
    }
}

public sealed class VoucherDetailsUpdatedEvent : DomainEvent
{
    public VoucherDetailsId VoucherDetailsId { get; }

    public VoucherDetailsUpdatedEvent(VoucherDetailsId voucherdetailsId)
    {
        VoucherDetailsId = voucherdetailsId;
    }
}

public sealed class VoucherDetailsDeletedEvent : DomainEvent
{
    public VoucherDetailsId VoucherDetailsId { get; }

    public VoucherDetailsDeletedEvent(VoucherDetailsId voucherdetailsId)
    {
        VoucherDetailsId = voucherdetailsId;
    }
}
}
