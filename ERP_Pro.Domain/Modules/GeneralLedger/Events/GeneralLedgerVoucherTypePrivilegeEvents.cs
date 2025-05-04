using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.GeneralLedger.ValueObjects;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to GeneralLedgerVoucherTypePrivilege entity
/// </summary>
public sealed class GeneralLedgerVoucherTypePrivilegeCreatedEvent : DomainEvent
{
    public GeneralLedgerVoucherTypePrivilegeId GeneralLedgerVoucherTypePrivilegeId { get; }

    public GeneralLedgerVoucherTypePrivilegeCreatedEvent(GeneralLedgerVoucherTypePrivilegeId generalledgervouchertypeprivilegeId)
    {
        GeneralLedgerVoucherTypePrivilegeId = generalledgervouchertypeprivilegeId;
    }
}

public sealed class GeneralLedgerVoucherTypePrivilegeUpdatedEvent : DomainEvent
{
    public GeneralLedgerVoucherTypePrivilegeId GeneralLedgerVoucherTypePrivilegeId { get; }

    public GeneralLedgerVoucherTypePrivilegeUpdatedEvent(GeneralLedgerVoucherTypePrivilegeId generalledgervouchertypeprivilegeId)
    {
        GeneralLedgerVoucherTypePrivilegeId = generalledgervouchertypeprivilegeId;
    }
}

public sealed class GeneralLedgerVoucherTypePrivilegeDeletedEvent : DomainEvent
{
    public GeneralLedgerVoucherTypePrivilegeId GeneralLedgerVoucherTypePrivilegeId { get; }

    public GeneralLedgerVoucherTypePrivilegeDeletedEvent(GeneralLedgerVoucherTypePrivilegeId generalledgervouchertypeprivilegeId)
    {
        GeneralLedgerVoucherTypePrivilegeId = generalledgervouchertypeprivilegeId;
    }
}
}
