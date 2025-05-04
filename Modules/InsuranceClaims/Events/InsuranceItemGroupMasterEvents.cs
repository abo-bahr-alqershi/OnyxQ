using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceItemGroupMaster entity
/// </summary>
public sealed class InsuranceItemGroupMasterCreatedEvent : DomainEvent
{
    public InsuranceItemGroupMasterId InsuranceItemGroupMasterId { get; }

    public InsuranceItemGroupMasterCreatedEvent(InsuranceItemGroupMasterId insuranceitemgroupmasterId)
    {
        InsuranceItemGroupMasterId = insuranceitemgroupmasterId;
    }
}

public sealed class InsuranceItemGroupMasterUpdatedEvent : DomainEvent
{
    public InsuranceItemGroupMasterId InsuranceItemGroupMasterId { get; }

    public InsuranceItemGroupMasterUpdatedEvent(InsuranceItemGroupMasterId insuranceitemgroupmasterId)
    {
        InsuranceItemGroupMasterId = insuranceitemgroupmasterId;
    }
}

public sealed class InsuranceItemGroupMasterDeletedEvent : DomainEvent
{
    public InsuranceItemGroupMasterId InsuranceItemGroupMasterId { get; }

    public InsuranceItemGroupMasterDeletedEvent(InsuranceItemGroupMasterId insuranceitemgroupmasterId)
    {
        InsuranceItemGroupMasterId = insuranceitemgroupmasterId;
    }
}
}
