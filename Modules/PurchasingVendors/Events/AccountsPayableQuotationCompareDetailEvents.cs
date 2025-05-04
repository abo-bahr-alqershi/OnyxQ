using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableQuotationCompareDetail entity
/// </summary>
public sealed class AccountsPayableQuotationCompareDetailCreatedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareDetailId AccountsPayableQuotationCompareDetailId { get; }

    public AccountsPayableQuotationCompareDetailCreatedEvent(AccountsPayableQuotationCompareDetailId accountspayablequotationcomparedetailId)
    {
        AccountsPayableQuotationCompareDetailId = accountspayablequotationcomparedetailId;
    }
}

public sealed class AccountsPayableQuotationCompareDetailUpdatedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareDetailId AccountsPayableQuotationCompareDetailId { get; }

    public AccountsPayableQuotationCompareDetailUpdatedEvent(AccountsPayableQuotationCompareDetailId accountspayablequotationcomparedetailId)
    {
        AccountsPayableQuotationCompareDetailId = accountspayablequotationcomparedetailId;
    }
}

public sealed class AccountsPayableQuotationCompareDetailDeletedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareDetailId AccountsPayableQuotationCompareDetailId { get; }

    public AccountsPayableQuotationCompareDetailDeletedEvent(AccountsPayableQuotationCompareDetailId accountspayablequotationcomparedetailId)
    {
        AccountsPayableQuotationCompareDetailId = accountspayablequotationcomparedetailId;
    }
}
}
