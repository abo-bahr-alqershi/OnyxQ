using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BillDetailBackupTemp entity
/// </summary>
public sealed class BillDetailBackupTempCreatedEvent : DomainEvent
{
    public BillDetailBackupTempId BillDetailBackupTempId { get; }

    public BillDetailBackupTempCreatedEvent(BillDetailBackupTempId billdetailbackuptempId)
    {
        BillDetailBackupTempId = billdetailbackuptempId;
    }
}

public sealed class BillDetailBackupTempUpdatedEvent : DomainEvent
{
    public BillDetailBackupTempId BillDetailBackupTempId { get; }

    public BillDetailBackupTempUpdatedEvent(BillDetailBackupTempId billdetailbackuptempId)
    {
        BillDetailBackupTempId = billdetailbackuptempId;
    }
}

public sealed class BillDetailBackupTempDeletedEvent : DomainEvent
{
    public BillDetailBackupTempId BillDetailBackupTempId { get; }

    public BillDetailBackupTempDeletedEvent(BillDetailBackupTempId billdetailbackuptempId)
    {
        BillDetailBackupTempId = billdetailbackuptempId;
    }
}
}
