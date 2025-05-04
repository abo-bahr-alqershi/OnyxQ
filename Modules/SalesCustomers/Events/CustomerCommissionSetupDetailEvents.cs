using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CustomerCommissionSetupDetail entity
/// </summary>
public sealed class CustomerCommissionSetupDetailCreatedEvent : DomainEvent
{
    public CustomerCommissionSetupDetailId CustomerCommissionSetupDetailId { get; }

    public CustomerCommissionSetupDetailCreatedEvent(CustomerCommissionSetupDetailId customercommissionsetupdetailId)
    {
        CustomerCommissionSetupDetailId = customercommissionsetupdetailId;
    }
}

public sealed class CustomerCommissionSetupDetailUpdatedEvent : DomainEvent
{
    public CustomerCommissionSetupDetailId CustomerCommissionSetupDetailId { get; }

    public CustomerCommissionSetupDetailUpdatedEvent(CustomerCommissionSetupDetailId customercommissionsetupdetailId)
    {
        CustomerCommissionSetupDetailId = customercommissionsetupdetailId;
    }
}

public sealed class CustomerCommissionSetupDetailDeletedEvent : DomainEvent
{
    public CustomerCommissionSetupDetailId CustomerCommissionSetupDetailId { get; }

    public CustomerCommissionSetupDetailDeletedEvent(CustomerCommissionSetupDetailId customercommissionsetupdetailId)
    {
        CustomerCommissionSetupDetailId = customercommissionsetupdetailId;
    }
}
}
