using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceCompanyClass entity
/// </summary>
public sealed class InsuranceCompanyClassCreatedEvent : DomainEvent
{
    public InsuranceCompanyClassId InsuranceCompanyClassId { get; }

    public InsuranceCompanyClassCreatedEvent(InsuranceCompanyClassId insurancecompanyclassId)
    {
        InsuranceCompanyClassId = insurancecompanyclassId;
    }
}

public sealed class InsuranceCompanyClassUpdatedEvent : DomainEvent
{
    public InsuranceCompanyClassId InsuranceCompanyClassId { get; }

    public InsuranceCompanyClassUpdatedEvent(InsuranceCompanyClassId insurancecompanyclassId)
    {
        InsuranceCompanyClassId = insurancecompanyclassId;
    }
}

public sealed class InsuranceCompanyClassDeletedEvent : DomainEvent
{
    public InsuranceCompanyClassId InsuranceCompanyClassId { get; }

    public InsuranceCompanyClassDeletedEvent(InsuranceCompanyClassId insurancecompanyclassId)
    {
        InsuranceCompanyClassId = insurancecompanyclassId;
    }
}
}
