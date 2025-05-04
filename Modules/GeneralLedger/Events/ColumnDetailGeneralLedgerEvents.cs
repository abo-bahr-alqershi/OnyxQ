using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Events
{
/// <summary>
/// Events related to ColumnDetailGeneralLedger entity
/// </summary>
public sealed class ColumnDetailGeneralLedgerCreatedEvent : DomainEvent
{
    public ColumnDetailGeneralLedgerId ColumnDetailGeneralLedgerId { get; }

    public ColumnDetailGeneralLedgerCreatedEvent(ColumnDetailGeneralLedgerId columndetailgeneralledgerId)
    {
        ColumnDetailGeneralLedgerId = columndetailgeneralledgerId;
    }
}

public sealed class ColumnDetailGeneralLedgerUpdatedEvent : DomainEvent
{
    public ColumnDetailGeneralLedgerId ColumnDetailGeneralLedgerId { get; }

    public ColumnDetailGeneralLedgerUpdatedEvent(ColumnDetailGeneralLedgerId columndetailgeneralledgerId)
    {
        ColumnDetailGeneralLedgerId = columndetailgeneralledgerId;
    }
}

public sealed class ColumnDetailGeneralLedgerDeletedEvent : DomainEvent
{
    public ColumnDetailGeneralLedgerId ColumnDetailGeneralLedgerId { get; }

    public ColumnDetailGeneralLedgerDeletedEvent(ColumnDetailGeneralLedgerId columndetailgeneralledgerId)
    {
        ColumnDetailGeneralLedgerId = columndetailgeneralledgerId;
    }
}
}
