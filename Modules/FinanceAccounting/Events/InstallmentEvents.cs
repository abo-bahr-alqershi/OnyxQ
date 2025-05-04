using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to Installment entity
/// </summary>
public sealed class InstallmentCreatedEvent : DomainEvent
{
    public InstallmentId InstallmentId { get; }

    public InstallmentCreatedEvent(InstallmentId installmentId)
    {
        InstallmentId = installmentId;
    }
}

public sealed class InstallmentUpdatedEvent : DomainEvent
{
    public InstallmentId InstallmentId { get; }

    public InstallmentUpdatedEvent(InstallmentId installmentId)
    {
        InstallmentId = installmentId;
    }
}

public sealed class InstallmentDeletedEvent : DomainEvent
{
    public InstallmentId InstallmentId { get; }

    public InstallmentDeletedEvent(InstallmentId installmentId)
    {
        InstallmentId = installmentId;
    }
}
}
