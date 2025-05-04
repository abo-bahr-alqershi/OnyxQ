using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to CreditCardCommissionBank entity
/// </summary>
public sealed class CreditCardCommissionBankCreatedEvent : DomainEvent
{
    public CreditCardCommissionBankId CreditCardCommissionBankId { get; }

    public CreditCardCommissionBankCreatedEvent(CreditCardCommissionBankId creditcardcommissionbankId)
    {
        CreditCardCommissionBankId = creditcardcommissionbankId;
    }
}

public sealed class CreditCardCommissionBankUpdatedEvent : DomainEvent
{
    public CreditCardCommissionBankId CreditCardCommissionBankId { get; }

    public CreditCardCommissionBankUpdatedEvent(CreditCardCommissionBankId creditcardcommissionbankId)
    {
        CreditCardCommissionBankId = creditcardcommissionbankId;
    }
}

public sealed class CreditCardCommissionBankDeletedEvent : DomainEvent
{
    public CreditCardCommissionBankId CreditCardCommissionBankId { get; }

    public CreditCardCommissionBankDeletedEvent(CreditCardCommissionBankId creditcardcommissionbankId)
    {
        CreditCardCommissionBankId = creditcardcommissionbankId;
    }
}
}
