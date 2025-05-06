using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FinanceAccounting.ValueObjects;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CashAtBankDetail entity
/// </summary>
public sealed class CashAtBankDetailCreatedEvent : DomainEvent
{
    public CashAtBankDetailId CashAtBankDetailId { get; }

    public CashAtBankDetailCreatedEvent(CashAtBankDetailId cashatbankdetailId)
    {
        CashAtBankDetailId = cashatbankdetailId;
    }
}

public sealed class CashAtBankDetailUpdatedEvent : DomainEvent
{
    public CashAtBankDetailId CashAtBankDetailId { get; }

    public CashAtBankDetailUpdatedEvent(CashAtBankDetailId cashatbankdetailId)
    {
        CashAtBankDetailId = cashatbankdetailId;
    }
}

public sealed class CashAtBankDetailDeletedEvent : DomainEvent
{
    public CashAtBankDetailId CashAtBankDetailId { get; }

    public CashAtBankDetailDeletedEvent(CashAtBankDetailId cashatbankdetailId)
    {
        CashAtBankDetailId = cashatbankdetailId;
    }
}
}
