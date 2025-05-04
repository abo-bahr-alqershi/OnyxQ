using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BillMasterAdditionalDiscount entity
/// </summary>
public sealed class BillMasterAdditionalDiscountCreatedEvent : DomainEvent
{
    public BillMasterAdditionalDiscountId BillMasterAdditionalDiscountId { get; }

    public BillMasterAdditionalDiscountCreatedEvent(BillMasterAdditionalDiscountId billmasteradditionaldiscountId)
    {
        BillMasterAdditionalDiscountId = billmasteradditionaldiscountId;
    }
}

public sealed class BillMasterAdditionalDiscountUpdatedEvent : DomainEvent
{
    public BillMasterAdditionalDiscountId BillMasterAdditionalDiscountId { get; }

    public BillMasterAdditionalDiscountUpdatedEvent(BillMasterAdditionalDiscountId billmasteradditionaldiscountId)
    {
        BillMasterAdditionalDiscountId = billmasteradditionaldiscountId;
    }
}

public sealed class BillMasterAdditionalDiscountDeletedEvent : DomainEvent
{
    public BillMasterAdditionalDiscountId BillMasterAdditionalDiscountId { get; }

    public BillMasterAdditionalDiscountDeletedEvent(BillMasterAdditionalDiscountId billmasteradditionaldiscountId)
    {
        BillMasterAdditionalDiscountId = billmasteradditionaldiscountId;
    }
}
}
