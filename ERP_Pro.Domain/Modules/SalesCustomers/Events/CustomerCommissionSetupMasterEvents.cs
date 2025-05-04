using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerCommissionSetupMaster entity
/// </summary>
public sealed class CustomerCommissionSetupMasterCreatedEvent : DomainEvent
{
    public CustomerCommissionSetupMasterId CustomerCommissionSetupMasterId { get; }

    public CustomerCommissionSetupMasterCreatedEvent(CustomerCommissionSetupMasterId customercommissionsetupmasterId)
    {
        CustomerCommissionSetupMasterId = customercommissionsetupmasterId;
    }
}

public sealed class CustomerCommissionSetupMasterUpdatedEvent : DomainEvent
{
    public CustomerCommissionSetupMasterId CustomerCommissionSetupMasterId { get; }

    public CustomerCommissionSetupMasterUpdatedEvent(CustomerCommissionSetupMasterId customercommissionsetupmasterId)
    {
        CustomerCommissionSetupMasterId = customercommissionsetupmasterId;
    }
}

public sealed class CustomerCommissionSetupMasterDeletedEvent : DomainEvent
{
    public CustomerCommissionSetupMasterId CustomerCommissionSetupMasterId { get; }

    public CustomerCommissionSetupMasterDeletedEvent(CustomerCommissionSetupMasterId customercommissionsetupmasterId)
    {
        CustomerCommissionSetupMasterId = customercommissionsetupmasterId;
    }
}
}
