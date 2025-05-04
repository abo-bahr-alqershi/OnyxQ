using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableDiscountHistory entity
/// </summary>
public sealed class AccountsPayableDiscountHistoryCreatedEvent : DomainEvent
{
    public AccountsPayableDiscountHistoryId AccountsPayableDiscountHistoryId { get; }

    public AccountsPayableDiscountHistoryCreatedEvent(AccountsPayableDiscountHistoryId accountspayablediscounthistoryId)
    {
        AccountsPayableDiscountHistoryId = accountspayablediscounthistoryId;
    }
}

public sealed class AccountsPayableDiscountHistoryUpdatedEvent : DomainEvent
{
    public AccountsPayableDiscountHistoryId AccountsPayableDiscountHistoryId { get; }

    public AccountsPayableDiscountHistoryUpdatedEvent(AccountsPayableDiscountHistoryId accountspayablediscounthistoryId)
    {
        AccountsPayableDiscountHistoryId = accountspayablediscounthistoryId;
    }
}

public sealed class AccountsPayableDiscountHistoryDeletedEvent : DomainEvent
{
    public AccountsPayableDiscountHistoryId AccountsPayableDiscountHistoryId { get; }

    public AccountsPayableDiscountHistoryDeletedEvent(AccountsPayableDiscountHistoryId accountspayablediscounthistoryId)
    {
        AccountsPayableDiscountHistoryId = accountspayablediscounthistoryId;
    }
}
}
