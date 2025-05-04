using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerBankChequeMaster entity
/// </summary>
public sealed class GeneralLedgerBankChequeMasterCreatedEvent : DomainEvent
{
    public GeneralLedgerBankChequeMasterId GeneralLedgerBankChequeMasterId { get; }

    public GeneralLedgerBankChequeMasterCreatedEvent(GeneralLedgerBankChequeMasterId generalledgerbankchequemasterId)
    {
        GeneralLedgerBankChequeMasterId = generalledgerbankchequemasterId;
    }
}

public sealed class GeneralLedgerBankChequeMasterUpdatedEvent : DomainEvent
{
    public GeneralLedgerBankChequeMasterId GeneralLedgerBankChequeMasterId { get; }

    public GeneralLedgerBankChequeMasterUpdatedEvent(GeneralLedgerBankChequeMasterId generalledgerbankchequemasterId)
    {
        GeneralLedgerBankChequeMasterId = generalledgerbankchequemasterId;
    }
}

public sealed class GeneralLedgerBankChequeMasterDeletedEvent : DomainEvent
{
    public GeneralLedgerBankChequeMasterId GeneralLedgerBankChequeMasterId { get; }

    public GeneralLedgerBankChequeMasterDeletedEvent(GeneralLedgerBankChequeMasterId generalledgerbankchequemasterId)
    {
        GeneralLedgerBankChequeMasterId = generalledgerbankchequemasterId;
    }
}
}
