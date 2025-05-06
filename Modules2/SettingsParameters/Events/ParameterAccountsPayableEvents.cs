using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SettingsParameters.ValueObjects;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to ParameterAccountsPayable entity
/// </summary>
public sealed class ParameterAccountsPayableCreatedEvent : DomainEvent
{
    public ParameterAccountsPayableId ParameterAccountsPayableId { get; }

    public ParameterAccountsPayableCreatedEvent(ParameterAccountsPayableId parameteraccountspayableId)
    {
        ParameterAccountsPayableId = parameteraccountspayableId;
    }
}

public sealed class ParameterAccountsPayableUpdatedEvent : DomainEvent
{
    public ParameterAccountsPayableId ParameterAccountsPayableId { get; }

    public ParameterAccountsPayableUpdatedEvent(ParameterAccountsPayableId parameteraccountspayableId)
    {
        ParameterAccountsPayableId = parameteraccountspayableId;
    }
}

public sealed class ParameterAccountsPayableDeletedEvent : DomainEvent
{
    public ParameterAccountsPayableId ParameterAccountsPayableId { get; }

    public ParameterAccountsPayableDeletedEvent(ParameterAccountsPayableId parameteraccountspayableId)
    {
        ParameterAccountsPayableId = parameteraccountspayableId;
    }
}
}
