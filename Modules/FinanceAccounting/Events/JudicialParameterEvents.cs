using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to JudicialParameter entity
/// </summary>
public sealed class JudicialParameterCreatedEvent : DomainEvent
{
    public JudicialParameterId JudicialParameterId { get; }

    public JudicialParameterCreatedEvent(JudicialParameterId judicialparameterId)
    {
        JudicialParameterId = judicialparameterId;
    }
}

public sealed class JudicialParameterUpdatedEvent : DomainEvent
{
    public JudicialParameterId JudicialParameterId { get; }

    public JudicialParameterUpdatedEvent(JudicialParameterId judicialparameterId)
    {
        JudicialParameterId = judicialparameterId;
    }
}

public sealed class JudicialParameterDeletedEvent : DomainEvent
{
    public JudicialParameterId JudicialParameterId { get; }

    public JudicialParameterDeletedEvent(JudicialParameterId judicialparameterId)
    {
        JudicialParameterId = judicialparameterId;
    }
}
}
