using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableQuotationCompareMember entity
/// </summary>
public sealed class AccountsPayableQuotationCompareMemberCreatedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareMemberId AccountsPayableQuotationCompareMemberId { get; }

    public AccountsPayableQuotationCompareMemberCreatedEvent(AccountsPayableQuotationCompareMemberId accountspayablequotationcomparememberId)
    {
        AccountsPayableQuotationCompareMemberId = accountspayablequotationcomparememberId;
    }
}

public sealed class AccountsPayableQuotationCompareMemberUpdatedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareMemberId AccountsPayableQuotationCompareMemberId { get; }

    public AccountsPayableQuotationCompareMemberUpdatedEvent(AccountsPayableQuotationCompareMemberId accountspayablequotationcomparememberId)
    {
        AccountsPayableQuotationCompareMemberId = accountspayablequotationcomparememberId;
    }
}

public sealed class AccountsPayableQuotationCompareMemberDeletedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareMemberId AccountsPayableQuotationCompareMemberId { get; }

    public AccountsPayableQuotationCompareMemberDeletedEvent(AccountsPayableQuotationCompareMemberId accountspayablequotationcomparememberId)
    {
        AccountsPayableQuotationCompareMemberId = accountspayablequotationcomparememberId;
    }
}
}
