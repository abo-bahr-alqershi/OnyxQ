using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerBankChequeDetail entity
/// </summary>
public sealed class GeneralLedgerBankChequeDetailCreatedEvent : DomainEvent
{
    public GeneralLedgerBankChequeDetailId GeneralLedgerBankChequeDetailId { get; }

    public GeneralLedgerBankChequeDetailCreatedEvent(GeneralLedgerBankChequeDetailId generalledgerbankchequedetailId)
    {
        GeneralLedgerBankChequeDetailId = generalledgerbankchequedetailId;
    }
}

public sealed class GeneralLedgerBankChequeDetailUpdatedEvent : DomainEvent
{
    public GeneralLedgerBankChequeDetailId GeneralLedgerBankChequeDetailId { get; }

    public GeneralLedgerBankChequeDetailUpdatedEvent(GeneralLedgerBankChequeDetailId generalledgerbankchequedetailId)
    {
        GeneralLedgerBankChequeDetailId = generalledgerbankchequedetailId;
    }
}

public sealed class GeneralLedgerBankChequeDetailDeletedEvent : DomainEvent
{
    public GeneralLedgerBankChequeDetailId GeneralLedgerBankChequeDetailId { get; }

    public GeneralLedgerBankChequeDetailDeletedEvent(GeneralLedgerBankChequeDetailId generalledgerbankchequedetailId)
    {
        GeneralLedgerBankChequeDetailId = generalledgerbankchequedetailId;
    }
}
}
