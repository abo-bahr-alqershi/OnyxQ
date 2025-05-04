using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Events
{
/// <summary>
/// Events related to AccountsPayableChargeTdsSlice entity
/// </summary>
public sealed class AccountsPayableChargeTdsSliceCreatedEvent : DomainEvent
{
    public AccountsPayableChargeTdsSliceId AccountsPayableChargeTdsSliceId { get; }

    public AccountsPayableChargeTdsSliceCreatedEvent(AccountsPayableChargeTdsSliceId accountspayablechargetdssliceId)
    {
        AccountsPayableChargeTdsSliceId = accountspayablechargetdssliceId;
    }
}

public sealed class AccountsPayableChargeTdsSliceUpdatedEvent : DomainEvent
{
    public AccountsPayableChargeTdsSliceId AccountsPayableChargeTdsSliceId { get; }

    public AccountsPayableChargeTdsSliceUpdatedEvent(AccountsPayableChargeTdsSliceId accountspayablechargetdssliceId)
    {
        AccountsPayableChargeTdsSliceId = accountspayablechargetdssliceId;
    }
}

public sealed class AccountsPayableChargeTdsSliceDeletedEvent : DomainEvent
{
    public AccountsPayableChargeTdsSliceId AccountsPayableChargeTdsSliceId { get; }

    public AccountsPayableChargeTdsSliceDeletedEvent(AccountsPayableChargeTdsSliceId accountspayablechargetdssliceId)
    {
        AccountsPayableChargeTdsSliceId = accountspayablechargetdssliceId;
    }
}
}
