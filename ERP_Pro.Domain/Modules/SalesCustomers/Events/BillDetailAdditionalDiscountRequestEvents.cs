using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BillDetailAdditionalDiscountRequest entity
/// </summary>
public sealed class BillDetailAdditionalDiscountRequestCreatedEvent : DomainEvent
{
    public BillDetailAdditionalDiscountRequestId BillDetailAdditionalDiscountRequestId { get; }

    public BillDetailAdditionalDiscountRequestCreatedEvent(BillDetailAdditionalDiscountRequestId billdetailadditionaldiscountrequestId)
    {
        BillDetailAdditionalDiscountRequestId = billdetailadditionaldiscountrequestId;
    }
}

public sealed class BillDetailAdditionalDiscountRequestUpdatedEvent : DomainEvent
{
    public BillDetailAdditionalDiscountRequestId BillDetailAdditionalDiscountRequestId { get; }

    public BillDetailAdditionalDiscountRequestUpdatedEvent(BillDetailAdditionalDiscountRequestId billdetailadditionaldiscountrequestId)
    {
        BillDetailAdditionalDiscountRequestId = billdetailadditionaldiscountrequestId;
    }
}

public sealed class BillDetailAdditionalDiscountRequestDeletedEvent : DomainEvent
{
    public BillDetailAdditionalDiscountRequestId BillDetailAdditionalDiscountRequestId { get; }

    public BillDetailAdditionalDiscountRequestDeletedEvent(BillDetailAdditionalDiscountRequestId billdetailadditionaldiscountrequestId)
    {
        BillDetailAdditionalDiscountRequestId = billdetailadditionaldiscountrequestId;
    }
}
}
