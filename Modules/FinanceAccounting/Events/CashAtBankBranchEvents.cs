using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CashAtBankBranch entity
/// </summary>
public sealed class CashAtBankBranchCreatedEvent : DomainEvent
{
    public CashAtBankBranchId CashAtBankBranchId { get; }

    public CashAtBankBranchCreatedEvent(CashAtBankBranchId cashatbankbranchId)
    {
        CashAtBankBranchId = cashatbankbranchId;
    }
}

public sealed class CashAtBankBranchUpdatedEvent : DomainEvent
{
    public CashAtBankBranchId CashAtBankBranchId { get; }

    public CashAtBankBranchUpdatedEvent(CashAtBankBranchId cashatbankbranchId)
    {
        CashAtBankBranchId = cashatbankbranchId;
    }
}

public sealed class CashAtBankBranchDeletedEvent : DomainEvent
{
    public CashAtBankBranchId CashAtBankBranchId { get; }

    public CashAtBankBranchDeletedEvent(CashAtBankBranchId cashatbankbranchId)
    {
        CashAtBankBranchId = cashatbankbranchId;
    }
}
}
