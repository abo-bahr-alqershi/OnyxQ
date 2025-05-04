using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerTaxAccount entity
/// </summary>
public sealed class GeneralLedgerTaxAccountCreatedEvent : DomainEvent
{
    public GeneralLedgerTaxAccountId GeneralLedgerTaxAccountId { get; }

    public GeneralLedgerTaxAccountCreatedEvent(GeneralLedgerTaxAccountId generalledgertaxaccountId)
    {
        GeneralLedgerTaxAccountId = generalledgertaxaccountId;
    }
}

public sealed class GeneralLedgerTaxAccountUpdatedEvent : DomainEvent
{
    public GeneralLedgerTaxAccountId GeneralLedgerTaxAccountId { get; }

    public GeneralLedgerTaxAccountUpdatedEvent(GeneralLedgerTaxAccountId generalledgertaxaccountId)
    {
        GeneralLedgerTaxAccountId = generalledgertaxaccountId;
    }
}

public sealed class GeneralLedgerTaxAccountDeletedEvent : DomainEvent
{
    public GeneralLedgerTaxAccountId GeneralLedgerTaxAccountId { get; }

    public GeneralLedgerTaxAccountDeletedEvent(GeneralLedgerTaxAccountId generalledgertaxaccountId)
    {
        GeneralLedgerTaxAccountId = generalledgertaxaccountId;
    }
}
}
