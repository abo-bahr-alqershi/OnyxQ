using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceClassLimitMonth entity
/// </summary>
public sealed class InsuranceClassLimitMonthCreatedEvent : DomainEvent
{
    public InsuranceClassLimitMonthId InsuranceClassLimitMonthId { get; }

    public InsuranceClassLimitMonthCreatedEvent(InsuranceClassLimitMonthId insuranceclasslimitmonthId)
    {
        InsuranceClassLimitMonthId = insuranceclasslimitmonthId;
    }
}

public sealed class InsuranceClassLimitMonthUpdatedEvent : DomainEvent
{
    public InsuranceClassLimitMonthId InsuranceClassLimitMonthId { get; }

    public InsuranceClassLimitMonthUpdatedEvent(InsuranceClassLimitMonthId insuranceclasslimitmonthId)
    {
        InsuranceClassLimitMonthId = insuranceclasslimitmonthId;
    }
}

public sealed class InsuranceClassLimitMonthDeletedEvent : DomainEvent
{
    public InsuranceClassLimitMonthId InsuranceClassLimitMonthId { get; }

    public InsuranceClassLimitMonthDeletedEvent(InsuranceClassLimitMonthId insuranceclasslimitmonthId)
    {
        InsuranceClassLimitMonthId = insuranceclasslimitmonthId;
    }
}
}
