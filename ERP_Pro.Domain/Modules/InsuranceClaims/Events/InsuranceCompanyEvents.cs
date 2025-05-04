using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceCompany entity
/// </summary>
public sealed class InsuranceCompanyCreatedEvent : DomainEvent
{
    public InsuranceCompanyId InsuranceCompanyId { get; }

    public InsuranceCompanyCreatedEvent(InsuranceCompanyId insurancecompanyId)
    {
        InsuranceCompanyId = insurancecompanyId;
    }
}

public sealed class InsuranceCompanyUpdatedEvent : DomainEvent
{
    public InsuranceCompanyId InsuranceCompanyId { get; }

    public InsuranceCompanyUpdatedEvent(InsuranceCompanyId insurancecompanyId)
    {
        InsuranceCompanyId = insurancecompanyId;
    }
}

public sealed class InsuranceCompanyDeletedEvent : DomainEvent
{
    public InsuranceCompanyId InsuranceCompanyId { get; }

    public InsuranceCompanyDeletedEvent(InsuranceCompanyId insurancecompanyId)
    {
        InsuranceCompanyId = insurancecompanyId;
    }
}
}
