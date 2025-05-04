using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableDiscount entity
/// </summary>
public sealed class AccountsPayableDiscountCreatedEvent : DomainEvent
{
    public AccountsPayableDiscountId AccountsPayableDiscountId { get; }

    public AccountsPayableDiscountCreatedEvent(AccountsPayableDiscountId accountspayablediscountId)
    {
        AccountsPayableDiscountId = accountspayablediscountId;
    }
}

public sealed class AccountsPayableDiscountUpdatedEvent : DomainEvent
{
    public AccountsPayableDiscountId AccountsPayableDiscountId { get; }

    public AccountsPayableDiscountUpdatedEvent(AccountsPayableDiscountId accountspayablediscountId)
    {
        AccountsPayableDiscountId = accountspayablediscountId;
    }
}

public sealed class AccountsPayableDiscountDeletedEvent : DomainEvent
{
    public AccountsPayableDiscountId AccountsPayableDiscountId { get; }

    public AccountsPayableDiscountDeletedEvent(AccountsPayableDiscountId accountspayablediscountId)
    {
        AccountsPayableDiscountId = accountspayablediscountId;
    }
}
}
