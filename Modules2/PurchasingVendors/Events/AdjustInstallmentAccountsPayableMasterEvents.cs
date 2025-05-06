using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AdjustInstallmentAccountsPayableMaster entity
/// </summary>
public sealed class AdjustInstallmentAccountsPayableMasterCreatedEvent : DomainEvent
{
    public AdjustInstallmentAccountsPayableMasterId AdjustInstallmentAccountsPayableMasterId { get; }

    public AdjustInstallmentAccountsPayableMasterCreatedEvent(AdjustInstallmentAccountsPayableMasterId adjustinstallmentaccountspayablemasterId)
    {
        AdjustInstallmentAccountsPayableMasterId = adjustinstallmentaccountspayablemasterId;
    }
}

public sealed class AdjustInstallmentAccountsPayableMasterUpdatedEvent : DomainEvent
{
    public AdjustInstallmentAccountsPayableMasterId AdjustInstallmentAccountsPayableMasterId { get; }

    public AdjustInstallmentAccountsPayableMasterUpdatedEvent(AdjustInstallmentAccountsPayableMasterId adjustinstallmentaccountspayablemasterId)
    {
        AdjustInstallmentAccountsPayableMasterId = adjustinstallmentaccountspayablemasterId;
    }
}

public sealed class AdjustInstallmentAccountsPayableMasterDeletedEvent : DomainEvent
{
    public AdjustInstallmentAccountsPayableMasterId AdjustInstallmentAccountsPayableMasterId { get; }

    public AdjustInstallmentAccountsPayableMasterDeletedEvent(AdjustInstallmentAccountsPayableMasterId adjustinstallmentaccountspayablemasterId)
    {
        AdjustInstallmentAccountsPayableMasterId = adjustinstallmentaccountspayablemasterId;
    }
}
}
