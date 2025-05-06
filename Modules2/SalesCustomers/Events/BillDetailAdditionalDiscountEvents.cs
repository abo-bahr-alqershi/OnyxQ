using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BillDetailAdditionalDiscount entity
/// </summary>
public sealed class BillDetailAdditionalDiscountCreatedEvent : DomainEvent
{
    public BillDetailAdditionalDiscountId BillDetailAdditionalDiscountId { get; }

    public BillDetailAdditionalDiscountCreatedEvent(BillDetailAdditionalDiscountId billdetailadditionaldiscountId)
    {
        BillDetailAdditionalDiscountId = billdetailadditionaldiscountId;
    }
}

public sealed class BillDetailAdditionalDiscountUpdatedEvent : DomainEvent
{
    public BillDetailAdditionalDiscountId BillDetailAdditionalDiscountId { get; }

    public BillDetailAdditionalDiscountUpdatedEvent(BillDetailAdditionalDiscountId billdetailadditionaldiscountId)
    {
        BillDetailAdditionalDiscountId = billdetailadditionaldiscountId;
    }
}

public sealed class BillDetailAdditionalDiscountDeletedEvent : DomainEvent
{
    public BillDetailAdditionalDiscountId BillDetailAdditionalDiscountId { get; }

    public BillDetailAdditionalDiscountDeletedEvent(BillDetailAdditionalDiscountId billdetailadditionaldiscountId)
    {
        BillDetailAdditionalDiscountId = billdetailadditionaldiscountId;
    }
}
}
