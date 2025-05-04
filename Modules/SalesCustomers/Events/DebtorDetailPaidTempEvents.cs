using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to DebtorDetailPaidTemp entity
/// </summary>
public sealed class DebtorDetailPaidTempCreatedEvent : DomainEvent
{
    public DebtorDetailPaidTempId DebtorDetailPaidTempId { get; }

    public DebtorDetailPaidTempCreatedEvent(DebtorDetailPaidTempId debtordetailpaidtempId)
    {
        DebtorDetailPaidTempId = debtordetailpaidtempId;
    }
}

public sealed class DebtorDetailPaidTempUpdatedEvent : DomainEvent
{
    public DebtorDetailPaidTempId DebtorDetailPaidTempId { get; }

    public DebtorDetailPaidTempUpdatedEvent(DebtorDetailPaidTempId debtordetailpaidtempId)
    {
        DebtorDetailPaidTempId = debtordetailpaidtempId;
    }
}

public sealed class DebtorDetailPaidTempDeletedEvent : DomainEvent
{
    public DebtorDetailPaidTempId DebtorDetailPaidTempId { get; }

    public DebtorDetailPaidTempDeletedEvent(DebtorDetailPaidTempId debtordetailpaidtempId)
    {
        DebtorDetailPaidTempId = debtordetailpaidtempId;
    }
}
}
