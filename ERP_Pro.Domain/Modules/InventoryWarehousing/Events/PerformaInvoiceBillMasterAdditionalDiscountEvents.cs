using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Events
{
/// <summary>
/// Events related to PerformaInvoiceBillMasterAdditionalDiscount entity
/// </summary>
public sealed class PerformaInvoiceBillMasterAdditionalDiscountCreatedEvent : DomainEvent
{
    public PerformaInvoiceBillMasterAdditionalDiscountId PerformaInvoiceBillMasterAdditionalDiscountId { get; }

    public PerformaInvoiceBillMasterAdditionalDiscountCreatedEvent(PerformaInvoiceBillMasterAdditionalDiscountId performainvoicebillmasteradditionaldiscountId)
    {
        PerformaInvoiceBillMasterAdditionalDiscountId = performainvoicebillmasteradditionaldiscountId;
    }
}

public sealed class PerformaInvoiceBillMasterAdditionalDiscountUpdatedEvent : DomainEvent
{
    public PerformaInvoiceBillMasterAdditionalDiscountId PerformaInvoiceBillMasterAdditionalDiscountId { get; }

    public PerformaInvoiceBillMasterAdditionalDiscountUpdatedEvent(PerformaInvoiceBillMasterAdditionalDiscountId performainvoicebillmasteradditionaldiscountId)
    {
        PerformaInvoiceBillMasterAdditionalDiscountId = performainvoicebillmasteradditionaldiscountId;
    }
}

public sealed class PerformaInvoiceBillMasterAdditionalDiscountDeletedEvent : DomainEvent
{
    public PerformaInvoiceBillMasterAdditionalDiscountId PerformaInvoiceBillMasterAdditionalDiscountId { get; }

    public PerformaInvoiceBillMasterAdditionalDiscountDeletedEvent(PerformaInvoiceBillMasterAdditionalDiscountId performainvoicebillmasteradditionaldiscountId)
    {
        PerformaInvoiceBillMasterAdditionalDiscountId = performainvoicebillmasteradditionaldiscountId;
    }
}
}
