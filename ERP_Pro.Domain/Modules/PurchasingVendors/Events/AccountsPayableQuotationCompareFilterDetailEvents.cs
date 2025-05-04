using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableQuotationCompareFilterDetail entity
/// </summary>
public sealed class AccountsPayableQuotationCompareFilterDetailCreatedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareFilterDetailId AccountsPayableQuotationCompareFilterDetailId { get; }

    public AccountsPayableQuotationCompareFilterDetailCreatedEvent(AccountsPayableQuotationCompareFilterDetailId accountspayablequotationcomparefilterdetailId)
    {
        AccountsPayableQuotationCompareFilterDetailId = accountspayablequotationcomparefilterdetailId;
    }
}

public sealed class AccountsPayableQuotationCompareFilterDetailUpdatedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareFilterDetailId AccountsPayableQuotationCompareFilterDetailId { get; }

    public AccountsPayableQuotationCompareFilterDetailUpdatedEvent(AccountsPayableQuotationCompareFilterDetailId accountspayablequotationcomparefilterdetailId)
    {
        AccountsPayableQuotationCompareFilterDetailId = accountspayablequotationcomparefilterdetailId;
    }
}

public sealed class AccountsPayableQuotationCompareFilterDetailDeletedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareFilterDetailId AccountsPayableQuotationCompareFilterDetailId { get; }

    public AccountsPayableQuotationCompareFilterDetailDeletedEvent(AccountsPayableQuotationCompareFilterDetailId accountspayablequotationcomparefilterdetailId)
    {
        AccountsPayableQuotationCompareFilterDetailId = accountspayablequotationcomparefilterdetailId;
    }
}
}
