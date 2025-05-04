using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BranchInstallment entity
/// </summary>
public sealed class BranchInstallmentCreatedEvent : DomainEvent
{
    public BranchInstallmentId BranchInstallmentId { get; }

    public BranchInstallmentCreatedEvent(BranchInstallmentId branchinstallmentId)
    {
        BranchInstallmentId = branchinstallmentId;
    }
}

public sealed class BranchInstallmentUpdatedEvent : DomainEvent
{
    public BranchInstallmentId BranchInstallmentId { get; }

    public BranchInstallmentUpdatedEvent(BranchInstallmentId branchinstallmentId)
    {
        BranchInstallmentId = branchinstallmentId;
    }
}

public sealed class BranchInstallmentDeletedEvent : DomainEvent
{
    public BranchInstallmentId BranchInstallmentId { get; }

    public BranchInstallmentDeletedEvent(BranchInstallmentId branchinstallmentId)
    {
        BranchInstallmentId = branchinstallmentId;
    }
}
}
