using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AdjustInstallmentMaster entity
/// </summary>
public sealed class AdjustInstallmentMasterCreatedEvent : DomainEvent
{
    public AdjustInstallmentMasterId AdjustInstallmentMasterId { get; }

    public AdjustInstallmentMasterCreatedEvent(AdjustInstallmentMasterId adjustinstallmentmasterId)
    {
        AdjustInstallmentMasterId = adjustinstallmentmasterId;
    }
}

public sealed class AdjustInstallmentMasterUpdatedEvent : DomainEvent
{
    public AdjustInstallmentMasterId AdjustInstallmentMasterId { get; }

    public AdjustInstallmentMasterUpdatedEvent(AdjustInstallmentMasterId adjustinstallmentmasterId)
    {
        AdjustInstallmentMasterId = adjustinstallmentmasterId;
    }
}

public sealed class AdjustInstallmentMasterDeletedEvent : DomainEvent
{
    public AdjustInstallmentMasterId AdjustInstallmentMasterId { get; }

    public AdjustInstallmentMasterDeletedEvent(AdjustInstallmentMasterId adjustinstallmentmasterId)
    {
        AdjustInstallmentMasterId = adjustinstallmentmasterId;
    }
}
}
