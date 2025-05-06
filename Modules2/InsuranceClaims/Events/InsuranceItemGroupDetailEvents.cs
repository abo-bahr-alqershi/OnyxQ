using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceItemGroupDetail entity
/// </summary>
public sealed class InsuranceItemGroupDetailCreatedEvent : DomainEvent
{
    public InsuranceItemGroupDetailId InsuranceItemGroupDetailId { get; }

    public InsuranceItemGroupDetailCreatedEvent(InsuranceItemGroupDetailId insuranceitemgroupdetailId)
    {
        InsuranceItemGroupDetailId = insuranceitemgroupdetailId;
    }
}

public sealed class InsuranceItemGroupDetailUpdatedEvent : DomainEvent
{
    public InsuranceItemGroupDetailId InsuranceItemGroupDetailId { get; }

    public InsuranceItemGroupDetailUpdatedEvent(InsuranceItemGroupDetailId insuranceitemgroupdetailId)
    {
        InsuranceItemGroupDetailId = insuranceitemgroupdetailId;
    }
}

public sealed class InsuranceItemGroupDetailDeletedEvent : DomainEvent
{
    public InsuranceItemGroupDetailId InsuranceItemGroupDetailId { get; }

    public InsuranceItemGroupDetailDeletedEvent(InsuranceItemGroupDetailId insuranceitemgroupdetailId)
    {
        InsuranceItemGroupDetailId = insuranceitemgroupdetailId;
    }
}
}
