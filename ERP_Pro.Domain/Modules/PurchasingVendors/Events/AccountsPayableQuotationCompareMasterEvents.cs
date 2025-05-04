using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableQuotationCompareMaster entity
/// </summary>
public sealed class AccountsPayableQuotationCompareMasterCreatedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareMasterId AccountsPayableQuotationCompareMasterId { get; }

    public AccountsPayableQuotationCompareMasterCreatedEvent(AccountsPayableQuotationCompareMasterId accountspayablequotationcomparemasterId)
    {
        AccountsPayableQuotationCompareMasterId = accountspayablequotationcomparemasterId;
    }
}

public sealed class AccountsPayableQuotationCompareMasterUpdatedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareMasterId AccountsPayableQuotationCompareMasterId { get; }

    public AccountsPayableQuotationCompareMasterUpdatedEvent(AccountsPayableQuotationCompareMasterId accountspayablequotationcomparemasterId)
    {
        AccountsPayableQuotationCompareMasterId = accountspayablequotationcomparemasterId;
    }
}

public sealed class AccountsPayableQuotationCompareMasterDeletedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareMasterId AccountsPayableQuotationCompareMasterId { get; }

    public AccountsPayableQuotationCompareMasterDeletedEvent(AccountsPayableQuotationCompareMasterId accountspayablequotationcomparemasterId)
    {
        AccountsPayableQuotationCompareMasterId = accountspayablequotationcomparemasterId;
    }
}
}
