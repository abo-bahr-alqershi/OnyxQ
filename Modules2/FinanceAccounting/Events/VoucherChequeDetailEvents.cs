using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to VoucherChequeDetail entity
/// </summary>
public sealed class VoucherChequeDetailCreatedEvent : DomainEvent
{
    public VoucherChequeDetailId VoucherChequeDetailId { get; }

    public VoucherChequeDetailCreatedEvent(VoucherChequeDetailId voucherchequedetailId)
    {
        VoucherChequeDetailId = voucherchequedetailId;
    }
}

public sealed class VoucherChequeDetailUpdatedEvent : DomainEvent
{
    public VoucherChequeDetailId VoucherChequeDetailId { get; }

    public VoucherChequeDetailUpdatedEvent(VoucherChequeDetailId voucherchequedetailId)
    {
        VoucherChequeDetailId = voucherchequedetailId;
    }
}

public sealed class VoucherChequeDetailDeletedEvent : DomainEvent
{
    public VoucherChequeDetailId VoucherChequeDetailId { get; }

    public VoucherChequeDetailDeletedEvent(VoucherChequeDetailId voucherchequedetailId)
    {
        VoucherChequeDetailId = voucherchequedetailId;
    }
}
}
