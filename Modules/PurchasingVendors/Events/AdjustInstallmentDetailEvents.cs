using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AdjustInstallmentDetail entity
/// </summary>
public sealed class AdjustInstallmentDetailCreatedEvent : DomainEvent
{
    public AdjustInstallmentDetailId AdjustInstallmentDetailId { get; }

    public AdjustInstallmentDetailCreatedEvent(AdjustInstallmentDetailId adjustinstallmentdetailId)
    {
        AdjustInstallmentDetailId = adjustinstallmentdetailId;
    }
}

public sealed class AdjustInstallmentDetailUpdatedEvent : DomainEvent
{
    public AdjustInstallmentDetailId AdjustInstallmentDetailId { get; }

    public AdjustInstallmentDetailUpdatedEvent(AdjustInstallmentDetailId adjustinstallmentdetailId)
    {
        AdjustInstallmentDetailId = adjustinstallmentdetailId;
    }
}

public sealed class AdjustInstallmentDetailDeletedEvent : DomainEvent
{
    public AdjustInstallmentDetailId AdjustInstallmentDetailId { get; }

    public AdjustInstallmentDetailDeletedEvent(AdjustInstallmentDetailId adjustinstallmentdetailId)
    {
        AdjustInstallmentDetailId = adjustinstallmentdetailId;
    }
}
}
