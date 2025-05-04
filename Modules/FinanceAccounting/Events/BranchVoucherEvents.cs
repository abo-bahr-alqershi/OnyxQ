using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to BranchVoucher entity
/// </summary>
public sealed class BranchVoucherCreatedEvent : DomainEvent
{
    public BranchVoucherId BranchVoucherId { get; }

    public BranchVoucherCreatedEvent(BranchVoucherId branchvoucherId)
    {
        BranchVoucherId = branchvoucherId;
    }
}

public sealed class BranchVoucherUpdatedEvent : DomainEvent
{
    public BranchVoucherId BranchVoucherId { get; }

    public BranchVoucherUpdatedEvent(BranchVoucherId branchvoucherId)
    {
        BranchVoucherId = branchvoucherId;
    }
}

public sealed class BranchVoucherDeletedEvent : DomainEvent
{
    public BranchVoucherId BranchVoucherId { get; }

    public BranchVoucherDeletedEvent(BranchVoucherId branchvoucherId)
    {
        BranchVoucherId = branchvoucherId;
    }
}
}
