using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Events
{
/// <summary>
/// Events related to CheckIncomeMaster entity
/// </summary>
public sealed class CheckIncomeMasterCreatedEvent : DomainEvent
{
    public CheckIncomeMasterId CheckIncomeMasterId { get; }

    public CheckIncomeMasterCreatedEvent(CheckIncomeMasterId checkincomemasterId)
    {
        CheckIncomeMasterId = checkincomemasterId;
    }
}

public sealed class CheckIncomeMasterUpdatedEvent : DomainEvent
{
    public CheckIncomeMasterId CheckIncomeMasterId { get; }

    public CheckIncomeMasterUpdatedEvent(CheckIncomeMasterId checkincomemasterId)
    {
        CheckIncomeMasterId = checkincomemasterId;
    }
}

public sealed class CheckIncomeMasterDeletedEvent : DomainEvent
{
    public CheckIncomeMasterId CheckIncomeMasterId { get; }

    public CheckIncomeMasterDeletedEvent(CheckIncomeMasterId checkincomemasterId)
    {
        CheckIncomeMasterId = checkincomemasterId;
    }
}
}
