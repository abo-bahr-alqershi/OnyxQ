using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerBankIdentificationMaster entity
/// </summary>
public sealed class GeneralLedgerBankIdentificationMasterCreatedEvent : DomainEvent
{
    public GeneralLedgerBankIdentificationMasterId GeneralLedgerBankIdentificationMasterId { get; }

    public GeneralLedgerBankIdentificationMasterCreatedEvent(GeneralLedgerBankIdentificationMasterId generalledgerbankidentificationmasterId)
    {
        GeneralLedgerBankIdentificationMasterId = generalledgerbankidentificationmasterId;
    }
}

public sealed class GeneralLedgerBankIdentificationMasterUpdatedEvent : DomainEvent
{
    public GeneralLedgerBankIdentificationMasterId GeneralLedgerBankIdentificationMasterId { get; }

    public GeneralLedgerBankIdentificationMasterUpdatedEvent(GeneralLedgerBankIdentificationMasterId generalledgerbankidentificationmasterId)
    {
        GeneralLedgerBankIdentificationMasterId = generalledgerbankidentificationmasterId;
    }
}

public sealed class GeneralLedgerBankIdentificationMasterDeletedEvent : DomainEvent
{
    public GeneralLedgerBankIdentificationMasterId GeneralLedgerBankIdentificationMasterId { get; }

    public GeneralLedgerBankIdentificationMasterDeletedEvent(GeneralLedgerBankIdentificationMasterId generalledgerbankidentificationmasterId)
    {
        GeneralLedgerBankIdentificationMasterId = generalledgerbankidentificationmasterId;
    }
}
}
