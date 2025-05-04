using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to SalesmanCommissionSetupMaster entity
/// </summary>
public sealed class SalesmanCommissionSetupMasterCreatedEvent : DomainEvent
{
    public SalesmanCommissionSetupMasterId SalesmanCommissionSetupMasterId { get; }

    public SalesmanCommissionSetupMasterCreatedEvent(SalesmanCommissionSetupMasterId salesmancommissionsetupmasterId)
    {
        SalesmanCommissionSetupMasterId = salesmancommissionsetupmasterId;
    }
}

public sealed class SalesmanCommissionSetupMasterUpdatedEvent : DomainEvent
{
    public SalesmanCommissionSetupMasterId SalesmanCommissionSetupMasterId { get; }

    public SalesmanCommissionSetupMasterUpdatedEvent(SalesmanCommissionSetupMasterId salesmancommissionsetupmasterId)
    {
        SalesmanCommissionSetupMasterId = salesmancommissionsetupmasterId;
    }
}

public sealed class SalesmanCommissionSetupMasterDeletedEvent : DomainEvent
{
    public SalesmanCommissionSetupMasterId SalesmanCommissionSetupMasterId { get; }

    public SalesmanCommissionSetupMasterDeletedEvent(SalesmanCommissionSetupMasterId salesmancommissionsetupmasterId)
    {
        SalesmanCommissionSetupMasterId = salesmancommissionsetupmasterId;
    }
}
}
