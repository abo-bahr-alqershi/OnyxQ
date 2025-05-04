using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to IncomeType entity
/// </summary>
public sealed class IncomeTypeCreatedEvent : DomainEvent
{
    public IncomeTypeId IncomeTypeId { get; }

    public IncomeTypeCreatedEvent(IncomeTypeId incometypeId)
    {
        IncomeTypeId = incometypeId;
    }
}

public sealed class IncomeTypeUpdatedEvent : DomainEvent
{
    public IncomeTypeId IncomeTypeId { get; }

    public IncomeTypeUpdatedEvent(IncomeTypeId incometypeId)
    {
        IncomeTypeId = incometypeId;
    }
}

public sealed class IncomeTypeDeletedEvent : DomainEvent
{
    public IncomeTypeId IncomeTypeId { get; }

    public IncomeTypeDeletedEvent(IncomeTypeId incometypeId)
    {
        IncomeTypeId = incometypeId;
    }
}
}
