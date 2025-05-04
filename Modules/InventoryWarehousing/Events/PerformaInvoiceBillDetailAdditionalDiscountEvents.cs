using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to PerformaInvoiceBillDetailAdditionalDiscount entity
/// </summary>
public sealed class PerformaInvoiceBillDetailAdditionalDiscountCreatedEvent : DomainEvent
{
    public PerformaInvoiceBillDetailAdditionalDiscountId PerformaInvoiceBillDetailAdditionalDiscountId { get; }

    public PerformaInvoiceBillDetailAdditionalDiscountCreatedEvent(PerformaInvoiceBillDetailAdditionalDiscountId performainvoicebilldetailadditionaldiscountId)
    {
        PerformaInvoiceBillDetailAdditionalDiscountId = performainvoicebilldetailadditionaldiscountId;
    }
}

public sealed class PerformaInvoiceBillDetailAdditionalDiscountUpdatedEvent : DomainEvent
{
    public PerformaInvoiceBillDetailAdditionalDiscountId PerformaInvoiceBillDetailAdditionalDiscountId { get; }

    public PerformaInvoiceBillDetailAdditionalDiscountUpdatedEvent(PerformaInvoiceBillDetailAdditionalDiscountId performainvoicebilldetailadditionaldiscountId)
    {
        PerformaInvoiceBillDetailAdditionalDiscountId = performainvoicebilldetailadditionaldiscountId;
    }
}

public sealed class PerformaInvoiceBillDetailAdditionalDiscountDeletedEvent : DomainEvent
{
    public PerformaInvoiceBillDetailAdditionalDiscountId PerformaInvoiceBillDetailAdditionalDiscountId { get; }

    public PerformaInvoiceBillDetailAdditionalDiscountDeletedEvent(PerformaInvoiceBillDetailAdditionalDiscountId performainvoicebilldetailadditionaldiscountId)
    {
        PerformaInvoiceBillDetailAdditionalDiscountId = performainvoicebilldetailadditionaldiscountId;
    }
}
}
