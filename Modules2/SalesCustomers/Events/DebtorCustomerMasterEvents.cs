using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to DebtorCustomerMaster entity
/// </summary>
public sealed class DebtorCustomerMasterCreatedEvent : DomainEvent
{
    public DebtorCustomerMasterId DebtorCustomerMasterId { get; }

    public DebtorCustomerMasterCreatedEvent(DebtorCustomerMasterId debtorcustomermasterId)
    {
        DebtorCustomerMasterId = debtorcustomermasterId;
    }
}

public sealed class DebtorCustomerMasterUpdatedEvent : DomainEvent
{
    public DebtorCustomerMasterId DebtorCustomerMasterId { get; }

    public DebtorCustomerMasterUpdatedEvent(DebtorCustomerMasterId debtorcustomermasterId)
    {
        DebtorCustomerMasterId = debtorcustomermasterId;
    }
}

public sealed class DebtorCustomerMasterDeletedEvent : DomainEvent
{
    public DebtorCustomerMasterId DebtorCustomerMasterId { get; }

    public DebtorCustomerMasterDeletedEvent(DebtorCustomerMasterId debtorcustomermasterId)
    {
        DebtorCustomerMasterId = debtorcustomermasterId;
    }
}
}
