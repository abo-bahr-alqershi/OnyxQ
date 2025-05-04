using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SettingsParameters.Events
{
/// <summary>
/// Events related to ParameterAccountsReceivable entity
/// </summary>
public sealed class ParameterAccountsReceivableCreatedEvent : DomainEvent
{
    public ParameterAccountsReceivableId ParameterAccountsReceivableId { get; }

    public ParameterAccountsReceivableCreatedEvent(ParameterAccountsReceivableId parameteraccountsreceivableId)
    {
        ParameterAccountsReceivableId = parameteraccountsreceivableId;
    }
}

public sealed class ParameterAccountsReceivableUpdatedEvent : DomainEvent
{
    public ParameterAccountsReceivableId ParameterAccountsReceivableId { get; }

    public ParameterAccountsReceivableUpdatedEvent(ParameterAccountsReceivableId parameteraccountsreceivableId)
    {
        ParameterAccountsReceivableId = parameteraccountsreceivableId;
    }
}

public sealed class ParameterAccountsReceivableDeletedEvent : DomainEvent
{
    public ParameterAccountsReceivableId ParameterAccountsReceivableId { get; }

    public ParameterAccountsReceivableDeletedEvent(ParameterAccountsReceivableId parameteraccountsreceivableId)
    {
        ParameterAccountsReceivableId = parameteraccountsreceivableId;
    }
}
}
