using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to ParameterGeneralLedger entity
/// </summary>
public sealed class ParameterGeneralLedgerCreatedEvent : DomainEvent
{
    public ParameterGeneralLedgerId ParameterGeneralLedgerId { get; }

    public ParameterGeneralLedgerCreatedEvent(ParameterGeneralLedgerId parametergeneralledgerId)
    {
        ParameterGeneralLedgerId = parametergeneralledgerId;
    }
}

public sealed class ParameterGeneralLedgerUpdatedEvent : DomainEvent
{
    public ParameterGeneralLedgerId ParameterGeneralLedgerId { get; }

    public ParameterGeneralLedgerUpdatedEvent(ParameterGeneralLedgerId parametergeneralledgerId)
    {
        ParameterGeneralLedgerId = parametergeneralledgerId;
    }
}

public sealed class ParameterGeneralLedgerDeletedEvent : DomainEvent
{
    public ParameterGeneralLedgerId ParameterGeneralLedgerId { get; }

    public ParameterGeneralLedgerDeletedEvent(ParameterGeneralLedgerId parametergeneralledgerId)
    {
        ParameterGeneralLedgerId = parametergeneralledgerId;
    }
}
}
