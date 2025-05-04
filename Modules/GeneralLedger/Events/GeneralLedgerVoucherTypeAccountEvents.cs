using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerVoucherTypeAccount entity
/// </summary>
public sealed class GeneralLedgerVoucherTypeAccountCreatedEvent : DomainEvent
{
    public GeneralLedgerVoucherTypeAccountId GeneralLedgerVoucherTypeAccountId { get; }

    public GeneralLedgerVoucherTypeAccountCreatedEvent(GeneralLedgerVoucherTypeAccountId generalledgervouchertypeaccountId)
    {
        GeneralLedgerVoucherTypeAccountId = generalledgervouchertypeaccountId;
    }
}

public sealed class GeneralLedgerVoucherTypeAccountUpdatedEvent : DomainEvent
{
    public GeneralLedgerVoucherTypeAccountId GeneralLedgerVoucherTypeAccountId { get; }

    public GeneralLedgerVoucherTypeAccountUpdatedEvent(GeneralLedgerVoucherTypeAccountId generalledgervouchertypeaccountId)
    {
        GeneralLedgerVoucherTypeAccountId = generalledgervouchertypeaccountId;
    }
}

public sealed class GeneralLedgerVoucherTypeAccountDeletedEvent : DomainEvent
{
    public GeneralLedgerVoucherTypeAccountId GeneralLedgerVoucherTypeAccountId { get; }

    public GeneralLedgerVoucherTypeAccountDeletedEvent(GeneralLedgerVoucherTypeAccountId generalledgervouchertypeaccountId)
    {
        GeneralLedgerVoucherTypeAccountId = generalledgervouchertypeaccountId;
    }
}
}
