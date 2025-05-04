using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to ParameterGeneral entity
/// </summary>
public sealed class ParameterGeneralCreatedEvent : DomainEvent
{
    public ParameterGeneralId ParameterGeneralId { get; }

    public ParameterGeneralCreatedEvent(ParameterGeneralId parametergeneralId)
    {
        ParameterGeneralId = parametergeneralId;
    }
}

public sealed class ParameterGeneralUpdatedEvent : DomainEvent
{
    public ParameterGeneralId ParameterGeneralId { get; }

    public ParameterGeneralUpdatedEvent(ParameterGeneralId parametergeneralId)
    {
        ParameterGeneralId = parametergeneralId;
    }
}

public sealed class ParameterGeneralDeletedEvent : DomainEvent
{
    public ParameterGeneralId ParameterGeneralId { get; }

    public ParameterGeneralDeletedEvent(ParameterGeneralId parametergeneralId)
    {
        ParameterGeneralId = parametergeneralId;
    }
}
}
