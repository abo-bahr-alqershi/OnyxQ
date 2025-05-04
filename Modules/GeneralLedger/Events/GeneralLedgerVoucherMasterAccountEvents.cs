using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerVoucherMasterAccount entity
/// </summary>
public sealed class GeneralLedgerVoucherMasterAccountCreatedEvent : DomainEvent
{
    public GeneralLedgerVoucherMasterAccountId GeneralLedgerVoucherMasterAccountId { get; }

    public GeneralLedgerVoucherMasterAccountCreatedEvent(GeneralLedgerVoucherMasterAccountId generalledgervouchermasteraccountId)
    {
        GeneralLedgerVoucherMasterAccountId = generalledgervouchermasteraccountId;
    }
}

public sealed class GeneralLedgerVoucherMasterAccountUpdatedEvent : DomainEvent
{
    public GeneralLedgerVoucherMasterAccountId GeneralLedgerVoucherMasterAccountId { get; }

    public GeneralLedgerVoucherMasterAccountUpdatedEvent(GeneralLedgerVoucherMasterAccountId generalledgervouchermasteraccountId)
    {
        GeneralLedgerVoucherMasterAccountId = generalledgervouchermasteraccountId;
    }
}

public sealed class GeneralLedgerVoucherMasterAccountDeletedEvent : DomainEvent
{
    public GeneralLedgerVoucherMasterAccountId GeneralLedgerVoucherMasterAccountId { get; }

    public GeneralLedgerVoucherMasterAccountDeletedEvent(GeneralLedgerVoucherMasterAccountId generalledgervouchermasteraccountId)
    {
        GeneralLedgerVoucherMasterAccountId = generalledgervouchermasteraccountId;
    }
}
}
