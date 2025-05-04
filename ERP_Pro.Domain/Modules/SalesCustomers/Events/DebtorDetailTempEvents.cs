using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to DebtorDetailTemp entity
/// </summary>
public sealed class DebtorDetailTempCreatedEvent : DomainEvent
{
    public DebtorDetailTempId DebtorDetailTempId { get; }

    public DebtorDetailTempCreatedEvent(DebtorDetailTempId debtordetailtempId)
    {
        DebtorDetailTempId = debtordetailtempId;
    }
}

public sealed class DebtorDetailTempUpdatedEvent : DomainEvent
{
    public DebtorDetailTempId DebtorDetailTempId { get; }

    public DebtorDetailTempUpdatedEvent(DebtorDetailTempId debtordetailtempId)
    {
        DebtorDetailTempId = debtordetailtempId;
    }
}

public sealed class DebtorDetailTempDeletedEvent : DomainEvent
{
    public DebtorDetailTempId DebtorDetailTempId { get; }

    public DebtorDetailTempDeletedEvent(DebtorDetailTempId debtordetailtempId)
    {
        DebtorDetailTempId = debtordetailtempId;
    }
}
}
