using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableQuotationCompareFilterMaster entity
/// </summary>
public sealed class AccountsPayableQuotationCompareFilterMasterCreatedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareFilterMasterId AccountsPayableQuotationCompareFilterMasterId { get; }

    public AccountsPayableQuotationCompareFilterMasterCreatedEvent(AccountsPayableQuotationCompareFilterMasterId accountspayablequotationcomparefiltermasterId)
    {
        AccountsPayableQuotationCompareFilterMasterId = accountspayablequotationcomparefiltermasterId;
    }
}

public sealed class AccountsPayableQuotationCompareFilterMasterUpdatedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareFilterMasterId AccountsPayableQuotationCompareFilterMasterId { get; }

    public AccountsPayableQuotationCompareFilterMasterUpdatedEvent(AccountsPayableQuotationCompareFilterMasterId accountspayablequotationcomparefiltermasterId)
    {
        AccountsPayableQuotationCompareFilterMasterId = accountspayablequotationcomparefiltermasterId;
    }
}

public sealed class AccountsPayableQuotationCompareFilterMasterDeletedEvent : DomainEvent
{
    public AccountsPayableQuotationCompareFilterMasterId AccountsPayableQuotationCompareFilterMasterId { get; }

    public AccountsPayableQuotationCompareFilterMasterDeletedEvent(AccountsPayableQuotationCompareFilterMasterId accountspayablequotationcomparefiltermasterId)
    {
        AccountsPayableQuotationCompareFilterMasterId = accountspayablequotationcomparefiltermasterId;
    }
}
}
