using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to DebtorCustomerDetail entity
/// </summary>
public sealed class DebtorCustomerDetailCreatedEvent : DomainEvent
{
    public DebtorCustomerDetailId DebtorCustomerDetailId { get; }

    public DebtorCustomerDetailCreatedEvent(DebtorCustomerDetailId debtorcustomerdetailId)
    {
        DebtorCustomerDetailId = debtorcustomerdetailId;
    }
}

public sealed class DebtorCustomerDetailUpdatedEvent : DomainEvent
{
    public DebtorCustomerDetailId DebtorCustomerDetailId { get; }

    public DebtorCustomerDetailUpdatedEvent(DebtorCustomerDetailId debtorcustomerdetailId)
    {
        DebtorCustomerDetailId = debtorcustomerdetailId;
    }
}

public sealed class DebtorCustomerDetailDeletedEvent : DomainEvent
{
    public DebtorCustomerDetailId DebtorCustomerDetailId { get; }

    public DebtorCustomerDetailDeletedEvent(DebtorCustomerDetailId debtorcustomerdetailId)
    {
        DebtorCustomerDetailId = debtorcustomerdetailId;
    }
}
}
