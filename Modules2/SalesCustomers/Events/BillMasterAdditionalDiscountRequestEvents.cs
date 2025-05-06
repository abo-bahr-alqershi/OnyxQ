using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Events
{
/// <summary>
/// Events related to BillMasterAdditionalDiscountRequest entity
/// </summary>
public sealed class BillMasterAdditionalDiscountRequestCreatedEvent : DomainEvent
{
    public BillMasterAdditionalDiscountRequestId BillMasterAdditionalDiscountRequestId { get; }

    public BillMasterAdditionalDiscountRequestCreatedEvent(BillMasterAdditionalDiscountRequestId billmasteradditionaldiscountrequestId)
    {
        BillMasterAdditionalDiscountRequestId = billmasteradditionaldiscountrequestId;
    }
}

public sealed class BillMasterAdditionalDiscountRequestUpdatedEvent : DomainEvent
{
    public BillMasterAdditionalDiscountRequestId BillMasterAdditionalDiscountRequestId { get; }

    public BillMasterAdditionalDiscountRequestUpdatedEvent(BillMasterAdditionalDiscountRequestId billmasteradditionaldiscountrequestId)
    {
        BillMasterAdditionalDiscountRequestId = billmasteradditionaldiscountrequestId;
    }
}

public sealed class BillMasterAdditionalDiscountRequestDeletedEvent : DomainEvent
{
    public BillMasterAdditionalDiscountRequestId BillMasterAdditionalDiscountRequestId { get; }

    public BillMasterAdditionalDiscountRequestDeletedEvent(BillMasterAdditionalDiscountRequestId billmasteradditionaldiscountrequestId)
    {
        BillMasterAdditionalDiscountRequestId = billmasteradditionaldiscountrequestId;
    }
}
}
