using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerBankIdentificationDetail entity
/// </summary>
public sealed class GeneralLedgerBankIdentificationDetailCreatedEvent : DomainEvent
{
    public GeneralLedgerBankIdentificationDetailId GeneralLedgerBankIdentificationDetailId { get; }

    public GeneralLedgerBankIdentificationDetailCreatedEvent(GeneralLedgerBankIdentificationDetailId generalledgerbankidentificationdetailId)
    {
        GeneralLedgerBankIdentificationDetailId = generalledgerbankidentificationdetailId;
    }
}

public sealed class GeneralLedgerBankIdentificationDetailUpdatedEvent : DomainEvent
{
    public GeneralLedgerBankIdentificationDetailId GeneralLedgerBankIdentificationDetailId { get; }

    public GeneralLedgerBankIdentificationDetailUpdatedEvent(GeneralLedgerBankIdentificationDetailId generalledgerbankidentificationdetailId)
    {
        GeneralLedgerBankIdentificationDetailId = generalledgerbankidentificationdetailId;
    }
}

public sealed class GeneralLedgerBankIdentificationDetailDeletedEvent : DomainEvent
{
    public GeneralLedgerBankIdentificationDetailId GeneralLedgerBankIdentificationDetailId { get; }

    public GeneralLedgerBankIdentificationDetailDeletedEvent(GeneralLedgerBankIdentificationDetailId generalledgerbankidentificationdetailId)
    {
        GeneralLedgerBankIdentificationDetailId = generalledgerbankidentificationdetailId;
    }
}
}
