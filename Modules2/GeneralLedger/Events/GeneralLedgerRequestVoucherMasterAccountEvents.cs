using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerRequestVoucherMasterAccount entity
/// </summary>
public sealed class GeneralLedgerRequestVoucherMasterAccountCreatedEvent : DomainEvent
{
    public GeneralLedgerRequestVoucherMasterAccountId GeneralLedgerRequestVoucherMasterAccountId { get; }

    public GeneralLedgerRequestVoucherMasterAccountCreatedEvent(GeneralLedgerRequestVoucherMasterAccountId generalledgerrequestvouchermasteraccountId)
    {
        GeneralLedgerRequestVoucherMasterAccountId = generalledgerrequestvouchermasteraccountId;
    }
}

public sealed class GeneralLedgerRequestVoucherMasterAccountUpdatedEvent : DomainEvent
{
    public GeneralLedgerRequestVoucherMasterAccountId GeneralLedgerRequestVoucherMasterAccountId { get; }

    public GeneralLedgerRequestVoucherMasterAccountUpdatedEvent(GeneralLedgerRequestVoucherMasterAccountId generalledgerrequestvouchermasteraccountId)
    {
        GeneralLedgerRequestVoucherMasterAccountId = generalledgerrequestvouchermasteraccountId;
    }
}

public sealed class GeneralLedgerRequestVoucherMasterAccountDeletedEvent : DomainEvent
{
    public GeneralLedgerRequestVoucherMasterAccountId GeneralLedgerRequestVoucherMasterAccountId { get; }

    public GeneralLedgerRequestVoucherMasterAccountDeletedEvent(GeneralLedgerRequestVoucherMasterAccountId generalledgerrequestvouchermasteraccountId)
    {
        GeneralLedgerRequestVoucherMasterAccountId = generalledgerrequestvouchermasteraccountId;
    }
}
}
