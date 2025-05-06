using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AdjustInstallmentAccountsPayableDetail entity
/// </summary>
public sealed class AdjustInstallmentAccountsPayableDetailCreatedEvent : DomainEvent
{
    public AdjustInstallmentAccountsPayableDetailId AdjustInstallmentAccountsPayableDetailId { get; }

    public AdjustInstallmentAccountsPayableDetailCreatedEvent(AdjustInstallmentAccountsPayableDetailId adjustinstallmentaccountspayabledetailId)
    {
        AdjustInstallmentAccountsPayableDetailId = adjustinstallmentaccountspayabledetailId;
    }
}

public sealed class AdjustInstallmentAccountsPayableDetailUpdatedEvent : DomainEvent
{
    public AdjustInstallmentAccountsPayableDetailId AdjustInstallmentAccountsPayableDetailId { get; }

    public AdjustInstallmentAccountsPayableDetailUpdatedEvent(AdjustInstallmentAccountsPayableDetailId adjustinstallmentaccountspayabledetailId)
    {
        AdjustInstallmentAccountsPayableDetailId = adjustinstallmentaccountspayabledetailId;
    }
}

public sealed class AdjustInstallmentAccountsPayableDetailDeletedEvent : DomainEvent
{
    public AdjustInstallmentAccountsPayableDetailId AdjustInstallmentAccountsPayableDetailId { get; }

    public AdjustInstallmentAccountsPayableDetailDeletedEvent(AdjustInstallmentAccountsPayableDetailId adjustinstallmentaccountspayabledetailId)
    {
        AdjustInstallmentAccountsPayableDetailId = adjustinstallmentaccountspayabledetailId;
    }
}
}
